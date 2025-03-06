using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Audio;
using Microsoft.Xna.Framework;
using System;
using Microsoft.CodeAnalysis;

namespace tmeogsQOL.everything.proj
{
	public class SkullEmojiProj_purple : ModProjectile
	{
		public override void SetDefaults()
		{
            Projectile.width = 120;
            Projectile.height = 72;

            Projectile.aiStyle = 0;
			Projectile.DamageType = DamageClass.Ranged;

			Projectile.light = 1.25f;
			
			Projectile.friendly = true;
			Projectile.hostile = false;

            Projectile.tileCollide = false;
            Projectile.ignoreWater = true;

			AIType = ProjectileID.Bullet;
		}

        public override void AI()
        {
			float maxDetectRadius = 700f;
			float projSpeed = 40f;

			NPC closestNPC = FindClosestNPC(maxDetectRadius);
			if (closestNPC == null)
			{
				Projectile.velocity = Projectile.velocity.SafeNormalize(Vector2.Zero) * projSpeed;
			} 
			else 
			{
				SmoothHoming(Projectile, closestNPC.position, 3, projSpeed);
			}

			float rotation = (float)Math.Atan2(Projectile.velocity.Y, Projectile.velocity.X);

			if (Projectile.velocity.X < 0)
            {
                Projectile.spriteDirection = -1;
				Projectile.rotation = rotation - MathHelper.PiOver2 * 2;
            }
            else
            {
                Projectile.spriteDirection = 1;
				Projectile.rotation = rotation;
            }
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


        //! I HAVE NO CLUE HOW THIS WORKS, ITS FROM THIS: https://github.com/Zeodexic/tsorcRevamp/blob/main/tsorcRevampUtils.cs#L774
        //! I LEFT THE COMMENTS FOR FUTURE GENERATIONS
        public static void SmoothHoming(Entity actor, Vector2 target, float acceleration, float topSpeed, Vector2? targetVelocity = null, bool bufferZone = true, float bufferStrength = 0.1f)
        {
            //If the target has a velocity then factor it in
            Vector2 velTarget = Vector2.Zero;
            if (targetVelocity != null)
            {
                velTarget = targetVelocity.Value;
            }

            //Get the difference between the center of both entities
            Vector2 posDifference = target - actor.Center;

            //Get the distance between them
            float distance = posDifference.Length();

            //Get the difference of velocities
            //This shifts the reference frame of the calculations, from here on out we are looking at the problem as if Entity 1 was still and Entity 2 had the velocity of both entities combined
            //The formulas below calculate where it will be in the future and then the entity is accelerated toward that point on an intercept trajectory
            Vector2 vTarget = velTarget - actor.velocity;

            //Normalize posDifference to get the direction of it, ignoring the length
            posDifference.Normalize();

            //Use a dot product to get the length of the velocity vector in the direction of the target.
            //This tells us how fast the actor is moving toward the target already
            float velocity = Vector2.Dot(-vTarget, posDifference);

            //Use the current velocity plus acceleration to calculate how long it will take to arrive using the formula for acceleration
            float eta = (-velocity / acceleration) + (float)Math.Sqrt((velocity * velocity / (acceleration * acceleration)) + 2 * distance / acceleration);

            //Use the velocity plus arrival time plus current target location to calculate the location the target will be at in the future
            Vector2 impactPos = target + vTarget * eta;

            //Generate a vector with length 'acceleration' pointing at that future location
            Vector2 fixedAcceleration = GenerateTargetingVector(actor.Center, impactPos, acceleration);

            //If distance or acceleration is 0 it will have nans, this deals with that
            if (fixedAcceleration.HasNaNs())
            {
                fixedAcceleration = Vector2.Zero;
            }

            //Update its acceleration
            actor.velocity += fixedAcceleration;

            //Slow it down to the speed limit if it is above it
            if (actor.velocity.Length() > topSpeed)
            {
                actor.velocity.Normalize();
                actor.velocity *= topSpeed;
            }

            //If it needs to slow down when arriving then do so
            //A distance of 300 and the formula here are super fudged. Could use improvement.
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
