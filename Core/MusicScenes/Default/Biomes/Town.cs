using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ArknightsModMusic.Core.MusicScenes.Default.Biomes
{
    public class Music_TownDay : MusicScene
    {
        public override string Path => MusicPath.Default.Biomes.TownDay;
        public override bool IsEnabled => config.EnableTownDay;
        public override int? ReplaceMusicId => MusicID.TownDay;
        public override bool ReplaceCondition(Player player) => true;
    }

    public class Music_TownNight : MusicScene
    {
        public override string Path => MusicPath.Default.Biomes.TownNight;
        public override bool IsEnabled => config.EnableTownNight;
        public override int? ReplaceMusicId => MusicID.TownNight;
        public override bool ReplaceCondition(Player player) => true;
    }
}
