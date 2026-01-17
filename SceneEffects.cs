using Terraria;
using Terraria.ModLoader;
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
        // 细沙
        public override string FileName => "DesertDay";
        public override bool IsEnabled => Config.EnableDesertDay;
        public override bool IsSceneEffectActive(Player p) => p.ZoneDesert && Main.dayTime;
    }

    public class Music_DesertNight : SceneMusicLoaden {
        // From The Desert
        public override string FileName => "DesertNight";
        public override bool IsEnabled => Config.EnableDesertNight;
        public override bool IsSceneEffectActive(Player p) => p.ZoneDesert && !Main.dayTime;
    }

    public class Music_DesertUnderground : SceneMusicLoaden {
        // 烈阳与刀刃
        public override string FileName => "DesertUnderground";
        public override bool IsEnabled => Config.EnableDesertUnderground;
        public override bool IsSceneEffectActive(Player p) => p.ZoneUndergroundDesert;
    }

    // --- 丛林 ---
    public class Music_JungleDay : SceneMusicLoaden {
        // 绿洲
        public override string FileName => "JungleDay";
        public override bool IsEnabled => Config.EnableJungleDay;
        public override bool IsSceneEffectActive(Player p) => p.ZoneJungle && Main.dayTime;
    }

    public class Music_JungleNight : SceneMusicLoaden {
        // 逐猎
        public override string FileName => "JungleNight";
        public override bool IsEnabled => Config.EnableJungleNight;
        public override bool IsSceneEffectActive(Player p) => p.ZoneJungle && !Main.dayTime;
    }

    public class Music_JungleUnderground : SceneMusicLoaden {
        // 恐惧暗潮
        public override string FileName => "JungleUnderground";
        public override bool IsEnabled => Config.EnableJungleUnderground;
        public override bool IsSceneEffectActive(Player p) => p.ZoneJungle && p.ZoneDirtLayerHeight;
    }

    // --- 雪地 ---
    public class Music_SnowDay : SceneMusicLoaden {
        // 因非冰原
        public override string FileName => "SnowDay";
        public override bool IsEnabled => Config.EnableSnowDay;
        public override bool IsSceneEffectActive(Player p) => p.ZoneSnow && Main.dayTime;
    }

    public class Music_SnowNight : SceneMusicLoaden {
        // 远见终界
        public override string FileName => "SnowNight";
        public override bool IsEnabled => Config.EnableSnowNight;
        public override bool IsSceneEffectActive(Player p) => p.ZoneSnow && !Main.dayTime;
    }

    public class Music_SnowUnderground : SceneMusicLoaden {
        // 归还荒野
        public override string FileName => "SnowUnderground";
        public override bool IsEnabled => Config.EnableSnowUnderground;
        public override bool IsSceneEffectActive(Player p) => p.ZoneSnow && p.ZoneRockLayerHeight;
    }

    // --- 神圣 ---
    public class Music_HallowDay : SceneMusicLoaden {
        // 不存在的乐园
        public override string FileName => "HallowDay";
        public override bool IsEnabled => Config.EnableHallowDay;
        public override bool IsSceneEffectActive(Player p) => p.ZoneHallow && Main.dayTime;
    }

    public class Music_HallowNight : SceneMusicLoaden {
        // 圣城日常
        public override string FileName => "HallowNight";
        public override bool IsEnabled => Config.EnableHallowNight;
        public override bool IsSceneEffectActive(Player p) => p.ZoneHallow && !Main.dayTime;
    }

    public class Music_HallowUnderground : SceneMusicLoaden {
        // 无罪之人
        public override string FileName => "HallowUnderground";
        public override bool IsEnabled => Config.EnableHallowUnderground;
        public override bool IsSceneEffectActive(Player p) => p.ZoneHallow && p.ZoneRockLayerHeight;
    }

    // --- 腐化 ---
    public class Music_CorruptSurface : SceneMusicLoaden {
        // 荣光暗沉
        public override string FileName => "CorruptSurface";
        public override bool IsEnabled => Config.EnableCorruptSurface;
        public override bool IsSceneEffectActive(Player p) => p.ZoneCorrupt && p.ZoneOverworldHeight;
    }

    public class Music_CorruptUnderground : SceneMusicLoaden {
        // Wecgas fore tham Cynge, Searu fore tham Ethle
        public override string FileName => "CorruptUnderground";
        public override bool IsEnabled => Config.EnableCorruptUnderground;
        public override bool IsSceneEffectActive(Player p) => p.ZoneCorrupt && p.ZoneRockLayerHeight;
    }

    // --- 太空与地狱 ---
    public class Music_SpaceDay : SceneMusicLoaden {
        // Ad astra
        public override string FileName => "SpaceDay";
        public override bool IsEnabled => Config.EnableSpaceDay;
        public override SceneEffectPriority Priority => SceneEffectPriority.Environment;
        public override bool IsSceneEffectActive(Player p) => p.ZoneSkyHeight && Main.dayTime;
    }

    public class Music_SpaceNight : SceneMusicLoaden {
        // 群星见我
        public override string FileName => "SpaceNight";
        public override bool IsEnabled => Config.EnableSpaceNight;
        public override SceneEffectPriority Priority => SceneEffectPriority.Environment;
        public override bool IsSceneEffectActive(Player p) => p.ZoneSkyHeight && !Main.dayTime;
    }

    public class Music_Hell : SceneMusicLoaden {
        // Wavering Flame
        public override string FileName => "Hell";
        public override bool IsEnabled => Config.EnableHell;
        public override SceneEffectPriority Priority => SceneEffectPriority.Environment;
        public override bool IsSceneEffectActive(Player p) => p.ZoneUnderworldHeight;
    }

    // --- 特殊事件 ---
    public class Music_BloodMoon : SceneMusicLoaden {
        // 行文之韵
        public override string FileName => "BloodMoon";
        public override bool IsEnabled => Config.EnableBloodMoon;
        public override SceneEffectPriority Priority => SceneEffectPriority.Event;
        public override bool IsSceneEffectActive(Player p) => Main.bloodMoon;
    }

    public class Music_Meteor : SceneMusicLoaden {
        // 深层迷醉
        public override string FileName => "Meteor";
        public override bool IsEnabled => Config.EnableMeteor;
        public override bool IsSceneEffectActive(Player p) => p.ZoneMeteor;
    }

    public class Music_Graveyard : SceneMusicLoaden {
        // 熏陶
        public override string FileName => "Graveyard";
        public override bool IsEnabled => Config.EnableGraveyard;
        public override bool IsSceneEffectActive(Player p) => p.ZoneGraveyard;
    }
    // --- 腐化海洋 ---
    public class Music_CorruptedOceanDay : SceneMusicLoaden {
        // darktides
        public override string FileName => "CorruptedOceanDay";
        public override bool IsEnabled => Config.EnableArknightsCorruptedOceanDaytime;
        public override bool IsSceneEffectActive(Player p) => IsAtOceanEdge(p) && Main.dayTime && p.ZoneCorrupt && !p.ZoneCrimson && !p.ZoneHallow;
    }

    public class Music_CorruptedOceanNight : SceneMusicLoaden {
        // spread
        public override string FileName => "CorruptedOceanNight";
        public override bool IsEnabled => Config.EnableArknightsCorruptedOceanNighttime;
        public override bool IsSceneEffectActive(Player p) => IsAtOceanEdge(p) && !Main.dayTime && p.ZoneCorrupt && !p.ZoneCrimson && !p.ZoneHallow;
    }

    // --- 血腥海洋 ---
    public class Music_CrimsonOceanDay : SceneMusicLoaden {
        // resonance
        public override string FileName => "CrimsonOceanDay";
        public override bool IsEnabled => Config.EnableArknightsCrimsonOceanDaytime;
        public override bool IsSceneEffectActive(Player p) => IsAtOceanEdge(p) && Main.dayTime && !p.ZoneCorrupt && p.ZoneCrimson && !p.ZoneHallow;
    }

    public class Music_CrimsonOceanNight : SceneMusicLoaden {
        // eternalreef
        public override string FileName => "CrimsonOceanNight";
        public override bool IsEnabled => Config.EnableArknightsCrimsonOceanNighttime;
        public override bool IsSceneEffectActive(Player p) => IsAtOceanEdge(p) && !Main.dayTime && !p.ZoneCorrupt && p.ZoneCrimson && !p.ZoneHallow;
    }

    // --- 神圣海洋 ---
    public class Music_HallowedOceanDay : SceneMusicLoaden {
        // "pathoflife"
        public override string FileName => "HallowedOceanDay";
        public override bool IsEnabled => Config.EnableArknightsHallowedOceanDaytime;
        public override bool IsSceneEffectActive(Player p) => IsAtOceanEdge(p) && Main.dayTime && !p.ZoneCorrupt && !p.ZoneCrimson && p.ZoneHallow;
    }

    public class Music_HallowedOceanNight : SceneMusicLoaden {
        // "upsidedowntreeshadow"
        public override string FileName => "HallowedOceanNight";
        public override bool IsEnabled => Config.EnableArknightsHallowedOceanNighttime;
        public override bool IsSceneEffectActive(Player p) => IsAtOceanEdge(p) && !Main.dayTime && !p.ZoneCorrupt && !p.ZoneCrimson && p.ZoneHallow;
    }

    // --- 普通海洋 ---
    public class Music_OceanDay : SceneMusicLoaden {
        // "ready"
        public override string FileName => "OceanDay";
        public override bool IsEnabled => Config.EnableArknightsOceanDaytime;
        public override SceneEffectPriority Priority => SceneEffectPriority.BiomeLow;
        public override bool IsSceneEffectActive(Player p) => p.active && p.ZoneBeach && Main.dayTime && p.ZoneOverworldHeight && !p.ZoneCorrupt && !p.ZoneCrimson;
    }

    public class Music_OceanNight : SceneMusicLoaden {
        // "seawonder"
        public override string FileName => "OceanNight";
        public override bool IsEnabled => Config.EnableArknightsOceanNighttime;
        public override SceneEffectPriority Priority => SceneEffectPriority.BiomeLow;
        public override bool IsSceneEffectActive(Player p) => p.active && p.ZoneBeach && !Main.dayTime && p.ZoneOverworldHeight && !p.ZoneCorrupt && !p.ZoneCrimson;
    }

    // --- 森林 ---
    public class Music_ForestDay : SceneMusicLoaden {
        // "lifeglow"
        public override string FileName => "ForestDay";
        public override bool IsEnabled => Config.EnableArknightsForestDaytime;
        public override SceneEffectPriority Priority => SceneEffectPriority.BiomeLow;
        public override bool IsSceneEffectActive(Player p) => p.active && p.ZoneForest && Main.dayTime && p.ZoneOverworldHeight && !p.ZoneDesert && !p.ZoneBeach && !p.ZoneHallow;
    }

    public class Music_ForestNight : SceneMusicLoaden {
        // "asisaw"
        public override string FileName => "ForestNight";
        public override bool IsEnabled => Config.EnableArknightsForestNighttime;
        public override SceneEffectPriority Priority => SceneEffectPriority.BiomeLow;
        public override bool IsSceneEffectActive(Player p) => p.active && p.ZoneForest && !Main.dayTime && p.ZoneOverworldHeight && !p.ZoneDesert && !p.ZoneBeach && !p.ZoneHallow;
    }
}
