using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Audio;
using Microsoft.Xna.Framework;

namespace tmeogsQOL.everything.proj
{
	public class SkullEmojiProj : ModProjectile
	{
		ReLogic.Utilities.SlotId soundInstance;
		bool FunniSound = false;
		public override void SetDefaults()
		{
			Projectile.width = 120;
            Projectile.height = 72;

            Projectile.aiStyle = 1;
			Projectile.DamageType = DamageClass.Ranged;

			Projectile.penetrate = -1;

			Projectile.light = 1.25f;
			
			Projectile.friendly = true;
			Projectile.hostile = false;

            Projectile.tileCollide = false;
            Projectile.ignoreWater = true;

			Projectile.extraUpdates = 3;

			AIType = ProjectileID.Bullet;
		}

        public override void AI()
        {
            if (FunniSound == false)
        	{
        	    soundInstance = SoundEngine.PlaySound(new SoundStyle("tmeogsQOL/everything/Sounds/BadToTheBone") { Volume = 1f, Pitch = 0f }, Projectile.Center);
        	    FunniSound = true;
        	}

			if (SoundEngine.TryGetActiveSound(soundInstance, out var activeSound)) 
			{
			    activeSound.Position = Projectile.Center;
			}


			if (Projectile.velocity.X < 0)
            {
                Projectile.spriteDirection = -1;
				Projectile.rotation = Projectile.velocity.ToRotation() - MathHelper.PiOver2 * 2;
            }
            else
            {
                Projectile.spriteDirection = 1;
				Projectile.rotation = Projectile.velocity.ToRotation();
            }
        }
    }
}
