using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using tmeogsQOL.everything.proj;
using Terraria.GameContent.Creative;
using Terraria.DataStructures;

namespace tmeogsQOL.everything.items.BossSummons
{
	public class HotLightLadySummon : ModItem
	{
		public override void SetStaticDefaults()
		{
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 15;
			Item.useAnimation = 15;
			Item.useStyle = 4;
			Item.value = 10000;
			Item.rare = 2;
			Item.noMelee = true;
			Item.UseSound = SoundID.Roar;
			Item.autoReuse = false;
			Item.consumable = false;
			Item.shoot = ModContent.ProjectileType<HotLightLadyProj>();
		}
		
		public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback){
			if (Main.netMode == NetmodeID.Server) //sync time
                    NetMessage.SendData(MessageID.WorldData, -1, -1, null, 0, 0f, 0f, 0f, 0, 0, 0);
			Point Pos = Main.MouseWorld.ToPoint();
			Projectile.NewProjectile(player.GetSource_ItemUse(Item), Pos.X, Pos.Y, 0, 0, ModContent.ProjectileType<HotLightLadyProj>(), 0, 0, Main.myPlayer);
			return false;
		}
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.EmpressButterfly);
			recipe.Register();
		}
	}
}