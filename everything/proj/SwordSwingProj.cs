using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.Audio;
using System;

namespace tmeogsQOL.everything.proj
{
	public class SwordSwingProj : ModProjectile
	{
		public override void SetDefaults(){
			Projectile.width = 640;
            Projectile.height = 640;

            Projectile.aiStyle = 0;
			Projectile.light = 1f;
			Projectile.friendly = true;
            Projectile.tileCollide = false;
            Projectile.ignoreWater = true;
			Projectile.penetrate = -1;

			Projectile.timeLeft = 30;
			Projectile.alpha = 128;
		}

		public override void AI() {
			Projectile.velocity *= 0;
			Player player = Main.player[Projectile.owner];
			Projectile.Center = player.Center;
			Projectile.rotation += 0.3f;
			
			Projectile.alpha += 3;

			if (Projectile.alpha > 255)
				Projectile.alpha = 255;
		}
	}
}
