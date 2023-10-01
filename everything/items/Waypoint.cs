using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.Chat;
using Terraria.Localization;
using Terraria.GameContent.Creative;
using tmeogsQOL.everything.proj;
using System;

namespace tmeogsQOL.everything.items
{
	public class Waypoint : ModItem
	{
		public Vector2 WaypointPos;
		public bool WaypointSet = false;

		public override void SetStaticDefaults()
		{
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.width = 64;
			Item.height = 64;
			Item.useTime = 15;
			Item.useAnimation = 15;
			Item.useStyle = 1;
			Item.value = 10000;
			Item.rare = 2;
			Item.noMelee = true;
			Item.autoReuse = false;
			Item.consumable = false;
		}

		public override bool AltFunctionUse(Player player) {
			return true;
		}
		
		public override bool CanUseItem(Player player)
        {
            for (int i = 0; i < Main.maxNPCs; i++)
            {
                if (Main.npc[i].active && Main.npc[i].boss)
                {
                    return false;
                }
            }
            return true;
        }

		public override bool? UseItem(Player player)
        {
			string text = "No waypoint set";
			Color TC = new Color(252, 127, 3);

			string text2 = "Waypoint set";

			if (player.altFunctionUse == 0){ //left click
				if (WaypointSet){
						player.Teleport(WaypointPos, 1);
					} else {											//chat text
						if (Main.netMode == NetmodeID.SinglePlayer){
                			Main.NewText(text, TC);
            			} else if (Main.netMode == NetmodeID.Server){
                			ChatHelper.BroadcastChatMessage(NetworkText.FromLiteral(text), TC);
                			NetMessage.SendData(7);
            		}
				}
			}
			if (player.altFunctionUse == 2){ //right click
				WaypointPos = player.position;
				WaypointSet = true;

				foreach (Projectile projectile in Main.projectile){
    				if (projectile.active && projectile.type == ModContent.ProjectileType<WaypointProj>())
    				{
    				        projectile.Kill();
    				}
    			}

				Projectile.NewProjectile(player.GetSource_ItemUse(Item), player.Center.X, player.Center.Y, 0, 0, ModContent.ProjectileType<WaypointProj>(), 0, 0, Main.myPlayer);

				if (Main.netMode == NetmodeID.SinglePlayer){			//chat text
                			Main.NewText(text2, TC);
            			} else if (Main.netMode == NetmodeID.Server){
                			ChatHelper.BroadcastChatMessage(NetworkText.FromLiteral(text2), TC);
                			NetMessage.SendData(7);
						}
			}
			return true;
		}

		public override void AddRecipes()
		{
			/*
			Recipe r = CreateRecipe();
			r.AddIngredient(ItemID.PlatinumBar, 3);
			r.AddIngredient(ItemID.Topaz, 2);
			r.AddTile(TileID.Anvils);
			r.Register();

			Recipe r2 = CreateRecipe();
			r2.AddIngredient(ItemID.GoldBar, 3);
			r2.AddIngredient(ItemID.Topaz, 2);
			r2.AddTile(TileID.Anvils);
			r2.Register();
			*/
		}
	}
}