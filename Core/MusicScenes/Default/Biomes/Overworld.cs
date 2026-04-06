using Terraria;
using Terraria.ModLoader;

namespace ArknightsModMusic.Core.MusicScenes.Default.Biomes
{
    public class Music_OverworldDay : MusicScene
    {
        public override string Path => MusicPath.Default.Biomes.OverworldDay;
        public override SceneEffectPriority Priority => SceneEffectPriority.BiomeLow;
        public override bool IsEnabled => config.EnableOverworldDay;
        public override bool Condition(Player p)
        {
            return p.active && p.ZoneForest && Main.dayTime &&
                p.ZoneOverworldHeight && !p.ZoneDesert &&
                !p.ZoneBeach && !p.ZoneHallow;
        }
    }
    public class Music_OverworldNight : MusicScene
    {
        public override string Path => MusicPath.Default.Biomes.OverworldNight;
        public override SceneEffectPriority Priority => SceneEffectPriority.BiomeLow;
        public override bool IsEnabled => config.EnableOverworldNight;
        public override bool Condition(Player p)
        {
            return p.active && p.ZoneForest && !Main.dayTime &&
                p.ZoneOverworldHeight && !p.ZoneDesert &&
                !p.ZoneBeach && !p.ZoneHallow;
        }
    }
}
