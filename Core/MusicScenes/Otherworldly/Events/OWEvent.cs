using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ArknightsModMusic.Core.MusicScenes.Otherworldly.Events
{
    public class Music_OWEerie : MusicScene
    {
        public override string Path => MusicPath.Otherworldly.Events.Eerie;
        public override bool IsOtherworldly => true;
        public override bool IsEnabled => owConfig.EnableOWEerie;
        public override int? ReplaceMusicId => MusicID.OtherworldEerie;
        public override bool ReplaceCondition(Player player) => true;
    }

    public class Music_OWInvasion : MusicScene
    {
        public override string Path => MusicPath.Otherworldly.Events.Invasion;
        public override bool IsOtherworldly => true;
        public override bool IsEnabled => owConfig.EnableOWInvasion;
        public override int? ReplaceMusicId => MusicID.OtherworldInvasion;
        public override bool ReplaceCondition(Player player) => true;
    }

    public class Music_OWLunarEvent : MusicScene
    {
        public override string Path => MusicPath.Otherworldly.Events.LunarEvent;
        public override bool IsOtherworldly => true;
        public override bool IsEnabled => owConfig.EnableOWLunarEvent;
        public override int? ReplaceMusicId => MusicID.OtherworldLunarPillars;
        public override bool ReplaceCondition(Player player) => true;
    }

    public class Music_OWRain : MusicScene
    {
        public override string Path => MusicPath.Otherworldly.Events.Rain;
        public override bool IsOtherworldly => true;
        public override bool IsEnabled => owConfig.EnableOWRain;
        public override int? ReplaceMusicId => MusicID.OtherworldRain;
        public override bool ReplaceCondition(Player player) => true;
    }
}