using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace ArknightsModMusic {
    public class MusicConfig : ModConfig {
        public override ConfigScope Mode => ConfigScope.ClientSide;
        [DefaultValue(true)][ReloadRequired] public bool EnableArknightsForestDaytime { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableArknightsForestNighttime { get; set; }


        [DefaultValue(true)][ReloadRequired] public bool EnableDesertDay { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableDesertNight { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableDesertUnderground { get; set; }

        [DefaultValue(true)][ReloadRequired] public bool EnableJungleDay { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableJungleNight { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableJungleUnderground { get; set; }

        [DefaultValue(true)][ReloadRequired] public bool EnableSnowDay { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableSnowNight { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableSnowUnderground { get; set; }

        [DefaultValue(true)][ReloadRequired] public bool EnableHallowDay { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableHallowNight { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableHallowUnderground { get; set; }

        [DefaultValue(true)][ReloadRequired] public bool EnableCorruptSurface { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableCorruptUnderground { get; set; }

        [DefaultValue(true)][ReloadRequired] public bool EnableSpaceDay { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableSpaceNight { get; set; }

        [DefaultValue(true)][ReloadRequired] public bool EnableHell { get; set; }

        [DefaultValue(true)][ReloadRequired] public bool EnableArknightsCorruptedOceanDaytime { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableArknightsCorruptedOceanNighttime { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableArknightsCrimsonOceanDaytime { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableArknightsCrimsonOceanNighttime { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableArknightsHallowedOceanDaytime { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableArknightsHallowedOceanNighttime { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableArknightsOceanDaytime { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableArknightsOceanNighttime { get; set; }

        [DefaultValue(true)][ReloadRequired] public bool EnableMeteor { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableGraveyard { get; set; }

        [DefaultValue(true)][ReloadRequired] public bool EnableBloodMoon { get; set; }

    }
}