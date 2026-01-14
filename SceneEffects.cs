using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria;
using tModPorter;

namespace ArknightsModMusic
{
    public abstract class SceneMusicLoaden : ModSceneEffect {
        public abstract string FileName { get; }
        public abstract bool IsEnabled { get; }
        public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/" + FileName);
        public override SceneEffectPriority Priority => SceneEffectPriority.BiomeHigh;
        public override bool IsLoadingEnabled(Mod mod) => IsEnabled;
        public MusicConfig Config => ModContent.GetInstance<MusicConfig>();
        public bool IsAtOceanEdge(Player p) => p.active && (p.position.X <= 6080 || p.position.X >= (Main.maxTilesX * 16) - 6080);
    }

    // --- 沙漠 ---
    public class Music_DesertDay : SceneMusicLoaden {
        public override string FileName => "塞壬唱片-MSR & Gareth Coker - 细沙";
        public override bool IsEnabled => Config.EnableDesertDay;
        public override bool IsSceneEffectActive(Player p) => p.ZoneDesert && Main.dayTime;
    }

    public class Music_DesertNight : SceneMusicLoaden {
        public override string FileName => "塞壬唱片-MSR & Gareth Coker - From The Desert";
        public override bool IsEnabled => Config.EnableDesertNight;
        public override bool IsSceneEffectActive(Player p) => p.ZoneDesert && !Main.dayTime;
    }

    public class Music_DesertUnderground : SceneMusicLoaden {
        public override string FileName => "塞壬唱片-MSR & Eagle Wei - 烈阳与刀刃";
        public override bool IsEnabled => Config.EnableDesertUnderground;
        public override bool IsSceneEffectActive(Player p) => p.ZoneUndergroundDesert;
    }

    // --- 丛林 ---
    public class Music_JungleDay : SceneMusicLoaden {
        public override string FileName => "塞壬唱片-MSR - 绿洲";
        public override bool IsEnabled => Config.EnableJungleDay;
        public override bool IsSceneEffectActive(Player p) => p.ZoneJungle && Main.dayTime;
    }

    public class Music_JungleNight : SceneMusicLoaden {
        public override string FileName => "塞壬唱片-MSR & KK ZHANG - 逐猎";
        public override bool IsEnabled => Config.EnableJungleNight;
        public override bool IsSceneEffectActive(Player p) => p.ZoneJungle && !Main.dayTime;
    }

    public class Music_JungleUnderground : SceneMusicLoaden {
        public override string FileName => "塞壬唱片-MSR & Eagle Wei - 恐惧暗潮";
        public override bool IsEnabled => Config.EnableJungleUnderground;
        public override bool IsSceneEffectActive(Player p) => p.ZoneJungle && p.ZoneDirtLayerHeight;
    }

    // --- 雪地 ---
    public class Music_SnowDay : SceneMusicLoaden {
        public override string FileName => "塞壬唱片-MSR & Adam Gubman - 因非冰原";
        public override bool IsEnabled => Config.EnableSnowDay;
        public override bool IsSceneEffectActive(Player p) => p.ZoneSnow && Main.dayTime;
    }

    public class Music_SnowNight : SceneMusicLoaden {
        public override string FileName => "塞壬唱片-MSR & Adam Gubman - 远见终界";
        public override bool IsEnabled => Config.EnableSnowNight;
        public override bool IsSceneEffectActive(Player p) => p.ZoneSnow && !Main.dayTime;
    }

    public class Music_SnowUnderground : SceneMusicLoaden {
        public override string FileName => "塞壬唱片-MSR & Adam Gubman - 归还荒野";
        public override bool IsEnabled => Config.EnableSnowUnderground;
        public override bool IsSceneEffectActive(Player p) => p.ZoneSnow && p.ZoneRockLayerHeight;
    }

    // --- 神圣 ---
    public class Music_HallowDay : SceneMusicLoaden {
        public override string FileName => "塞壬唱片-MSR & Erik Castro - 不存在的乐园";
        public override bool IsEnabled => Config.EnableHallowDay;
        public override bool IsSceneEffectActive(Player p) => p.ZoneHallow && Main.dayTime;
    }

