using ArknightsModMusic.Configs;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace ArknightsModMusic.Core.MusicScenes
{
    public abstract class MusicScene
    {
        /// <summary>音乐路径，请使用 <see cref="MusicPath"/> 避免手写路径</summary>
        public abstract string Path { get; }

        /// <summary>用于绑定config，是否启用</summary>
        public abstract bool IsEnabled { get; }

        /// <summary>优先级。同优先级下高于原版但低于其他mod，默认 <see cref="SceneEffectPriority.None"/> 
        /// </summary>
        public virtual SceneEffectPriority Priority { get; } = SceneEffectPriority.None;

        /// <summary>是否是异界曲目（仅在非替换场景下生效），默认false</summary>
        public virtual bool IsOtherworldly { get; } = false;

        /// <summary>在什么样的条件下触发播放<br/>，默认false</summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public virtual bool Condition(Player player) => false;

        /// <summary>直接暴力替代某音乐ID，在原版选曲方法后执行。这意味着可能会不通过优先度覆盖一些曲目<br/>
        /// 注：重写此属性必须同步重写 <see cref="ReplaceCondition(Player)"/></summary>
        public virtual int? ReplaceMusicId { get; }

        /// <summary>在什么样的条件下替换该音乐，需搭配 <see cref="ReplaceMusicId"/> 设置，默认false</summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public virtual bool ReplaceCondition(Player player) => false;

        /// <summary>当前场景包含的音乐ID（只有在模组加载完后才生效）</summary>
        public List<int> TrackIds { get; set; } = new();

        /// <summary>模组config</summary>
        protected DefaultDetailedConfig config => ModContent.GetInstance<DefaultDetailedConfig>();

        /// <summary>异界模组config</summary>
        protected OtherworldlyDetailedConfig owConfig => ModContent.GetInstance<OtherworldlyDetailedConfig>();

        /// <summary>统一的NPC存活检查方法</summary>
        /// <param name="npcType">NPCID</param>
        /// <param name="requireBoss">是否要求boss</param>
        protected static bool IsNpcAlive(int npcType, bool requireBoss = false)
        {
            for (int i = 0; i < Main.npc.Length; i++)
            {
                if (Main.npc[i].active && Main.npc[i].type == npcType && (!requireBoss || Main.npc[i].boss))
                    return true;
            }
            return false;
        }

        /// <summary>检查一组NPC类型中是否有任意一个存活</summary>
        /// <param name="npcTypes">NPCID集合</param>
        /// <param name="requireBoss">是否要求boss</param>
        protected static bool IsNpcAlive(IEnumerable<int> npcTypes, bool requireBoss = false)
        {
            foreach (int npcType in npcTypes)
            {
                if (IsNpcAlive(npcType, requireBoss))
                    return true;
            }
            return false;
        }

        /// <summary>原版是否正在使用异界音乐</summary>
        protected bool IsUsingOtherworldlyMusic => (Main.swapMusic && (!Main.drunkWorld || Main.remixWorld))
                  || (!Main.swapMusic && !Main.gameMenu && Main.drunkWorld && !Main.remixWorld);
    }
}
