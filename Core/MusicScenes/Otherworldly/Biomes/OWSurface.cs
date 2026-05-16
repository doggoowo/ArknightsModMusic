using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ArknightsModMusic.Core.MusicScenes.Otherworldly.Biomes
{
    public class Music_OWOverworldDay : MusicScene
    {
        public override string Path => MusicPath.Otherworldly.Biomes.OverworldDay;
        public override bool IsOtherworldly => true;
        public override bool IsEnabled => owConfig.EnableOWOverworldDay;
        public override int? ReplaceMusicId => MusicID.OtherworlddDay;
        public override bool ReplaceCondition(Player player) => true;
    }
    public class Music_OWOverworldNight : MusicScene
    {
        public override string Path => MusicPath.Otherworldly.Biomes.OverworldNight;
        public override bool IsOtherworldly => true;
        public override bool IsEnabled => owConfig.EnableOWOverworldNight;
        public override int? ReplaceMusicId => MusicID.OtherworldNight;
        public override bool ReplaceCondition(Player player) => true;
    }
    public class Music_OWCorruption : MusicScene
    {
        public override string Path => MusicPath.Otherworldly.Biomes.Corruption;
        public override bool IsOtherworldly => true;
        public override bool IsEnabled => owConfig.EnableOWCorruption;
        public override int? ReplaceMusicId => MusicID.OtherworldCorruption;
        public override bool ReplaceCondition(Player player) => true;
    }
    public class Music_OWCrimson : MusicScene
    {
        public override string Path => MusicPath.Otherworldly.Biomes.Crimson;
        public override bool IsOtherworldly => true;
        public override bool IsEnabled => owConfig.EnableOWCrimson;
        public override int? ReplaceMusicId => MusicID.OtherworldCrimson;
        public override bool ReplaceCondition(Player player) => true;
    }
    public class Music_OWDesert : MusicScene
    {
        public override string Path => MusicPath.Otherworldly.Biomes.Desert;
        public override bool IsOtherworldly => true;
        public override bool IsEnabled => owConfig.EnableOWDesert;
        public override int? ReplaceMusicId => MusicID.OtherworldDesert;
        public override bool ReplaceCondition(Player player) => true;
    }
    public class Music_OWHallow : MusicScene
    {
        public override string Path => MusicPath.Otherworldly.Biomes.Hallow;
        public override bool IsOtherworldly => true;
        public override bool IsEnabled => owConfig.EnableOWHallow;
        public override int? ReplaceMusicId => MusicID.OtherworldHallow;
        public override bool ReplaceCondition(Player player) => true;
    }
    public class Music_OWIce : MusicScene
    {
        public override string Path => MusicPath.Otherworldly.Biomes.Ice;
        public override bool IsOtherworldly => true;
        public override bool IsEnabled => owConfig.EnableOWIce;
        public override int? ReplaceMusicId => MusicID.OtherworldIce;
        public override bool ReplaceCondition(Player player) => true;
    }
    public class Music_OWJungle : MusicScene
    {
        public override string Path => MusicPath.Otherworldly.Biomes.Jungle;
        public override bool IsOtherworldly => true;
        public override bool IsEnabled => owConfig.EnableOWJungle;
        public override int? ReplaceMusicId => MusicID.OtherworldJungle;
        public override bool ReplaceCondition(Player player) => true;
    }
    public class Music_OWOcean : MusicScene
    {
        public override string Path => MusicPath.Otherworldly.Biomes.Ocean;
        public override bool IsOtherworldly => true;
        public override bool IsEnabled => owConfig.EnableOWOcean;
        public override int? ReplaceMusicId => MusicID.OtherworldOcean;
        public override bool ReplaceCondition(Player player) => true;
    }
}