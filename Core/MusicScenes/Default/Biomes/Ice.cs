using Terraria;
using Terraria.ModLoader;

namespace ArknightsModMusic.Core.MusicScenes.Default.Biomes
{
    public class Music_Ice : MusicScene
    {
        public override string Path => MusicPath.Default.Biomes.Ice;
        public override bool IsEnabled => config.EnableIce;
        public override SceneEffectPriority Priority => SceneEffectPriority.BiomeMedium;
        public override bool Condition(Player player)
        {
            return player.ZoneSnow && player.ZoneOverworldHeight;
        }
    }
    public class Music_UndergroundIce : MusicScene
    {
        public override string Path => MusicPath.Default.Biomes.UndergroundIce;
        public override bool IsEnabled => config.EnableUndergroundIce;
        public override SceneEffectPriority Priority => SceneEffectPriority.BiomeMedium;
        public override bool Condition(Player player)
        {
            return player.ZoneSnow && (player.ZoneDirtLayerHeight || player.ZoneRockLayerHeight);
        }
    }
}
