using Terraria;
using Terraria.ID;

namespace ArknightsModMusic.Core.MusicScenes.Otherworldly.Biomes
{
    public class Music_OWDungeon : MusicScene
    {
        public override string Path => MusicPath.Otherworldly.Biomes.Dungeon;
        public override bool IsOtherworldly => true;
        public override bool IsEnabled => owConfig.EnableOWDungeon;
        public override int? ReplaceMusicId => MusicID.OtherworldDungeon;
        public override bool ReplaceCondition(Player player) => true;
    }
}