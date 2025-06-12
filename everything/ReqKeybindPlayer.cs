using System;
using Terraria;
using Terraria.GameInput;
using Terraria.ModLoader;
using tmeogsQOL.everything.Buffs;

namespace tmeogsQOL.everything
{
    public class ReqKeybindPlayer : ModPlayer
    {
        //bool ZAWARUDO = false;
        //string[] timeStopMessage = ["ZA WARUDO", "HALT", "ENGLISH OR SPANISH"];
        //Random r = new();

        //public override void ProcessTriggers(TriggersSet triggersSet)
        //{
        //    if (ReqKeybinds.TimeStopKey.JustPressed)
        //    {
        //        if (!ZAWARUDO)
        //        {
        //            CombatText.NewText(Player.getRect(), new(191, 178, 36), timeStopMessage[r.Next(timeStopMessage.Length)]);

        //            foreach (NPC npc in Main.ActiveNPCs)
        //            {
        //                npc.AddBuff(ModContent.BuffType<TimeFrozeDebuff>(), 60 * 9999);
        //            }

        //            ZAWARUDO = true;
        //        }
        //        else
        //        {
        //            foreach (NPC npc in Main.ActiveNPCs)
        //            {
        //                if (npc.HasBuff(ModContent.BuffType<TimeFrozeDebuff>()))
        //                {
        //                    npc.DelBuff(npc.FindBuffIndex(ModContent.BuffType<TimeFrozeDebuff>()));
        //                }
        //            }

        //            ZAWARUDO = false;
        //        }
        //    }
        //}
    }
}