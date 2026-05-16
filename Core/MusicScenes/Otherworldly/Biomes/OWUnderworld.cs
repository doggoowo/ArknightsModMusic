using Terraria;
using Terraria.ID;

namespace ArknightsModMusic.Core.MusicScenes.Otherworldly.Biomes
{
    public class Music_OWUnderworld : MusicScene
    {
        public override string Path => MusicPath.Otherworldly.Biomes.Underworld;
        public override bool IsOtherworldly => true;
        public override bool IsEnabled => owConfig.EnableOWUnderworld;
        public override int? ReplaceMusicId => MusicID.OtherworldUnderworld;
        public override bool ReplaceCondition(Player player) => true;
    }
}