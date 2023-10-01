using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;

namespace tmeogsQOL.everything.proj
{
	public class EnderPearlProj : ModProjectile
	{
		public override void SetDefaults()
		{
			Projectile.width = 39;
            Projectile.height = 39;

            Projectile.aiStyle = 1;
			Projectile.friendly = true;
            Projectile.tileCollide = true;
            Projectile.ignoreWater = false;
		}

		public override void Kill (int timeLeft){
			Player player = Main.player[Projectile.owner];
			player.Teleport(Projectile.position, 1);
		}
	}
}
