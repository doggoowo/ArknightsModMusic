using Terraria;
using Terraria.ID;

namespace ArknightsModMusic.Core.MusicScenes.Otherworldly.Biomes
{
    public class Music_OWSpace : MusicScene
    {
        public override string Path => MusicPath.Otherworldly.Biomes.Space;
        public override bool IsOtherworldly => true;
        public override bool IsEnabled => owConfig.EnableOWSpace;
        public override int? ReplaceMusicId => MusicID.OtherworldlySpace;
        public override bool ReplaceCondition(Player player) => true;
    }
}