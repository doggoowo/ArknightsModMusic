using NVorbis;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Terraria;
using Terraria.ModLoader;

namespace ArknightsModMusic.Core.Systems
{
    /// <summary>
    /// 获取所有曲目时长工具，在加载时调用，存音乐id→时长(s)的字典
    /// </summary>
    public class MusicDurationSystem : ModSystem
    {
        public static Dictionary<int, float> TrackDurations { get; private set; } = new();

        public void LoadMusicDurations(MusicPlayingSystem playSystem)
        {
            if (Main.dedServ) return;

            TrackDurations = new Dictionary<int, float>();

            // 反射获取MusicLoader的两个字段
            var byPath = typeof(MusicLoader).GetField("musicByPath",
                BindingFlags.NonPublic | BindingFlags.Static)
                ?.GetValue(null) as Dictionary<string, int>;

            var extensions = typeof(MusicLoader).GetField("musicExtensions",
                BindingFlags.NonPublic | BindingFlags.Static)
                ?.GetValue(null) as Dictionary<string, string>;

            if (byPath == null || extensions == null)
            {
                Mod.Logger.Error("[MusicDuration] 反射 MusicLoader 字段失败");
                return;
            }

            //反查 slot 到 path
            var slotToPath = byPath.ToDictionary(kv => kv.Value, kv => kv.Key);

            var allIds = playSystem.AllScenes
                .SelectMany(s => s.TrackIds)
                .Distinct();

            foreach (int id in allIds)
            {
                if (!slotToPath.TryGetValue(id, out string musicPath)) continue;
                if (!extensions.TryGetValue(musicPath, out string ext)) continue;

                // 只处理自己mod名字开头的音乐
                if (!musicPath.StartsWith(Mod.Name + "/")) continue;

                float duration = ReadDuration(musicPath, ext);
                if (duration > 0f)
                {
                    TrackDurations[id] = duration;
                    Mod.Logger.Debug($"[MusicDuration] id:{id} {musicPath}{ext} → {duration:F2}s");
                }
                else
                {
                    Mod.Logger.Warn($"[MusicDuration] id:{id} {musicPath}{ext} 读取失败");
                }
            }
        }

        private float ReadDuration(string musicPath, string ext)
        {
            // ModContent.OpenRead 的路径格式和 MusicLoader.LoadMusic 一致
            string tmodPath = $"tmod:{musicPath}{ext}";
            try
            {
                using var stream = ModContent.OpenRead(tmodPath, newFileStream: true);

                return ext switch
                {
                    ".ogg" => ReadOgg(stream),
                    ".wav" => ReadWav(stream),
                    ".mp3" => -1f, //!!不支持MP3格式!!
                    _ => -1f
                };
            }
            catch (Exception e)
            {
                Mod.Logger.Warn($"[MusicDuration] OpenRead 异常 {tmodPath}: {e.Message}");
                return -1f;
            }
        }

        private static float ReadOgg(Stream stream)
        {
            using var reader = new VorbisReader(stream, closeOnDispose: true);
            return (float)reader.TotalTime.TotalSeconds;
        }

        private static float ReadWav(Stream stream)
        {
            using var br = new BinaryReader(stream);
            // WAV: NumChannels @ 22, SampleRate @ 24, data chunk size @ 40（标准 PCM 44字节头）
            br.BaseStream.Seek(22, SeekOrigin.Begin);
            int channels = br.ReadInt16();
            int sampleRate = br.ReadInt32();
            br.BaseStream.Seek(40, SeekOrigin.Begin);
            int dataSize = br.ReadInt32();
            return (float)dataSize / (sampleRate * channels * 2); // 16-bit = 2 bytes/sample
        }

        public override void Unload()
        {
            TrackDurations?.Clear();
            TrackDurations = null;
        }
    }
}