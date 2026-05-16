using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ArknightsModMusic.Core.MusicScenes.Otherworldly.Biomes
{
    public class Music_OWUnderground : MusicScene
    {
        public override string Path => MusicPath.Otherworldly.Biomes.Underground;
        public override bool IsOtherworldly => true;
        public override bool IsEnabled => owConfig.EnableOWUnderground;
        public override int? ReplaceMusicId => MusicID.OtherworldUnderground;
        public override bool ReplaceCondition(Player player) => true;
    }

    public class Music_OWUndergroundCorruption : MusicScene
    {
        public override string Path => MusicPath.Otherworldly.Biomes.UndergroundCorruption;
        public override bool IsOtherworldly => true;
        public override bool IsEnabled => owConfig.EnableOWUndergroundCorruption;
        public override int? ReplaceMusicId => MusicID.OtherworldUndergroundCorruption;
        public override bool ReplaceCondition(Player player) => true;
    }

    public class Music_OWUndergroundCrimson : MusicScene
    {
        public override string Path => MusicPath.Otherworldly.Biomes.UndergroundCrimson;
        public override bool IsOtherworldly => true;
        public override bool IsEnabled => owConfig.EnableOWUndergroundCrimson;
        public override int? ReplaceMusicId => MusicID.OtherworldUndergroundCrimson;
        public override bool ReplaceCondition(Player player) => true;
    }

    public class Music_OWUndergroundHallow : MusicScene
    {
        public override string Path => MusicPath.Otherworldly.Biomes.UndergroundHallow;
        public override bool IsOtherworldly => true;
        public override bool IsEnabled => owConfig.EnableOWUndergroundHallow;
        public override int? ReplaceMusicId => MusicID.OtherworldUndergroundHallow;
        public override bool ReplaceCondition(Player player) => true;
    }

    public class Music_OWUndergroundIce : MusicScene
    {
        public override string Path => MusicPath.Otherworldly.Biomes.UndergroundIce;
        public override bool IsOtherworldly => true;
        public override bool IsEnabled => owConfig.EnableOWUndergroundIce;
        public override SceneEffectPriority Priority => SceneEffectPriority.BiomeMedium;
        public override bool Condition(Player player)
        {
            return player.ZoneSnow && (player.ZoneDirtLayerHeight || player.ZoneRockLayerHeight);
        }
    }
}