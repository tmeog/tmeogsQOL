using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using tmeogsQOL.everything.proj;

namespace tmeogsQOL.everything.items.FunStuff
{
	public class ReversalRed : ModItem
	{
		public override void SetDefaults()
		{
			Item.DamageType = DamageClass.Magic;
			Item.damage = 5000;
			Item.crit = 40;
			Item.knockBack = 1;

			Item.width = 32;
			Item.height = 32;

			Item.useTime = 30;
			Item.useAnimation = 30;
			Item.autoReuse = false;
			Item.noUseGraphic = true;

			Item.useStyle = ItemUseStyleID.HoldUp;
			Item.value = 10000;
			Item.rare = ItemRarityID.Purple;

			Item.mana = 60;
			Item.shoot = ModContent.ProjectileType<ReversalRedProj>();
			Item.shootSpeed = 64f;
		}

		public override bool CanUseItem(Player player)
		{
            foreach (Projectile proj in Main.ActiveProjectiles)
            {
                if (proj.type == ModContent.ProjectileType<ReversalRedProj>() && proj.owner == player.whoAmI)
				{
					if (proj.ai[0] == 3)
					{
						proj.ai[0] = 1;
					}
					return false;
				}
				else if (proj.type == ModContent.ProjectileType<LapseBlueProj>())
                {
					if (proj.ai[0] != 1)
					{
						return false;
					}
                }
            }

            return true;
		}
	}
}