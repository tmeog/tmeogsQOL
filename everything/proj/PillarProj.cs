using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;

namespace tmeogsQOL.everything.proj
{
	public class PillarProj : ModProjectile
	{
		public override void SetDefaults()
		{
			Projectile.width = 2;
            Projectile.height = 2;
            Projectile.aiStyle = -1;
            Projectile.timeLeft = 1;
            Projectile.tileCollide = false;
            Projectile.ignoreWater = true;
            Projectile.hide = true;
		}

		public override bool? CanDamage()
        {
            return false;
        }

        public override void Kill(int timeLeft){
			if (Main.netMode == NetmodeID.MultiplayerClient)
                return;

			int[] type = new int[] { NPCID.LunarTowerNebula, NPCID.LunarTowerSolar, NPCID.LunarTowerStardust, NPCID.LunarTowerVortex };
			for (int i = 0; i < type.Length; i++){
				int n = NPC.NewNPC(NPC.GetBossSpawnSource(Main.myPlayer), (int)Projectile.Center.X, (int)Projectile.Center.Y, type[i]);
				if (Main.netMode == NetmodeID.Server){
                	NetMessage.SendData(MessageID.SyncNPC, number: n);
            	}
			}
		}
	}
}
