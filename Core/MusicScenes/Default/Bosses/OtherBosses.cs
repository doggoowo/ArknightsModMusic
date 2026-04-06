using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ArknightsModMusic.Core.MusicScenes.Default.Bosses
{
    public class Music_QueenBee : MusicScene
    {
        public override string Path => MusicPath.Default.Bosses.QueenBee;
        public override bool IsEnabled => config.EnableQueenBee;
        public override SceneEffectPriority Priority => SceneEffectPriority.BossLow;
        public override bool Condition(Player player)
        {
            return IsNpcAlive(NPCID.QueenBee);
        }
    }

    public class Music_Deerclops : MusicScene
    {
        public override string Path => MusicPath.Default.Bosses.Deerclops;
        public override bool IsEnabled => config.EnableDeerclops;
        public override SceneEffectPriority Priority => SceneEffectPriority.BossLow;
        public override bool Condition(Player player)
        {
            return IsNpcAlive(NPCID.Deerclops);
        }
    }

    public class Music_QueenSlime : MusicScene
    {
        public override string Path => MusicPath.Default.Bosses.QueenSlime;
        public override bool IsEnabled => config.EnableQueenSlime;
        public override SceneEffectPriority Priority => SceneEffectPriority.BossLow;
        public override bool Condition(Player player)
        {
            return IsNpcAlive(NPCID.QueenSlimeBoss);
        }
    }

    public class Music_Plantera : MusicScene
    {
        public override string Path => MusicPath.Default.Bosses.Plantera;
        public override bool IsEnabled => config.EnablePlantera;
        public override SceneEffectPriority Priority => SceneEffectPriority.BossMedium;
        public override bool Condition(Player player)
        {
            return IsNpcAlive(NPCID.Plantera);
        }
    }
    public class Music_EmpressOfLight : MusicScene
    {
        public override string Path => MusicPath.Default.Bosses.EmpressOfLight;
        public override bool IsEnabled => config.EnableEmpressOfLight;
        public override SceneEffectPriority Priority => SceneEffectPriority.BossLow;
        public override bool Condition(Player player)
        {
            return IsNpcAlive(NPCID.HallowBoss);
        }
    }

    public class Music_Golem : MusicScene
    {
        public override string Path => MusicPath.Default.Bosses.Golem;
        public override bool IsEnabled => config.EnableGolem;
        public override SceneEffectPriority Priority => SceneEffectPriority.BossLow;
        public override bool Condition(Player player)
        {
            return IsNpcAlive(NPCID.Golem);
        }
    }

    public class Music_DukeFishron : MusicScene
    {
        public override string Path => MusicPath.Default.Bosses.DukeFishron;
        public override bool IsEnabled => config.EnableDukeFishron;
        public override SceneEffectPriority Priority => SceneEffectPriority.BossLow;
        public override bool Condition(Player player)
        {
            return IsNpcAlive(NPCID.DukeFishron);
        }
    }

    public class Music_MoonLord : MusicScene
    {
        public override string Path => MusicPath.Default.Bosses.MoonLord;
        public override bool IsEnabled => config.EnableMoonLord;
        public override SceneEffectPriority Priority => SceneEffectPriority.BossHigh;
        public override bool Condition(Player player)
        {
            return IsNpcAlive(NPCID.MoonLordCore);
        }
    }
}