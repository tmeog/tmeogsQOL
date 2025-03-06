using Terraria;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using tmeogsQOL.everything.items.BossSummons;

namespace tmeogsQOL.everything
{
    public class ReqKeybinds : ModSystem
    {
        public static ModKeybind TimeStopKey { get; private set; }
        public override void Load()
        {
            // TimeStopKey = KeybindLoader.RegisterKeybind(Mod, "Dont worry about it :)", "Z");
        }

        public override void Unload()
        {
            TimeStopKey = null;
        }
    }
}