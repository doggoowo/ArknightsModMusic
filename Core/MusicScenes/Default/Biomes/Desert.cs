using Terraria;
using Terraria.ModLoader;

namespace ArknightsModMusic.Core.MusicScenes.Default.Biomes
{
    public class Music_Desert : MusicScene
    {
        public override string Path => MusicPath.Default.Biomes.Desert;
        public override bool IsEnabled => config.EnableDesert;
        public override SceneEffectPriority Priority => SceneEffectPriority.BiomeLow;
        public override bool Condition(Player player)
        {
            return player.ZoneDesert && player.ZoneOverworldHeight;
        }
    }
    public class Music_UndergroundDesert : MusicScene
    {
        public override string Path => MusicPath.Default.Biomes.UndergroundDesert;
        public override bool IsEnabled => config.EnableUndergroundDesert;
        public override SceneEffectPriority Priority => SceneEffectPriority.BiomeLow;
        public override bool Condition(Player player)
        {
            return player.ZoneUndergroundDesert;
        }
    }
}
