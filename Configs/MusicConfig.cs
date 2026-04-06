using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace ArknightsModMusic.Configs
{
    public class MusicConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ClientSide;

        [DefaultValue(true)]
        [ReloadRequired]
        public bool EnableDefaultModMusic { get; set; } = true;

        [DefaultValue(true)]
        [ReloadRequired]
        public bool EnableOtherworldlyModMusic { get; set; } = true;
    }
}