using ArknightsModMusic.Configs;
using ArknightsModMusic.Core.MusicScenes;
using log4net;
using Mono.Cecil.Cil;
using MonoMod.Cil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Core;

namespace ArknightsModMusic.Core.Systems
{
    public class MusicPlayingSystem : ModSystem
    {
        private static PropertyInfo _fileProperty;
        private static MethodInfo _fileGetter;
        public List<MusicScene> AllScenes;

        // 两套hook各自的轮换状态，key是场景标识
        // IL场景用scene对象引用做key，On场景同理
        private static readonly Dictionary<MusicScene, ScenePlayState> _playStates = new();
        private static ILog ILLogger => ModContent.GetInstance<ArknightsModMusic>().Logger;
        private class ScenePlayState
        {
            public int CurrentTrack = -1;
            public int ElapsedFrames = 0;
            public int DurationFrames = 0; // 0 = 未知时长，不计时，也不自动切换，仅在进出场景随机
        }

        #region 公共选曲逻辑

        /// <summary>
        /// 为指定场景选出应该播放的 trackId。
        /// 首次进入（currentTrack 不在列表里）→ 随机选。
        /// 时长到了 → 排除当前随机选下一首。
        /// 否则 → 保持当前。
        /// </summary>
        private static int PickTrack(MusicScene scene)
        {
            if (!_playStates.TryGetValue(scene, out var state))
            {
                state = new ScenePlayState();
                _playStates[scene] = state;
            }

            bool trackInScene = scene.TrackIds.Contains(state.CurrentTrack);

            if (!trackInScene)
            {
                //进入场景随机选曲
                state.CurrentTrack = scene.TrackIds[Main.rand.Next(scene.TrackIds.Count)];
                state.ElapsedFrames = 0;
                state.DurationFrames = GetDurationFrames(state.CurrentTrack);
            }
            else
            {
                state.ElapsedFrames++;

                //到时间换曲
                bool timeUp = state.DurationFrames > 0 && state.ElapsedFrames >= state.DurationFrames - 150;
                if (timeUp)
                {
                    int next = PickNext(scene, state.CurrentTrack);
                    state.CurrentTrack = next;
                    state.ElapsedFrames = 0;
                    state.DurationFrames = GetDurationFrames(next);
                }
            }

            return state.CurrentTrack;
        }

        private static int PickNext(MusicScene scene, int currentTrack)
        {
            if (scene.TrackIds.Count == 1)
                return currentTrack;
            var others = scene.TrackIds.Where(id => id != currentTrack).ToList();
            return others[Main.rand.Next(others.Count)];
        }

        private static int GetDurationFrames(int trackId)
        {
            var durations = MusicDurationSystem.TrackDurations;
            if (durations == null || !durations.TryGetValue(trackId, out float seconds))
                return 0;
            return (int)(seconds * (1.0 / Main.gameTimeCache.ElapsedGameTime.TotalSeconds));
        }

        /// <summary>
        /// 场景不再匹配时清理对应状态，避免下次进入时残留 ElapsedFrames
        /// </summary>
        private static void ClearState(MusicScene scene)
        {
            _playStates.Remove(scene);
        }

        #endregion

        #region 加载AllScenes和所有音乐时长

        public override void PostSetupContent()
        {
            if (Main.dedServ)
                return;
            LoadScenes();
            ModContent.GetInstance<MusicDurationSystem>().LoadMusicDurations(this);
        }

        private void LoadScenes()
        {
            var config = ModContent.GetInstance<MusicConfig>();

            AllScenes = GetType().Assembly
                .GetTypes()
                .Where(t => t.IsSubclassOf(typeof(MusicScene)) && !t.IsAbstract)
                .Select(t => (MusicScene)Activator.CreateInstance(t))
                .Where(scene =>
                    (scene.IsOtherworldly && config.EnableOtherworldlyModMusic) ||
                    (!scene.IsOtherworldly && config.EnableDefaultModMusic))
                .ToList();

            foreach (var scene in AllScenes)
            {
                LoadAllMusicInPath(scene.Path, out List<int> ids);
                scene.TrackIds = ids;
            }

            Mod.Logger.Info($"Found and loaded {AllScenes.Count} tracks.");
        }

