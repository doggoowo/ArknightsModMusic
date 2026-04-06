using Terraria;
using Terraria.ModLoader;

namespace ArknightsModMusic.Core.MusicScenes.Default.Biomes
{
    public class Music_Dungeon : MusicScene
    {
        public override string Path => MusicPath.Default.Biomes.Dungeon;
        public override bool IsEnabled => config.EnableDungeon;
        public override SceneEffectPriority Priority => SceneEffectPriority.BiomeHigh;
        public override bool Condition(Player player)
        {
            return player.ZoneDungeon;
        }
    }
}
