using Terraria;
using Terraria.ID;

namespace ArknightsModMusic.Core.MusicScenes.Otherworldly.Biomes
{
    public class Music_OWMushrooms : MusicScene
    {
        public override string Path => MusicPath.Otherworldly.Biomes.Mushrooms;
        public override bool IsOtherworldly => true;
        public override bool IsEnabled => owConfig.EnableOWMushrooms;
        public override int? ReplaceMusicId => MusicID.OtherworldMushroom;
        public override bool ReplaceCondition(Player player) => true;
    }
}