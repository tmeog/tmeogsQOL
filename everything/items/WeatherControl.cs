using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using Terraria.Chat;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Creative;

namespace tmeogsQOL.everything.items
{
	
	public class WeatherControl : ModItem
	{
		private int toggle;
		
		public override void SetStaticDefaults()
		{
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.width = 32;
			Item.height = 32;
			Item.useTime = 15;
			Item.useAnimation = 15;
			Item.useStyle = ItemUseStyleID.HoldUp;
			Item.value = 10000;
			Item.rare = ItemRarityID.Green;
			Item.noMelee = true;
			Item.UseSound = SoundID.Item29;
			Item.autoReuse = false;
			Item.consumable = false;
		}
		
		public override bool AltFunctionUse(Player player) {
			return true;
		}
		
		public override bool? UseItem(Player player)
        {
			string text;
			Color TC = new Color(0, 200, 255);
			
			if (player.altFunctionUse == 2) { //Right-click
				switch (toggle){
					case 1:
						Main.windSpeedCurrent = 1;
						toggle++;
						text = "East Winds";
						break;

					case 2:
						Main.windSpeedCurrent = -1;
						toggle++;
						text = "West Winds";
						break;
				
					default:
						Main.windSpeedCurrent = 0;
						toggle = 1;
						text = "No Wind";
						break;	
				}
			
				if (Main.netMode == NetmodeID.SinglePlayer)
            	{
                	Main.NewText(text, TC);
            	}
            	else if (Main.netMode == NetmodeID.Server)
         		{
                	ChatHelper.BroadcastChatMessage(NetworkText.FromLiteral(text), TC);
                	NetMessage.SendData(MessageID.WorldData);
            	}
			}
			if (player.altFunctionUse == 0) { //Left-click
				switch (Main.raining){
					case true:
						Main.StopRain();
						text = "No Rain";
						break;
				
					default:
						Main.StartRain();
						text = "Rain Time";
						break;
				}

				if (Main.netMode == NetmodeID.SinglePlayer)
            	{
                	Main.NewText(text, TC);
            	}
            	else if (Main.netMode == NetmodeID.Server)
         		{
                	ChatHelper.BroadcastChatMessage(NetworkText.FromLiteral(text), TC);
                	NetMessage.SendData(MessageID.WorldData);
            	}
			}
		
			return true;
		}

		public override void UpdateInventory(Player player)
		{
			player.accWeatherRadio = true;
		}

		public override void AddRecipes()
		{
			Recipe r = CreateRecipe();
			r.AddRecipeGroup("IronBar", 10);
			r.AddTile(TileID.Anvils);
			r.Register();
		}
	}
}