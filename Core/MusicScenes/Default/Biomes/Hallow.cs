using Terraria;
using Terraria.ModLoader;

namespace ArknightsModMusic.Core.MusicScenes.Default.Biomes
{
    public class Music_Hallow : MusicScene
    {
        public override string Path => MusicPath.Default.Biomes.Hallow;
        public override bool IsEnabled => config.EnableHallow;
        public override SceneEffectPriority Priority => SceneEffectPriority.BiomeLow;
        public override bool Condition(Player player)
        {
            return player.ZoneHallow && player.ZoneOverworldHeight;
        }
    }
    public class Music_UndergroundHallow : MusicScene
    {
        public override string Path => MusicPath.Default.Biomes.UndergroundHallow;
        public override bool IsEnabled => config.EnableUndergroundHallow;
        public override SceneEffectPriority Priority => SceneEffectPriority.BiomeLow;
        public override bool Condition(Player player)
        {
            return player.ZoneHallow && (player.ZoneDirtLayerHeight || player.ZoneRockLayerHeight);
        }
    }
}
