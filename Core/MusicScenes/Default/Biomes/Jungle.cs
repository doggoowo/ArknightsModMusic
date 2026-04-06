using Terraria;
using Terraria.ModLoader;

namespace ArknightsModMusic.Core.MusicScenes.Default.Biomes
{
    public class Music_JungleDay : MusicScene
    {
        public override string Path => MusicPath.Default.Biomes.JungleDay;
        public override bool IsEnabled => config.EnableJungleDay;
        public override SceneEffectPriority Priority => SceneEffectPriority.BiomeMedium;
        public override bool Condition(Player player)
        {
            return player.ZoneJungle && Main.dayTime;
        }
    }

    public class Music_JungleNight : MusicScene
    {
        public override string Path => MusicPath.Default.Biomes.JungleNight;
        public override bool IsEnabled => config.EnableJungleNight;
        public override SceneEffectPriority Priority => SceneEffectPriority.BiomeMedium;
        public override bool Condition(Player player)
        {
            return player.ZoneJungle && !Main.dayTime;
        }
    }
    public class Music_UndergroundJungle : MusicScene
    {
        public override string Path => MusicPath.Default.Biomes.UndergroundJungle;
        public override bool IsEnabled => config.EnableUndergroundJungle;
        public override SceneEffectPriority Priority => SceneEffectPriority.BiomeMedium;
        public override bool Condition(Player player)
        {
            return player.ZoneJungle && (player.ZoneDirtLayerHeight || player.ZoneRockLayerHeight);
        }
    }
}
