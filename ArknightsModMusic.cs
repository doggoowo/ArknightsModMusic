using Terraria.ModLoader;

namespace ArknightsModMusic
{
    public class ArknightsModMusic : Mod
    {
        public static ArknightsModMusic Instance;
        public override void Load()
        {
            Instance = this;
        }
        public override void Unload()
        {
            Instance = null;
        }
    }
}
