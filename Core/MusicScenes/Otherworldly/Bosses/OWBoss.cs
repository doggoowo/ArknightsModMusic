using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ArknightsModMusic.Core.MusicScenes.Otherworldly.Bosses
{
    public class Music_OWBoss1 : MusicScene
    {
        public override string Path => MusicPath.Otherworldly.Bosses.Boss1;
        public override bool IsOtherworldly => true;
        public override bool IsEnabled => owConfig.EnableOWBoss1;
        public override int? ReplaceMusicId => MusicID.OtherworldlyBoss1;
        public override bool ReplaceCondition(Player player) => true;
    }

    public class Music_OWBoss2 : MusicScene
    {
        public override string Path => MusicPath.Otherworldly.Bosses.Boss2;
        public override bool IsOtherworldly => true;
        public override bool IsEnabled => owConfig.EnableOWBoss2;
        public override int? ReplaceMusicId => MusicID.OtherworldlyBoss2;
        public override bool ReplaceCondition(Player player) => true;
    }
    public class Music_OWBossWoF : MusicScene
    {
        public override string Path => MusicPath.Otherworldly.Bosses.Boss2;
        public override bool IsOtherworldly => true;
        public override bool IsEnabled => owConfig.EnableOWBoss2;
        public override int? ReplaceMusicId => MusicID.OtherworldlyWoF;
        public override bool ReplaceCondition(Player player) => true;
    }

    public class Music_OWBoss3 : MusicScene
    {
        public override string Path => MusicPath.Otherworldly.Bosses.Boss3;
        public override bool IsOtherworldly => true;
        public override bool IsEnabled => owConfig.EnableOWBoss3;
        public override SceneEffectPriority Priority => SceneEffectPriority.BossMedium;
        public override bool Condition(Player player)
        {
            return IsNpcAlive([NPCID.SkeletronPrime, NPCID.Spazmatism, NPCID.Retinazer, NPCID.TheDestroyer]);
        }
    }

    public class Music_OWMoonLord : MusicScene
    {
        public override string Path => MusicPath.Otherworldly.Bosses.MoonLord;
        public override bool IsOtherworldly => true;
        public override bool IsEnabled => owConfig.EnableOWMoonLord;
        public override int? ReplaceMusicId => MusicID.OtherworldlyLunarBoss;
        public override bool ReplaceCondition(Player player) => true;
    }

    public class Music_OWPlantera : MusicScene
    {
        public override string Path => MusicPath.Otherworldly.Bosses.Plantera;
        public override bool IsOtherworldly => true;
        public override bool IsEnabled => owConfig.EnableOWPlantera;
        public override int? ReplaceMusicId => MusicID.OtherworldlyPlantera;
        public override bool ReplaceCondition(Player player) => true;
    }
}