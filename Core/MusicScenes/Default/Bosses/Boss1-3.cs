using Terraria;
using Terraria.ID;

namespace ArknightsModMusic.Core.MusicScenes.Default.Bosses
{
    public class Music_Boss1 : MusicScene
    {
        public override string Path => MusicPath.Default.Bosses.Boss1;
        public override bool IsEnabled => config.EnableBoss1;
        public override int? ReplaceMusicId => MusicID.Boss1;
        public override bool ReplaceCondition(Player player) => true;
    }
    public class Music_Boss2 : MusicScene
    {
        public override string Path => MusicPath.Default.Bosses.Boss2;
        public override bool IsEnabled => config.EnableBoss2;
        public override int? ReplaceMusicId => MusicID.Boss2;
        public override bool ReplaceCondition(Player player) => true;
    }
    public class Music_Boss3 : MusicScene
    {
        public override string Path => MusicPath.Default.Bosses.Boss3;
        public override bool IsEnabled => config.EnableBoss3;
        public override int? ReplaceMusicId => MusicID.Boss3;
        public override bool ReplaceCondition(Player player) => true;
    }
}
