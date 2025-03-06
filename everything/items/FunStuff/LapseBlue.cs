using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using tmeogsQOL.everything.proj;

namespace tmeogsQOL.everything.items.FunStuff
{
	public class LapseBlue : ModItem
	{
		public override void SetDefaults()
		{
			Item.DamageType = DamageClass.Magic;
			Item.damage = 1000;
			Item.crit = 40;
			Item.knockBack = 1;

			Item.width = 64;
			Item.height = 64;

			Item.useTime = 30;
			Item.useAnimation = 30;
			Item.autoReuse = false;
			Item.noUseGraphic = true;

			Item.useStyle = ItemUseStyleID.HoldUp;
			Item.value = 10000;
			Item.rare = ItemRarityID.Purple;

			Item.mana = 60;
			Item.shoot = ModContent.ProjectileType<LapseBlueProj>();
			Item.shootSpeed = 16f;
		}

		public override bool CanUseItem(Player player)
		{
            foreach (Projectile proj in Main.ActiveProjectiles)
            {
                if (proj.type == ModContent.ProjectileType<LapseBlueProj>() && proj.owner == player.whoAmI)
				{
					return false;
				}
                if (proj.type == ModContent.ProjectileType<ReversalRedProj>())
                {
                    return false;
                }
            }

            return true;
		}
	}
}