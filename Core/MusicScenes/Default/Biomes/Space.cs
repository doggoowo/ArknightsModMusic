using Terraria;
using Terraria.ModLoader;

namespace ArknightsModMusic.Core.MusicScenes.Default.Biomes
{
    public class Music_SpaceDay : MusicScene
    {
        public override string Path => MusicPath.Default.Biomes.SpaceDay;
        public override bool IsEnabled => config.EnableSpaceDay;
        public override SceneEffectPriority Priority => SceneEffectPriority.Environment;
        public override bool Condition(Player player)
        {
            return player.ZoneSkyHeight && Main.dayTime;
        }
    }

    public class Music_SpaceNight : MusicScene
    {
        public override string Path => MusicPath.Default.Biomes.SpaceNight;
        public override bool IsEnabled => config.EnableSpaceNight;
        public override SceneEffectPriority Priority => SceneEffectPriority.Environment;
        public override bool Condition(Player player)
        {
            return player.ZoneSkyHeight && !Main.dayTime;
        }
    }
}
