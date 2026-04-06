using ArknightsModMusic.Core.MusicScenes;
using Terraria;
using Terraria.ID;

namespace ArknightsModMusic.Core.MusicScenes.Default.Events
{
    public class Music_Eerie : MusicScene // 陨石，血月
    {
        public override string Path => MusicPath.Default.Events.Eerie;
        public override bool IsEnabled => config.EnableEerie;
        public override int? ReplaceMusicId => MusicID.Eerie;
        public override bool ReplaceCondition(Player player) => true;
    }
}