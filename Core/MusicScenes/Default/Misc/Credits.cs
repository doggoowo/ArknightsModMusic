using Terraria;
using Terraria.ID;

namespace ArknightsModMusic.Core.MusicScenes.Default.Misc
{
    public class Music_Credits : MusicScene
    {
        public override string Path => MusicPath.Default.Misc.Credits;
        public override bool IsEnabled => config.EnableCredits;
        public override int? ReplaceMusicId => MusicID.JourneysEnd;
        public override bool ReplaceCondition(Player player)
        {
            return !IsUsingOtherworldlyMusic;
        }
    }
}
