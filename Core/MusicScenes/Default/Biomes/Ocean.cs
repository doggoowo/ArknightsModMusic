using Terraria;
using Terraria.ModLoader;

namespace ArknightsModMusic.Core.MusicScenes.Default.Biomes
{
    public class Music_OceanDay : MusicScene
    {
        public override string Path => MusicPath.Default.Biomes.OceanDay;
        public override bool IsEnabled => config.EnableOceanDay;
        public override SceneEffectPriority Priority => SceneEffectPriority.BiomeLow;
        public override bool Condition(Player player)
        {
            return player.active && player.ZoneBeach && Main.dayTime && player.ZoneOverworldHeight
                && !player.ZoneCorrupt && !player.ZoneCrimson && !player.ZoneHallow;
        }
    }

    public class Music_OceanNight : MusicScene
    {
        public override string Path => MusicPath.Default.Biomes.OceanNight;
        public override bool IsEnabled => config.EnableOceanNight;
        public override SceneEffectPriority Priority => SceneEffectPriority.BiomeLow;
        public override bool Condition(Player player)
        {
            return player.active && player.ZoneBeach && !Main.dayTime && player.ZoneOverworldHeight
                && !player.ZoneCorrupt && !player.ZoneCrimson && !player.ZoneHallow;
        }
    }
}
