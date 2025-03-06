using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using tmeogsQOL.everything.Buffs;

namespace tmeogsQOL.everything
{
	public class ReqAINPC : GlobalNPC
    {
        int oldAI = 0;
        int oldDamage = 0;
        double oldFrameCounter = 0;
        Vector2 oldVel = Vector2.Zero;
        Vector2 frozenFrame = Vector2.Zero;
        bool oldGravity = false;
        bool frozenInTime = false;
        bool shouldDie = false;

        public override bool InstancePerEntity => true;

        public override void AI(NPC npc)
        {
            if (npc.HasBuff(ModContent.BuffType<TimeFrozeDebuff>()))
            {
                if (!frozenInTime)
                {
                    oldAI = npc.aiStyle;
					oldVel = npc.velocity;
                    frozenFrame = new(npc.frame.X, npc.frame.Y);
                    oldFrameCounter = npc.frameCounter;
                    oldDamage = npc.damage;
                    oldGravity = npc.noGravity;

                    frozenInTime = true;
                }

                npc.velocity.X = 0f;
                npc.velocity.Y = 0f;

                npc.frame.X = (int)frozenFrame.X;
                npc.frame.Y = (int)frozenFrame.Y;

                npc.damage = 0;

                npc.frameCounter = 0;
                npc.noGravity = true;
                npc.aiStyle = -1;
            }
            else
            {
                if (frozenInTime)
                {
                    npc.aiStyle = oldAI;
                    npc.velocity = oldVel;
                    npc.noGravity = oldGravity;
                    npc.frameCounter = oldFrameCounter;
                    npc.damage = oldDamage;

                    frozenInTime = false;

                    if (shouldDie)
                    {
                        npc.life = 0;
                        shouldDie = false;
                    }

                }
                base.AI(npc);
            }
        }
    }
}