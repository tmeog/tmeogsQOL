using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace tmeogsQOL.everything.items
{
	public class TravelMerchantShopReset : ModItem
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
			Item.value = Item.buyPrice(gold: 1);
			Item.rare = ItemRarityID.Green;
			Item.noMelee = true;
			Item.UseSound = SoundID.Item29;
			Item.autoReuse = false;
			Item.consumable = true;
			Item.maxStack = 9999;
		}
		
		public override bool? UseItem(Player player)
        {
			if (player.altFunctionUse == 0){
				Chest.SetupTravelShop();
				return true;
			}
			return false;
		}
	}
}