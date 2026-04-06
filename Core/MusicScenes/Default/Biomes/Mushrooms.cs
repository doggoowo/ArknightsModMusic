using Terraria;
using Terraria.ModLoader;

namespace ArknightsModMusic.Core.MusicScenes.Default.Biomes
{
    public class Music_Mushrooms : MusicScene
    {
        public override string Path => MusicPath.Default.Biomes.Mushrooms;
        public override bool IsEnabled => config.EnableMushrooms;
        public override SceneEffectPriority Priority => SceneEffectPriority.BiomeHigh;
        public override bool Condition(Player player)
        {
            return player.ZoneGlowshroom;
        }
    }
}
