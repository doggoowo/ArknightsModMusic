using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace ArknightsModMusic.Configs
{
    public class OtherworldlyDetailedConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ClientSide;

        [Header("Biomes")]
        [DefaultValue(true)][ReloadRequired] public bool EnableOWOverworldDay { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableOWOverworldNight { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableOWCorruption { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableOWCrimson { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableOWDesert { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableOWDungeon { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableOWHallow { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableOWIce { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableOWJungle { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableOWMushrooms { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableOWOcean { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableOWSpace { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableOWUnderground { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableOWUndergroundCorruption { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableOWUndergroundCrimson { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableOWUndergroundHallow { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableOWUndergroundIce { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableOWUnderworld { get; set; }

        [Header("Events")]
        [DefaultValue(true)][ReloadRequired] public bool EnableOWEerie { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableOWInvasion { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableOWLunarEvent { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableOWRain { get; set; }

        [Header("Bosses")]
        [DefaultValue(true)][ReloadRequired] public bool EnableOWBoss1 { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableOWBoss2 { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableOWBoss3 { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableOWMoonLord { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableOWPlantera { get; set; }

        [Header("Misc")]
        [DefaultValue(true)][ReloadRequired] public bool EnableOWCredits { get; set; }
    }
}