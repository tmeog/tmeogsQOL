using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;

namespace tmeogsQOL.everything.proj
{
	public class WaypointProj : ModProjectile
	{
		float startScale = 1f;
		public override void SetDefaults()
		{
			Projectile.width = 64;
            Projectile.height = 64;
            Projectile.aiStyle = -1;
            Projectile.tileCollide = false;
            Projectile.ignoreWater = true;
		}

		public override bool? CanDamage()
        {
            return false;
        }

		public override void AI() {
			float time = (float)Main.time / 60f;
    		float sinValue = (float)Math.Sin(time) * 0.5f + 0.5f;
    		float newScale = startScale + sinValue * 0.5f;
    
    		Projectile.scale = newScale;
			Projectile.rotation += 0.01f;
		}
	}
}
