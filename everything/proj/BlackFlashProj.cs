using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Chat;
using Microsoft.Xna.Framework;
using System;
using Terraria.Localization;

namespace tmeogsQOL.everything.proj
{
	public class BlackFlashProj : ModProjectile
	{
        public override void SetStaticDefaults()
        {
            Main.projFrames[Projectile.type] = 3;
        }
        public override void SetDefaults()
		{
			Projectile.width = 128;
            Projectile.height = 128;

            Projectile.aiStyle = -1;
            Projectile.timeLeft = 30;
            Projectile.penetrate = -1;

            Projectile.tileCollide = false;
            Projectile.ignoreWater = true;
            Projectile.friendly = true;

            Projectile.light = 1f;

            Projectile.ai[0] = 0;
        }

        public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
        {
            if (target.lifeMax >= 2000 && target.life <= 0 && Projectile.ai[0] == 0)
            {
                Projectile.ai[0] = 1;
                Projectile.timeLeft = 300;
            }
        }

        public override void AI() 
		{
            if (++Projectile.frameCounter >= 4)
            {
                Projectile.frameCounter = 0;
                if (++Projectile.frame >= Main.projFrames[Projectile.type])
                {
                    Projectile.frame = 0;
                }  
            }
        }
    }
}