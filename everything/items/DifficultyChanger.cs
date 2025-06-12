using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.Chat;
using Terraria.Localization;
using Terraria.GameContent.Creative;
using System;

namespace tmeogsQOL.everything.items
{
	public class DifficultyChanger : ModItem
	{
		public override void SetStaticDefaults()
		{
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.width = 30;
			Item.height = 30;
			Item.useTime = 15;
			Item.useAnimation = 15;
			Item.useStyle = ItemUseStyleID.HoldUp;
			Item.value = 1000000;
			Item.rare = ItemRarityID.Green;
			Item.noMelee = true;
			Item.UseSound = SoundID.Roar;
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
			string text;

			if (player.altFunctionUse == 0)
			{
				switch (Main.GameMode){
					case 0:
						Main.GameMode = 1;
						text = "Expert mode";
						break;

					case 1:
						Main.GameMode = 2;
						text = "Master mode";
						break;

					case 2:
						Main.GameMode = 3;
						text = "Journey mode";
						break;

					default:
						Main.GameMode = 0;
						text = "Normal mode";
						break;
				}
			} 
			else if (player.altFunctionUse == 2)
			{
				switch (player.difficulty){
					case 0:
						player.difficulty = 1;
						text = "Mediumcore";
						break;

					case 1:
						player.difficulty = 2;
						text = "Hardcore, don't die lol";
						break;

					case 2:
						player.difficulty = 3;
						text = "Journey mode";
						break;

					default:
						player.difficulty = 0;
						text = "Softcore";
						break;
				}
			} 
			else 
			{
				text = "My code is bad";
			}

			if (Main.netMode == NetmodeID.SinglePlayer)
			{
				Main.NewText(text, new Color(175, 75, 255));
			}
			else if (Main.netMode == NetmodeID.Server)
			{
				ChatHelper.BroadcastChatMessage(NetworkText.FromLiteral(text), new Color(175, 75, 255));
				NetMessage.SendData(MessageID.WorldData);
			}
			return true;
		}
	}
}