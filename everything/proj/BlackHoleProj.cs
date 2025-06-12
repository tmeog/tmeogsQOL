using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.Audio;
using System;

namespace tmeogsQOL.everything.proj
{
	public class BlackHoleProj : ModProjectile
	{
		public override void SetDefaults(){
			Projectile.width = 800;
            Projectile.height = 800;

            Projectile.aiStyle = 0;
			Projectile.light = 1f;
			Projectile.friendly = true;
            Projectile.tileCollide = false;
            Projectile.ignoreWater = true;
			Projectile.penetrate = -1;

			Projectile.timeLeft = 60;
			Projectile.alpha = 128;
		}

		public override void AI() {
			Projectile.velocity *= 0;
			Projectile.rotation += 0.1f;
			Projectile.alpha += 5;

			if (Projectile.alpha > 255)
				Projectile.alpha = 255;
		}

		public override bool? CanHitNPC(NPC target){
    		return false;
		}
	}
}
