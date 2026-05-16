using Terraria;
using Terraria.ID;

namespace ArknightsModMusic.Core.MusicScenes.Default.Events
{
    public class LunarEvent : MusicScene
    {
        public override string Path => MusicPath.Default.Events.LunarEvent;
        public override bool IsEnabled => config.EnableLunarEvent;
        public override int? ReplaceMusicId => MusicID.MoonLord;
        public override bool ReplaceCondition(Player player) => true;
    }
}