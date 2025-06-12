using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Chat;
using Microsoft.Xna.Framework;
using System;
using Terraria.Localization;
using Terraria.DataStructures;

namespace tmeogsQOL.everything.proj
{
	public class ReversalRedProj : ModProjectile
	{
		public override void SetDefaults()
		{
			Projectile.width = 48;
            Projectile.height = 48;

            Projectile.aiStyle = -1;
            Projectile.timeLeft = 60;
            Projectile.penetrate = -1;

            Projectile.tileCollide = false;
            Projectile.ignoreWater = true;
            Projectile.friendly = true;

            Projectile.light = 1f;

            Projectile.ai[0] = 0;
        }

        public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
        {
            if (Projectile.ai[0] == 1 || Projectile.ai[0] == 2)
            {
                Console.WriteLine(target.Center.Distance(Main.player[Projectile.owner].Center));
                if (target.Center.Distance(Main.player[Projectile.owner].Center) <= 128)
                {
                    Projectile.ai[0] = 2;

                    Vector2 diff = target.position - Main.player[Projectile.owner].position;

                    float angle = (float)Math.Atan2(diff.Y, diff.X) + MathHelper.ToRadians(225f);
                    angle %= (2 * MathHelper.Pi);
                    
                    Projectile.ai[2] = angle;
                }
            }
            else if (Projectile.ai[0] == 0)
            {
                Projectile.ai[1] = 1;
            }
        }

        // ai[0] 0 = going away from player
        // ai[0] 1 = coming back
        // ai[0] 2 = won't hit player
        // ai[0] 3 = can come back

        // ai[1] 0 = hasn't hit anything during ai[0] 0
        // ai[1] 1 = has hit something during ai[0] 0


        // make projectile bigger when hit black flash
        // kill after like 5 frames

        public override void AI() 
		{
            if (Projectile.ai[0] == 0)
            {
                if (Projectile.timeLeft < 30)
                {
                    Projectile.ai[0] = 3;
                }
            }
            else if (Projectile.ai[0] < 3)
            {
                GoToPlayer();
                Projectile.timeLeft = 5;
            }
            else if (Projectile.ai[0] >= 4)
            {
                Projectile.ai[0]++;
                Projectile.timeLeft = 5;
                if (Projectile.ai[0] >= 9)
                {
                    Projectile.Kill();
                }
            }

            if (Projectile.ai[0] < 4)
            {
                for (int i = 0; i < 5; i++)
                {
                    Dust dust;
                    Vector2 position = Projectile.Center - new Vector2(Projectile.width / 2, Projectile.height / 2);
                    dust = Main.dust[Dust.NewDust(position, 32, 32, DustID.RedTorch, 0f, 0f, 0, new Color(255, 255, 255), 1.7441859f)];
                    dust.noGravity = true;
                }
            }
        }

        void GoToPlayer()
        {
            Projectile.velocity = (Main.player[Projectile.owner].Center - Projectile.Center);
            Projectile.velocity.Normalize();
            Projectile.velocity *= 64;

            if (Projectile.Center.Distance(Main.player[Projectile.owner].Center) < 64)
            {
                if (Projectile.ai[0] == 1)
                {
                    Main.player[Projectile.owner].Hurt(PlayerDeathReason.ByCustomReason(Main.player[Projectile.owner].name + " missed"), 300, 0);
                    Projectile.Kill();
                }
                else if (Projectile.ai[0] == 2 && Projectile.ai[1] == 0)
                {
                    int index = Projectile.NewProjectile(Player.GetSource_None(), Main.player[Projectile.owner].Center, Vector2.Zero, ModContent.ProjectileType<BlackFlashProj>(), 1000, 5);
                    Main.projectile[index].rotation = Projectile.ai[2];

                    Projectile.ai[0] = 4;
                    Vector2 dir = -Projectile.velocity;
                    dir.Normalize();
                    Projectile.velocity = Vector2.Zero;
                    Projectile.hide = true;
                    Projectile.width = 300;
                    Projectile.height = 300;
                    Projectile.Center = Main.player[Projectile.owner].Center + dir * 150;
                }
                else
                {
                    Projectile.Kill();
                }
            }
        }
    }
}