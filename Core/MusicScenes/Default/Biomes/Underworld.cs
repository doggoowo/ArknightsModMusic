using Terraria;
using Terraria.ModLoader;

namespace ArknightsModMusic.Core.MusicScenes.Default.Biomes
{
    public class Music_Underworld : MusicScene
    {
        public override string Path => MusicPath.Default.Biomes.Underworld;
        public override bool IsEnabled => config.EnableUnderworld;
        public override SceneEffectPriority Priority => SceneEffectPriority.Environment;
        public override bool Condition(Player player)
        {
            return player.ZoneUnderworldHeight;
        }
    }
}
