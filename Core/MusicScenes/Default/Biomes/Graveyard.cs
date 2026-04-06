using Terraria;
using Terraria.ModLoader;

namespace ArknightsModMusic.Core.MusicScenes.Default.Biomes
{
    public class Music_Graveyard : MusicScene
    {
        public override string Path => MusicPath.Default.Biomes.Graveyard;
        public override bool IsEnabled => config.EnableGraveyard;
        public override SceneEffectPriority Priority => SceneEffectPriority.BiomeMedium;
        public override bool Condition(Player player)
        {
            return player.ZoneGraveyard;
        }
    }
}
