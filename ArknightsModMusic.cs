using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace ArknightsModMusic
{
	public class ArknightsModMusic : Mod
	{

	}
    public abstract class SceneMusicLoaden : ModSceneEffect {
        //public override bool IsLoadingEnabled(Mod mod) => !ModLoader.HasMod("ArknightsMod");
        public override SceneEffectPriority Priority => SceneEffectPriority.BiomeHigh;
        public override int Music => MusicLoader.GetMusicSlot(Mod, "Music/" + FileName);
        public abstract string FileName { get; }
    }
    
    public class Music_DesertDay : SceneMusicLoaden {
        public override string FileName => "ÈûÈÉ³ªÆ¬-MSR & Gareth Coker - Ï¸É³"; 
        public override bool IsSceneEffectActive(Player p) => p.ZoneDesert && Main.dayTime;
    }

    public class Music_DesertNight : SceneMusicLoaden {
        public override string FileName => "ÈûÈÉ³ªÆ¬-MSR & Gareth Coker - From The Desert"; 
        public override bool IsSceneEffectActive(Player p) => p.ZoneDesert && !Main.dayTime;
    }

    public class Music_DesertUnderground : SceneMusicLoaden {
        public override string FileName => "ÈûÈÉ³ªÆ¬-MSR & Eagle Wei - ÁÒÑôÓëµ¶ÈÐ"; 
        public override bool IsSceneEffectActive(Player p) => p.ZoneUndergroundDesert;
    }

    public class Music_JungleDay : SceneMusicLoaden {
        public override string FileName => "ÈûÈÉ³ªÆ¬-MSR - ÂÌÖÞ"; 
        public override bool IsSceneEffectActive(Player p) => p.ZoneJungle && Main.dayTime;
    }

    public class Music_JungleNight : SceneMusicLoaden {
        public override string FileName => "ÈûÈÉ³ªÆ¬-MSR & KK ZHANG - ÖðÁÔ"; 
        public override bool IsSceneEffectActive(Player p) => p.ZoneJungle && !Main.dayTime;
    }

    public class Music_JungleUnderground : SceneMusicLoaden {
        public override string FileName => "ÈûÈÉ³ªÆ¬-MSR & Eagle Wei - ¿Ö¾å°µ³±"; 
        public override bool IsSceneEffectActive(Player p) => p.ZoneJungle && p.ZoneDirtLayerHeight;
    }

    public class Music_SnowDay : SceneMusicLoaden {
        public override string FileName => "ÈûÈÉ³ªÆ¬-MSR & Adam Gubman - Òò·Ç±ùÔ­"; 
        public override bool IsSceneEffectActive(Player p) => p.ZoneSnow && Main.dayTime;
    }

    public class Music_SnowNight : SceneMusicLoaden {
        public override string FileName => "ÈûÈÉ³ªÆ¬-MSR & Adam Gubman - Ô¶¼ûÖÕ½ç"; 
        public override bool IsSceneEffectActive(Player p) => p.ZoneSnow && !Main.dayTime;
    }

    public class Music_SnowUnderground : SceneMusicLoaden {
        public override string FileName => "ÈûÈÉ³ªÆ¬-MSR & Adam Gubman - ¹é»¹»ÄÒ°"; 
        public override bool IsSceneEffectActive(Player p) => p.ZoneSnow && p.ZoneRockLayerHeight;
    }
    public class Music_HallowDay : SceneMusicLoaden {
        public override string FileName => "ÈûÈÉ³ªÆ¬-MSR & Erik Castro - ²»´æÔÚµÄÀÖÔ°"; 
        public override bool IsSceneEffectActive(Player p) => p.ZoneHallow && Main.dayTime;
    }

    public class Music_HallowNight : SceneMusicLoaden {
        public override string FileName => "ÈûÈÉ³ªÆ¬-MSR & Erik Castro - Ê¥³ÇÈÕ³£"; 
        public override bool IsSceneEffectActive(Player p) => p.ZoneHallow && !Main.dayTime;
    }

    public class Music_HallowUnderground : SceneMusicLoaden {
        public override string FileName => "ÈûÈÉ³ªÆ¬-MSR & Erik Castro - ÎÞ×ïÖ®ÈË"; 
        public override bool IsSceneEffectActive(Player p) => p.ZoneHallow && p.ZoneRockLayerHeight;
    }

    public class Music_CorruptSurface : SceneMusicLoaden {
        public override string FileName => "ÈûÈÉ³ªÆ¬-MSR - ÈÙ¹â°µ³Á"; 
        public override bool IsSceneEffectActive(Player p) => p.ZoneCorrupt && p.ZoneOverworldHeight;
    }

    public class Music_CorruptUnderground : SceneMusicLoaden {
        public override string FileName => "ÈûÈÉ³ªÆ¬-MSR & LJCH - Wecgas fore tham Cynge, Searu fore tham Ethle"; 
        public override bool IsSceneEffectActive(Player p) => p.ZoneCorrupt && p.ZoneRockLayerHeight;
    }

    public class Music_SpaceDay : SceneMusicLoaden {
        public override string FileName => "ÈûÈÉ³ªÆ¬-MSR & Steven Grove - Ad astra"; 
        public override SceneEffectPriority Priority => SceneEffectPriority.Environment;
        public override bool IsSceneEffectActive(Player p) => p.ZoneSkyHeight && Main.dayTime;
    }

    public class Music_SpaceNight : SceneMusicLoaden {
        public override string FileName => "ÈûÈÉ³ªÆ¬-MSR & Eagle Wei - ÈºÐÇ¼ûÎÒ"; 
        public override SceneEffectPriority Priority => SceneEffectPriority.Environment;
        public override bool IsSceneEffectActive(Player p) => p.ZoneSkyHeight && !Main.dayTime;
    }

    public class Music_Hell : SceneMusicLoaden {
        public override string FileName => "ÈûÈÉ³ªÆ¬-MSR - Wavering Flame"; 
        public override SceneEffectPriority Priority => SceneEffectPriority.Environment;
        public override bool IsSceneEffectActive(Player p) => p.ZoneUnderworldHeight;
    }

    public class Music_BloodMoon : SceneMusicLoaden {
        public override string FileName => "ÈûÈÉ³ªÆ¬-MSR & Adam Gubman - ÐÐÎÄÖ®ÔÏ"; 
        public override SceneEffectPriority Priority => SceneEffectPriority.Event;
        public override bool IsSceneEffectActive(Player p) => Main.bloodMoon;
    }

    public class Music_Meteor : SceneMusicLoaden {
        public override string FileName => "ÈûÈÉ³ªÆ¬-MSR & Steven Grove - Éî²ãÃÔ×í"; 
        public override bool IsSceneEffectActive(Player p) => p.ZoneMeteor;
    }

    public class Music_Graveyard : SceneMusicLoaden {
        public override string FileName => "ÈûÈÉ³ªÆ¬-MSR & Adam Gubman - Ñ¬ÌÕ"; 
        public override bool IsSceneEffectActive(Player p) => p.ZoneGraveyard;
    }
}
