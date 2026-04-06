using ArknightsModMusic.Core.MusicScenes;
using Terraria;
using Terraria.ID;

namespace ArknightsModMusic.Core.MusicScenes.Default.Events
{
    public class Music_Eclipse : MusicScene
    {
        public override string Path => MusicPath.Default.Events.Eclipse;
        public override bool IsEnabled => config.EnableEclipse;
        public override int? ReplaceMusicId => MusicID.Eclipse;
        public override bool ReplaceCondition(Player player) => true;
    }

    public class Music_FrostMoon : MusicScene
    {
        public override string Path => MusicPath.Default.Events.FrostMoon;
        public override bool IsEnabled => config.EnableFrostMoon;
        public override int? ReplaceMusicId => MusicID.FrostMoon;
        public override bool ReplaceCondition(Player player) => true;
    }

    public class Music_GoblinArmy : MusicScene
    {
        public override string Path => MusicPath.Default.Events.GoblinArmy;
        public override bool IsEnabled => config.EnableGoblinArmy;
        public override int? ReplaceMusicId => MusicID.GoblinInvasion;
        public override bool ReplaceCondition(Player player) => true;
    }

    public class Music_MartianMadness : MusicScene
    {
        public override string Path => MusicPath.Default.Events.MartianMadness;
        public override bool IsEnabled => config.EnableMartianMadness;
        public override int? ReplaceMusicId => MusicID.MartianMadness;
        public override bool ReplaceCondition(Player player) => true;
    }

    public class Music_OldOnesArmy : MusicScene
    {
        public override string Path => MusicPath.Default.Events.OldOnesArmy;
        public override bool IsEnabled => config.EnableOldOnesArmy;
        public override int? ReplaceMusicId => MusicID.OldOnesArmy;
        public override bool ReplaceCondition(Player player) => true;
    }

    public class Music_PirateInvasion : MusicScene
    {
        public override string Path => MusicPath.Default.Events.PirateInvasion;
        public override bool IsEnabled => config.EnablePirateInvasion;
        public override int? ReplaceMusicId => MusicID.PirateInvasion;
        public override bool ReplaceCondition(Player player) => true;
    }

    public class Music_PumpkinMoon : MusicScene
    {
        public override string Path => MusicPath.Default.Events.PumpkinMoon;
        public override bool IsEnabled => config.EnablePumpkinMoon;
        public override int? ReplaceMusicId => MusicID.PumpkinMoon;
        public override bool ReplaceCondition(Player player) => true;
    }

    public class Music_SlimeRain : MusicScene
    {
        public override string Path => MusicPath.Default.Events.SlimeRain;
        public override bool IsEnabled => config.EnableSlimeRain;
        public override int? ReplaceMusicId => MusicID.SlimeRain;
        public override bool ReplaceCondition(Player player) => true;
    }
}