using Terraria;
using Terraria.ModLoader;

namespace ArknightsModMusic.Core.MusicScenes.Default.Biomes
{
    public class Music_Aether : MusicScene
    {
        public override string Path => MusicPath.Default.Biomes.Aether;
        public override bool IsEnabled => config.EnableAether;
        public override SceneEffectPriority Priority => SceneEffectPriority.Environment;
        public override bool Condition(Player player)
        {
            return player.ZoneShimmer;
        }
    }
}
