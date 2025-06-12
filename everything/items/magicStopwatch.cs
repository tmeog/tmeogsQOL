using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace tmeogsQOL.everything.items
{
	public class magicStopwatch : ModItem
	{
		public override void SetStaticDefaults()
		{
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.width = 36;
			Item.height = 36;
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
			if (player.altFunctionUse == 0)
			{
				Main.dayTime = !Main.dayTime;
				Main.time = 0;
				if (++Main.moonPhase >= 8)
				{
					Main.moonPhase = 0;
				}
			}
			if (player.altFunctionUse == 2)
			{
				Main.moonPhase++;
				if (++Main.moonPhase >= 8)
				{
					Main.moonPhase = 0;
                }
            }

            if (Main.netMode == NetmodeID.MultiplayerClient)
                NetMessage.SendData(MessageID.WorldData);
            return true;
		}

		public override void UpdateInventory(Player player)
		{
			player.accWatch = 3;
			player.accCalendar = true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddRecipeGroup("tmeogsQOL:GoldWatch");
			recipe.AddIngredient(ItemID.FallenStar, 3);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}