using Terraria;
using Terraria.ID;

namespace ArknightsModMusic.Core.MusicScenes.Otherworldly.Misc
{
    public class Music_OWCredits : MusicScene
    {
        public override string Path => MusicPath.Otherworldly.Misc.Credits;
        public override bool IsOtherworldly => true;
        public override bool IsEnabled => owConfig.EnableOWCredits;
        public override int? ReplaceMusicId => MusicID.JourneysEnd;
        public override bool ReplaceCondition(Player player) 
        {
            return IsUsingOtherworldlyMusic;
        }
    }
}
