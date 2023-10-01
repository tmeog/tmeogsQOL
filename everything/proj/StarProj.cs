using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;

namespace tmeogsQOL.everything.proj
{
	public class StarProj : ModProjectile
	{
		public override void SetDefaults()
		{
			Projectile.width = 64;
            Projectile.height = 64;

            Projectile.aiStyle = 0;
			Projectile.DamageType = DamageClass.Ranged;
			Projectile.light = 1f;
			Projectile.penetrate = 2;
			Projectile.friendly = true;
			Projectile.hostile = false;
            Projectile.tileCollide = false;
            Projectile.ignoreWater = true;

			Projectile.alpha = 125;
		}

		public override void AI() {

			if (Projectile.velocity.X < 0)
				Projectile.rotation -= 0.3f;
			else
				Projectile.rotation += 0.3f;

			float maxDetectRadius = 700f;
			float projSpeed = 28f;

			NPC closestNPC = FindClosestNPC(maxDetectRadius);
			if (closestNPC == null)
				return;

			Projectile.velocity = (closestNPC.Center - Projectile.Center).SafeNormalize(Vector2.Zero) * projSpeed;
		}

		public NPC FindClosestNPC(float maxDetectDistance) {
			NPC closestNPC = null;

			float sqrMaxDetectDistance = maxDetectDistance * maxDetectDistance;

			for (int k = 0; k < Main.maxNPCs; k++) {
				NPC target = Main.npc[k];
				if (target.CanBeChasedBy()) {
					float sqrDistanceToTarget = Vector2.DistanceSquared(target.Center, Projectile.Center);

					if (sqrDistanceToTarget < sqrMaxDetectDistance) {
						sqrMaxDetectDistance = sqrDistanceToTarget;
						closestNPC = target;
					}
				}
			}

			return closestNPC;
		}

		public void FadeInAndOut() {
			if (Projectile.ai[0] <= 50f) {
				Projectile.alpha -= 15;
				if (Projectile.alpha < 100)
					Projectile.alpha = 100;

				return;
			}
		}

		public override void Kill (int timeLeft){
			for (int i = 0; i < 25; i++){
				Dust dust;
				Vector2 position = Projectile.Center;
				dust = Main.dust[Terraria.Dust.NewDust(position, 30, 30, 0, 0f, 0f, 0, new Color(175,0,201), 1f)];
				dust.fadeIn = 1.1511629f;
			}
		}
	}
}