        private void LoadAllMusicInPath(string path, out List<int> ids)
        {
            ids = new List<int>();
            if (_fileGetter == null)
                return;
            var modFile = _fileGetter.Invoke(Mod, null) as TmodFile;
            if (modFile == null)
                return;

            string normalizedPath = path.Replace('\\', '/').TrimEnd('/') + '/';

            var musicFiles = modFile.GetFileNames()
                .Where(name => name.EndsWith(".ogg") || name.EndsWith(".wav") || name.EndsWith(".mp3"))
                .Where(name => name.StartsWith(normalizedPath))
                .ToList();

            foreach (var name in musicFiles)
            {
                string slotPath = name.Replace(".ogg", "").Replace(".wav", "").Replace(".mp3", "");
                int slot = MusicLoader.GetMusicSlot(Mod, slotPath);
                if (slot > 0)
                {
                    ids.Add(slot);
                    if (slot < MusicID.Count)
                        Mod.Logger.Warn($"{slotPath} loaded but slot ({slot}) < MusicID.Count ({MusicID.Count}) – this may be a bug caused by another mod.");
                    else
                        Mod.Logger.Debug($"{slotPath} loaded (id:{slot})");
                }
                else
                {
                    Mod.Logger.Error($"{slotPath} failed to load (id:{slot})");
                }
            }
        }

        #endregion

        public override void Load()
        {
            if (Main.dedServ)
                return;

            AllScenes ??= new List<MusicScene>();

            if (_fileProperty == null)
            {
                _fileProperty = typeof(Mod).GetProperty("File",
                    BindingFlags.NonPublic | BindingFlags.Instance);
                _fileGetter = _fileProperty?.GetGetMethod(nonPublic: true);
            }

            IL_Main.UpdateAudio_DecideOnNewMusic += IL_DecideOnMusic;
            On_Main.UpdateAudio_DecideOnNewMusic += On_DecideOnDefaultMusic;

            IL_Main.UpdateAudio_DecideOnTOWMusic += IL_DecideOnMusic;
            On_Main.UpdateAudio_DecideOnTOWMusic += On_DecideOnOtherworldlyMusic;
        }

        public override void Unload()
        {
            IL_Main.UpdateAudio_DecideOnTOWMusic -= IL_DecideOnMusic;
            On_Main.UpdateAudio_DecideOnTOWMusic -= On_DecideOnOtherworldlyMusic;

            IL_Main.UpdateAudio_DecideOnNewMusic -= IL_DecideOnMusic;
            On_Main.UpdateAudio_DecideOnNewMusic -= On_DecideOnDefaultMusic;
            AllScenes = null;
            _playStates.Clear();
        }

        #region IL Hook（普通Condition场景，Default和Otherworldly统一逻辑）

