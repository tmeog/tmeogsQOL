using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.Audio;
using System;

namespace tmeogsQOL.everything.proj
{
	public class SunDeathProj : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			Main.projFrames[Projectile.type] = 4;
		}

		public override void SetDefaults()
		{
			Projectile.width = 64;
            Projectile.height = 64;

            Projectile.aiStyle = 0;
			Projectile.light = 1f;
			Projectile.friendly = true;
            Projectile.tileCollide = false;
            Projectile.ignoreWater = true;
			Projectile.penetrate = -1;

			Projectile.timeLeft = 203;
		}

		public override void AI() {
			Projectile.velocity *= 0.99f;

			if (Projectile.owner == Main.myPlayer && Projectile.timeLeft <= 3) { 
											
											// explode
				Projectile.alpha = 255;

				Projectile.Resize(500, 500);

				Projectile.damage = 2000;
				Projectile.knockBack = 10f;
			}

			if (++Projectile.frameCounter >= 5) {
				Projectile.frameCounter = 0;
				if (++Projectile.frame >= Main.projFrames[Projectile.type])
					Projectile.frame = 0;
			}

			float maxDetectRadius = 700f;
			float projSpeed = 4f;

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

		public override bool? CanHitNPC(NPC target)
		{
    		if (Projectile.owner == Main.myPlayer && Projectile.timeLeft > 3){
    		    return false;
    		}
    		else{
    		    return base.CanHitNPC(target);
    		}
		}

		public void FadeInAndOut() {
			// If last less than 50 ticks — fade in, than more — fade out
			if (Projectile.ai[0] <= 50f) {
				// Fade in
				Projectile.alpha -= 15;
				if (Projectile.alpha < 100)
					Projectile.alpha = 100;

				return;
			}
		}

		public override void Kill (int timeLeft){
			for (int i = 0; i < 150; i++){
					Dust dust;
					Vector2 position = Projectile.Center - new Vector2(500 / 2, 500 / 2);
					dust = Main.dust[Terraria.Dust.NewDust(position, 500, 500, 4, 0f, 0f, 0, new Color(0,22,255), 2.5f)];
					dust.noGravity = true;
			}

			SoundEngine.PlaySound(SoundID.Item14, Projectile.position);
		}
	}
}
