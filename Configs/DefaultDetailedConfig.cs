using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace ArknightsModMusic.Configs
{
    public class DefaultDetailedConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ClientSide;

        [Header("Biomes")]
        // 环境
        [DefaultValue(true)][ReloadRequired] public bool EnableOverworldDay { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableOverworldNight { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableAether { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableCorruption { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableCrimson { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableDesert { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableDungeon { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableGraveyard { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableHallow { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableIce { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableJungleDay { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableJungleNight { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableLihzahrd { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableMushrooms { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableOceanDay { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableOceanNight { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableSpaceDay { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableSpaceNight { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableTownDay { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableTownNight { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableUnderground { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableUndergroundCorruption { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableUndergroundCrimson { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableUndergroundDesert { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableUndergroundHallow { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableUndergroundIce { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableUndergroundJungle { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableUnderworld { get; set; }

        [Header("Events")]
        [DefaultValue(true)][ReloadRequired] public bool EnableEclipse { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableEerie { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableFrostMoon { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableGoblinArmy { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableHighWind { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableLunarEvent { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableMartianMadness { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableMorningRain { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableOldOnesArmy { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnablePirateInvasion { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnablePumpkinMoon { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableRain { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableSandstorm { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableSlimeRain { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableStorm { get; set; }

        [Header("Bosses")]
        [DefaultValue(true)][ReloadRequired] public bool EnableBoss1 { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableBoss2 { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableBoss3 { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableDeerclops { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableDukeFishron { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableEmpressOfLight { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableGolem { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableMoonLord { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnablePlantera { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableQueenBee { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableQueenSlime { get; set; }

        [Header("Misc")]
        [DefaultValue(true)][ReloadRequired] public bool EnableCredits { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableDayRemix { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableDrunkWorldGen { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableTitle { get; set; }
        [DefaultValue(true)][ReloadRequired] public bool EnableTitleLegacy { get; set; }
    }
}