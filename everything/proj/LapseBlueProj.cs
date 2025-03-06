using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Chat;
using Microsoft.Xna.Framework;
using System;
using Terraria.Localization;

namespace tmeogsQOL.everything.proj
{
	public class LapseBlueProj : ModProjectile
	{
		public override void SetDefaults()
		{
			Projectile.width = 64;
            Projectile.height = 64;

            Projectile.aiStyle = -1;
            Projectile.timeLeft = 600;
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
            if (Projectile.ai[0] == 0)
            {
                if (Vector2.Distance(Projectile.Center, Main.MouseWorld) > 10)
                {
                    SmoothHoming(Projectile, Main.MouseWorld, 1, 50);
                }
                else
                {
                    SmoothHoming(Projectile, Main.MouseWorld, 0.2f, 50);
                }
            }
            else
            {
                Projectile.velocity *= 0.9f;
            }

            for (int i = 0; i < 5; i++)
            {
                Dust dust;
                Vector2 position = Projectile.Center - new Vector2(Projectile.width / 2, Projectile.height / 2);
                dust = Main.dust[Dust.NewDust(position, 64, 64, DustID.MagicMirror, 0f, 0f, 0, new Color(0, 200, 255), 1.3372093f)];
                dust.noGravity = true;
            }

        }

        // i stole this again lol, look at SkullEmojiProj_purple
        public static void SmoothHoming(Entity actor, Vector2 target, float acceleration, float topSpeed, Vector2? targetVelocity = null, bool bufferZone = true, float bufferStrength = 0.1f)
        {
            Vector2 velTarget = Vector2.Zero;
            if (targetVelocity != null)
            {
                velTarget = targetVelocity.Value;
            }

            Vector2 posDifference = target - actor.Center;

            float distance = posDifference.Length();

            Vector2 vTarget = velTarget - actor.velocity;

            posDifference.Normalize();

            float velocity = Vector2.Dot(-vTarget, posDifference);

            float eta = (-velocity / acceleration) + (float)Math.Sqrt((velocity * velocity / (acceleration * acceleration)) + 2 * distance / acceleration);

            Vector2 impactPos = target + vTarget * eta;

            Vector2 fixedAcceleration = GenerateTargetingVector(actor.Center, impactPos, acceleration);

            if (fixedAcceleration.HasNaNs())
            {
                fixedAcceleration = Vector2.Zero;
            }

            actor.velocity += fixedAcceleration;

            if (actor.velocity.Length() > topSpeed)
            {
                actor.velocity.Normalize();
                actor.velocity *= topSpeed;
            }

            if (bufferZone && distance < 300)
            {
                actor.velocity *= (float)Math.Pow(distance / 300, bufferStrength);
            }
        }
        public static Vector2 GenerateTargetingVector(Vector2 source, Vector2 target, float speed)
        {
            Vector2 distance = target - source;
            distance.Normalize();
            return distance * speed;
        }
    }
}