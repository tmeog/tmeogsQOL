using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

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
			Item.useStyle = 4;
			Item.value = Item.buyPrice(gold: 1);
			Item.rare = 2;
			Item.noMelee = true;
			Item.UseSound = SoundID.Item29;
			Item.autoReuse = false;
			Item.consumable = true;
			Item.maxStack = 9999;
		}
		
		public override bool? UseItem(Player player)
        {
			if (player.altFunctionUse == 0){
				for (int i = 0; i < Main.tile.Width; i++)
            	{
            	    for (int j = 0; j < Main.tile.Height; j++)
            	    {
            	        Tile tile = Main.tile[i, j];
	
            	        if (tile.HasTile && tile.TileType == TileID.Tombstones){
            	            WorldGen.KillTile(i, j);
            	        }
            	    }
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