    public class Music_HallowNight : SceneMusicLoaden {
        public override string FileName => "塞壬唱片-MSR & Erik Castro - 圣城日常";
        public override bool IsEnabled => Config.EnableHallowNight;
        public override bool IsSceneEffectActive(Player p) => p.ZoneHallow && !Main.dayTime;
    }

    public class Music_HallowUnderground : SceneMusicLoaden {
        public override string FileName => "塞壬唱片-MSR & Erik Castro - 无罪之人";
        public override bool IsEnabled => Config.EnableHallowUnderground;
        public override bool IsSceneEffectActive(Player p) => p.ZoneHallow && p.ZoneRockLayerHeight;
    }

    // --- 腐化 ---
    public class Music_CorruptSurface : SceneMusicLoaden {
        public override string FileName => "塞壬唱片-MSR - 荣光暗沉";
        public override bool IsEnabled => Config.EnableCorruptSurface;
        public override bool IsSceneEffectActive(Player p) => p.ZoneCorrupt && p.ZoneOverworldHeight;
    }

    public class Music_CorruptUnderground : SceneMusicLoaden {
        public override string FileName => "塞壬唱片-MSR & LJCH - Wecgas fore tham Cynge, Searu fore tham Ethle";
        public override bool IsEnabled => Config.EnableCorruptUnderground;
        public override bool IsSceneEffectActive(Player p) => p.ZoneCorrupt && p.ZoneRockLayerHeight;
    }

    // --- 太空与地狱 ---
    public class Music_SpaceDay : SceneMusicLoaden {
        public override string FileName => "塞壬唱片-MSR & Steven Grove - Ad astra";
        public override bool IsEnabled => Config.EnableSpaceDay;
        public override SceneEffectPriority Priority => SceneEffectPriority.Environment;
        public override bool IsSceneEffectActive(Player p) => p.ZoneSkyHeight && Main.dayTime;
    }

    public class Music_SpaceNight : SceneMusicLoaden {
        public override string FileName => "塞壬唱片-MSR & Eagle Wei - 群星见我";
        public override bool IsEnabled => Config.EnableSpaceNight;
        public override SceneEffectPriority Priority => SceneEffectPriority.Environment;
        public override bool IsSceneEffectActive(Player p) => p.ZoneSkyHeight && !Main.dayTime;
    }

    public class Music_Hell : SceneMusicLoaden {
        public override string FileName => "塞壬唱片-MSR - Wavering Flame";
        public override bool IsEnabled => Config.EnableHell;
        public override SceneEffectPriority Priority => SceneEffectPriority.Environment;
        public override bool IsSceneEffectActive(Player p) => p.ZoneUnderworldHeight;
    }

    // --- 特殊事件 ---
    public class Music_BloodMoon : SceneMusicLoaden {
        public override string FileName => "塞壬唱片-MSR & Adam Gubman - 行文之韵";
        public override bool IsEnabled => Config.EnableBloodMoon;
        public override SceneEffectPriority Priority => SceneEffectPriority.Event;
        public override bool IsSceneEffectActive(Player p) => Main.bloodMoon;
    }

    public class Music_Meteor : SceneMusicLoaden {
        public override string FileName => "塞壬唱片-MSR & Steven Grove - 深层迷醉";
        public override bool IsEnabled => Config.EnableMeteor;
        public override bool IsSceneEffectActive(Player p) => p.ZoneMeteor;
    }

    public class Music_Graveyard : SceneMusicLoaden {
        public override string FileName => "塞壬唱片-MSR & Adam Gubman - 熏陶";
        public override bool IsEnabled => Config.EnableGraveyard;
        public override bool IsSceneEffectActive(Player p) => p.ZoneGraveyard;
    }
    // --- 腐化海洋 ---
    public class Music_CorruptedOceanDay : SceneMusicLoaden {
        public override string FileName => "darktides";
        public override bool IsEnabled => Config.EnableArknightsCorruptedOceanDaytime;
        public override bool IsSceneEffectActive(Player p) => IsAtOceanEdge(p) && Main.dayTime && p.ZoneCorrupt && !p.ZoneCrimson && !p.ZoneHallow;
    }

