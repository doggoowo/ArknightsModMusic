using Terraria;
using Terraria.ModLoader;

namespace ArknightsModMusic.Core.MusicScenes.Default.Biomes
{
    public class Music_Underground : MusicScene
    {
        public override string Path => MusicPath.Default.Biomes.Underground;
        public override bool IsEnabled => config.EnableUnderground;
        public override SceneEffectPriority Priority => SceneEffectPriority.Environment;
        public override bool Condition(Player player)
        {
            return player.ZoneNormalCaverns || player.ZoneNormalUnderground;
        }
    }
}
