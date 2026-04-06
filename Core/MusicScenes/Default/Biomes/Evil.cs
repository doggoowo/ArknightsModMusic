using Terraria;
using Terraria.ModLoader;

namespace ArknightsModMusic.Core.MusicScenes.Default.Biomes
{
    // ========== 腐化（地表） ==========
    public class Music_Corruption : MusicScene
    {
        public override string Path => MusicPath.Default.Biomes.Corruption;
        public override bool IsEnabled => config.EnableCorruption;
        public override SceneEffectPriority Priority => SceneEffectPriority.BiomeHigh;
        public override bool Condition(Player player)
        {
            return player.ZoneCorrupt && player.ZoneOverworldHeight;
        }
    }

    // ========== 猩红（地表） ==========
    public class Music_Crimson : MusicScene
    {
        public override string Path => MusicPath.Default.Biomes.Crimson;
        public override bool IsEnabled => config.EnableCrimson;
        public override SceneEffectPriority Priority => SceneEffectPriority.BiomeHigh;
        public override bool Condition(Player player)
        {
            return player.ZoneCrimson && player.ZoneOverworldHeight;
        }
    }

    // ========== 地下腐化 ==========
    public class Music_UndergroundCorruption : MusicScene
    {
        public override string Path => MusicPath.Default.Biomes.UndergroundCorruption;
        public override bool IsEnabled => config.EnableUndergroundCorruption;
        public override SceneEffectPriority Priority => SceneEffectPriority.BiomeHigh;
        public override bool Condition(Player player)
        {
            return player.ZoneCorrupt && (player.ZoneDirtLayerHeight || player.ZoneRockLayerHeight);
        }
    }

    // ========== 地下猩红 ==========
    public class Music_UndergroundCrimson : MusicScene
    {
        public override string Path => MusicPath.Default.Biomes.UndergroundCrimson;
        public override bool IsEnabled => config.EnableUndergroundCrimson;
        public override SceneEffectPriority Priority => SceneEffectPriority.BiomeHigh;
        public override bool Condition(Player player)
        {
            return player.ZoneCrimson && (player.ZoneDirtLayerHeight || player.ZoneRockLayerHeight);
        }
    }
}