    public class Music_CorruptedOceanNight : SceneMusicLoaden {
        public override string FileName => "spread";
        public override bool IsEnabled => Config.EnableArknightsCorruptedOceanNighttime;
        public override bool IsSceneEffectActive(Player p) => IsAtOceanEdge(p) && !Main.dayTime && p.ZoneCorrupt && !p.ZoneCrimson && !p.ZoneHallow;
    }

    // --- 血腥海洋 ---
    public class Music_CrimsonOceanDay : SceneMusicLoaden {
        public override string FileName => "resonance";
        public override bool IsEnabled => Config.EnableArknightsCrimsonOceanDaytime;
        public override bool IsSceneEffectActive(Player p) => IsAtOceanEdge(p) && Main.dayTime && !p.ZoneCorrupt && p.ZoneCrimson && !p.ZoneHallow;
    }

    public class Music_CrimsonOceanNight : SceneMusicLoaden {
        public override string FileName => "eternalreef";
        public override bool IsEnabled => Config.EnableArknightsCrimsonOceanNighttime;
        public override bool IsSceneEffectActive(Player p) => IsAtOceanEdge(p) && !Main.dayTime && !p.ZoneCorrupt && p.ZoneCrimson && !p.ZoneHallow;
    }

    // --- 神圣海洋 ---
    public class Music_HallowedOceanDay : SceneMusicLoaden {
        public override string FileName => "pathoflife";
        public override bool IsEnabled => Config.EnableArknightsHallowedOceanDaytime;
        public override bool IsSceneEffectActive(Player p) => IsAtOceanEdge(p) && Main.dayTime && !p.ZoneCorrupt && !p.ZoneCrimson && p.ZoneHallow;
    }

    public class Music_HallowedOceanNight : SceneMusicLoaden {
        public override string FileName => "upsidedowntreeshadow";
        public override bool IsEnabled => Config.EnableArknightsHallowedOceanNighttime;
        public override bool IsSceneEffectActive(Player p) => IsAtOceanEdge(p) && !Main.dayTime && !p.ZoneCorrupt && !p.ZoneCrimson && p.ZoneHallow;
    }

    // --- 普通海洋 ---
    public class Music_OceanDay : SceneMusicLoaden {
        public override string FileName => "ready";
        public override bool IsEnabled => Config.EnableArknightsOceanDaytime;
        public override SceneEffectPriority Priority => SceneEffectPriority.BiomeLow;
        public override bool IsSceneEffectActive(Player p) => p.active && p.ZoneBeach && Main.dayTime && p.ZoneOverworldHeight && !p.ZoneCorrupt && !p.ZoneCrimson;
    }

    public class Music_OceanNight : SceneMusicLoaden {
        public override string FileName => "seawonder";
        public override bool IsEnabled => Config.EnableArknightsOceanNighttime;
        public override SceneEffectPriority Priority => SceneEffectPriority.BiomeLow;
        public override bool IsSceneEffectActive(Player p) => p.active && p.ZoneBeach && !Main.dayTime && p.ZoneOverworldHeight && !p.ZoneCorrupt && !p.ZoneCrimson;
    }

    // --- 森林 ---
    public class Music_ForestDay : SceneMusicLoaden {
        public override string FileName => "lifeglow";
        public override bool IsEnabled => Config.EnableArknightsForestDaytime;
        public override SceneEffectPriority Priority => SceneEffectPriority.BiomeLow;
        public override bool IsSceneEffectActive(Player p) => p.active && p.ZoneForest && Main.dayTime && p.ZoneOverworldHeight && !p.ZoneDesert && !p.ZoneBeach && !p.ZoneHallow;
    }

    public class Music_ForestNight : SceneMusicLoaden {
        public override string FileName => "asisaw";
        public override bool IsEnabled => Config.EnableArknightsForestNighttime;
        public override SceneEffectPriority Priority => SceneEffectPriority.BiomeLow;
        public override bool IsSceneEffectActive(Player p) => p.active && p.ZoneForest && !Main.dayTime && p.ZoneOverworldHeight && !p.ZoneDesert && !p.ZoneBeach && !p.ZoneHallow;
    }
}
