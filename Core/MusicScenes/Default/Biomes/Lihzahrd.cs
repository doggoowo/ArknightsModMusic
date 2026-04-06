using Terraria;
using Terraria.ModLoader;

namespace ArknightsModMusic.Core.MusicScenes.Default.Biomes
{
    public class Music_Lihzahrd : MusicScene
    {
        public override string Path => MusicPath.Default.Biomes.Lihzahrd;
        public override bool IsEnabled => config.EnableLihzahrd;
        public override SceneEffectPriority Priority => SceneEffectPriority.BiomeHigh;
        public override bool Condition(Player player)
        {
            return player.ZoneLihzhardTemple;
        }
    }
}
