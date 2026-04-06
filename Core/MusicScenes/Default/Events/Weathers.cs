using Terraria;
using Terraria.ID;

namespace ArknightsModMusic.Core.MusicScenes.Default.Events
{
    public class Music_Rain : MusicScene
    {
        public override string Path => MusicPath.Default.Events.Rain;
        public override bool IsEnabled => config.EnableRain;
        public override int? ReplaceMusicId => MusicID.Rain;
        public override bool ReplaceCondition(Player player) => true;
    }

    public class Music_MorningRain : MusicScene
    {
        public override string Path => MusicPath.Default.Events.MorningRain;
        public override bool IsEnabled => config.EnableMorningRain;
        public override int? ReplaceMusicId => MusicID.MorningRain;
        public override bool ReplaceCondition(Player player) => true;
    }

    public class Music_Sandstorm : MusicScene
    {
        public override string Path => MusicPath.Default.Events.Sandstorm;
        public override bool IsEnabled => config.EnableSandstorm;
        public override int? ReplaceMusicId => MusicID.Sandstorm;
        public override bool ReplaceCondition(Player player) => true;
    }

    public class Music_Storm : MusicScene
    {
        public override string Path => MusicPath.Default.Events.Storm;
        public override bool IsEnabled => config.EnableStorm;
        public override int? ReplaceMusicId => MusicID.Monsoon;
        public override bool ReplaceCondition(Player player) => true;
    }

    public class Music_HighWind : MusicScene
    {
        public override string Path => MusicPath.Default.Events.HighWind;
        public override bool IsEnabled => config.EnableHighWind;
        public override int? ReplaceMusicId => MusicID.WindyDay;
        public override bool ReplaceCondition(Player player) => true;
    }
}