        public static void IL_DecideOnMusic(ILContext context)
        {
            var cursor = new ILCursor(context);
            int modMusicIndex = -1;
            int modPriorityIndex = -1;

            // 先找modMusic = -1
            if (cursor.TryGotoNext(MoveType.After,
                instr => instr.MatchLdcI4(-1),
                instr => instr.MatchStloc(out modMusicIndex)))
            {
                // 继续找，紧跟着的就是 modPriority = None
                if (!cursor.TryGotoNext(MoveType.After,
                    instr => instr.MatchLdcI4(0),
                    instr => instr.MatchStloc(out modPriorityIndex)))
                {
                    ILLogger.Error("IL Hook: Failed to find 'modPriority' index");
                    return;
                }
            }
            else
            {
                ILLogger.Error("IL Hook: Failed to find 'modMusic' index");
                return;
            }

            bool isOtherworldly = context.Method.Name == "Terraria.Main::UpdateAudio_DecideOnTOWMusic";

            ILLogger.Debug($"IL Hook ({context.Method.Name}), modMusicIndex={modMusicIndex}, modPriorityIndex={modPriorityIndex}, " +
                $"isOtherworldly: {isOtherworldly}");

            cursor.Goto(0); // 回到开头

            if (cursor.TryGotoNext(MoveType.Before, // 找到UpdateMusic并定位到之前
                instr => instr.MatchCallvirt("Terraria.ModLoader.SceneEffectLoader", "UpdateMusic")))
            {
                cursor.Emit(OpCodes.Ldloca, modMusicIndex);
                cursor.Emit(OpCodes.Ldloca, modPriorityIndex);
                cursor.Emit(OpCodes.Ldc_I4, isOtherworldly ? 1 : 0); // 传入bool参数
                cursor.Emit(OpCodes.Call, typeof(MusicPlayingSystem).GetMethod(
                    nameof(IL_OnDefaultMusicDecided), BindingFlags.Static | BindingFlags.NonPublic));
            }
        }

        private static void IL_OnDefaultMusicDecided(ref int modMusic, ref SceneEffectPriority modPriority, bool isOtherworldly)
        {
            var system = ModContent.GetInstance<MusicPlayingSystem>();

            var activeScenes = system.AllScenes
                .Where(scene => scene.IsEnabled && scene.IsOtherworldly == isOtherworldly && scene.Condition(Main.LocalPlayer))
                .ToList();
            // 清理不活跃的状态
            var inactiveConditionScenes = system.AllScenes
                .Where(scene => scene.Condition != null && !activeScenes.Contains(scene) && scene.IsOtherworldly == isOtherworldly
                    && scene.ReplaceMusicId == null); // 只清理纯条件场景，不动替换场景
            foreach (var scene in inactiveConditionScenes)
                ClearState(scene);

            if (activeScenes.Count == 0) return;

            var highest = activeScenes.OrderByDescending(s => s.Priority).First();
            if (highest == null || highest.TrackIds.Count == 0) return;

            // 只在高优先级时覆盖，不要吞掉 ModNPC / ModSceneEffect 已经设好的音乐
            if (highest.Priority <= modPriority)
                return;

            int trackId = PickTrack(highest);
            modMusic = trackId;
            modPriority = highest.Priority;
        }

        #endregion

        #region On Hook（替换场景，统一逻辑）
        private void On_DecideOnDefaultMusic(On_Main.orig_UpdateAudio_DecideOnNewMusic orig, Main self)
        {
            orig.Invoke(self);
            HandleReplaceMusic();

        }

        private void On_DecideOnOtherworldlyMusic(On_Main.orig_UpdateAudio_DecideOnTOWMusic orig, Main self)
        {
            orig.Invoke(self);
            HandleReplaceMusic();
        }

        /// <summary>替换场景统一逻辑</summary>
        private void HandleReplaceMusic()
        {
            if (AllScenes.Count == 0) return;

            var matchedScene = AllScenes.FirstOrDefault(
                scene => scene.IsEnabled &&
                         scene.ReplaceMusicId == Main.newMusic &&
                         scene.ReplaceCondition(Main.LocalPlayer));

            // 清理本帧不匹配的Replace场景状态
            var unmatchedReplaceScenes = AllScenes
                .Where(scene => scene.ReplaceMusicId > 0 && scene != matchedScene);
            foreach (var scene in unmatchedReplaceScenes)
                ClearState(scene);

            if (matchedScene == null || matchedScene.TrackIds.Count == 0) return;

            int trackId = PickTrack(matchedScene);
            Main.newMusic = trackId;
            Main.curMusic = Main.newMusic;

            // 那好啊，他特判我也特判
            if (matchedScene.ReplaceMusicId == 51)
            {
                Main.musicNoCrossFade[51] = false;
            }
        }
        #endregion
    }
}