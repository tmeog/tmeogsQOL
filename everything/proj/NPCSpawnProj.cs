using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Chat;
using Microsoft.Xna.Framework;
using System;
using Terraria.Localization;

namespace tmeogsQOL.everything.proj
{
	public class NPCSpawnProj : ModProjectile
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

		public override bool? CanDamage(){
            return false;
        }

        public override void OnKill(int timeLeft){
            if (Main.netMode == NetmodeID.MultiplayerClient)
                return;

			int n = NPC.NewNPC(NPC.GetBossSpawnSource(Projectile.owner), (int)Projectile.Center.X, (int)Projectile.Center.Y, (int)Projectile.ai[0]);
            if (Main.netMode == NetmodeID.Server){
                NetMessage.SendData(MessageID.SyncNPC, number: n);
            }
		}
	}
}