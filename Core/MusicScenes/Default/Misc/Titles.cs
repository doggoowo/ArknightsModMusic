using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ArknightsModMusic.Core.MusicScenes.Default.Misc
{
    public class Music_Title_Start : MusicScene
    {
        public override string Path => MusicPath.Default.Misc.Title;
        public override bool IsEnabled => config.EnableTitle;
        public override int? ReplaceMusicId => 50;
        public override bool ReplaceCondition(Player player) 
        {
            return true;
        }
    }
    public class Music_Title : MusicScene
    {
        public override string Path => MusicPath.Default.Misc.Title;
        public override bool IsEnabled => config.EnableTitle;
        public override int? ReplaceMusicId => 51;
        public override bool ReplaceCondition(Player player)
        {
            return true;
        }
    }
    public class Music_TitleLegacy : MusicScene
    {
        public override string Path => MusicPath.Default.Misc.TitleLegacy;
        public override bool IsEnabled => config.EnableTitleLegacy;
        public override int? ReplaceMusicId => MusicID.TitleClassic;
        public override bool ReplaceCondition(Player player)
        {
            return true;
        }
    }
    public class Music_DrunkWorldGen : MusicScene // 实际为Console
    {
        public override string Path => MusicPath.Default.Misc.DrunkWorldGen;
        public override bool IsEnabled => config.EnableDrunkWorldGen;
        public override int? ReplaceMusicId => MusicID.TitleAlt;
        public override bool ReplaceCondition(Player player)
        {
            return true;
        }
    }
}
