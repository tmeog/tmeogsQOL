using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using System;
using Microsoft.Xna.Framework;

namespace tmeogsQOL.everything.items
{
	public class GraveDestroyer : ModItem
	{
		public override void SetStaticDefaults()
		{
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 10;
		}

		public override void SetDefaults()
		{
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 15;
			Item.useAnimation = 15;
			Item.useStyle = ItemUseStyleID.HoldUp;
			Item.value = 0;
			Item.rare = ItemRarityID.Green;
			Item.noMelee = true;
			Item.UseSound = SoundID.Item29;
			Item.autoReuse = false;
			Item.consumable = true;
            Item.shoot = ProjectileID.ConfettiGun;
			Item.shootSpeed = 4;
            Item.maxStack = 9999;
		}
		
		public override bool? UseItem(Player player)
        {
            Random r = new();
            if (player.altFunctionUse == 0){
				for (int i = 0; i < Main.tile.Width; i++)
            	{
            	    for (int j = 0; j < Main.tile.Height; j++)
            	    {
            	        Tile tile = Main.tile[i, j];
	
            	        if (tile.HasTile && tile.TileType == TileID.Tombstones){
            	            WorldGen.KillTile(i, j);

							if (Main.netMode != NetmodeID.MultiplayerClient) 
							{
                                int n = NPC.NewNPC(NPC.GetSource_NaturalSpawn(), (int)(r.Next(2) == 0 ? player.Center.X - 2000 : player.Center.X + 2000) + r.Next(200) - 200, (int)player.Center.Y, NPCID.Ghost);
                                if (Main.netMode == NetmodeID.Server)
                                {
                                    NetMessage.SendData(MessageID.SyncNPC, number: n);
                                }
                            }
                        }
            	    }
            	}

                if (Main.netMode != NetmodeID.MultiplayerClient)
                {
					Projectile.NewProjectile(Projectile.GetSource_None(), player.position, Vector2.Zero, ProjectileID.ConfettiGun, 0, 0f);
                }

                return true;
			}
			return false;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddRecipeGroup("tmeogsQOL:Graves");
			recipe.Register();
		}
	}
}