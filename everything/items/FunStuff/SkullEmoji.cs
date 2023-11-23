using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using tmeogsQOL.everything.proj;

namespace tmeogsQOL.everything.items.FunStuff
{
	public class SkullEmoji : ModItem
	{
		public override void SetDefaults()
		{
			Item.DamageType = DamageClass.Ranged;
			Item.damage = 20600;
			Item.crit = 40;
			Item.knockBack = 5;

			Item.width = 64;
			Item.height = 128;

			Item.useTime = 60;
			Item.useAnimation = 60;
			Item.autoReuse = true;

			Item.useStyle = ItemUseStyleID.Shoot;
			Item.value = 10000;
			Item.rare = ItemRarityID.Purple;
			Item.UseSound = SoundID.Item61;

			Item.shoot = ModContent.ProjectileType<SkullEmojiProj>();
			Item.shootSpeed = 16f;
		}

		public override Vector2? HoldoutOffset() {
			return new Vector2(-75f, -5f);
		}

		public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback) {
				float numberProjectiles = 2;
				float rotation = MathHelper.ToRadians(10);

				position += Vector2.Normalize(velocity) * 45f;

				for (int i = 0; i < numberProjectiles; i++) {
					Vector2 perturbedSpeed = velocity.RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1)));
					Projectile.NewProjectile(source, position, perturbedSpeed, ModContent.ProjectileType<SkullEmojiProj_purple>(), damage / 2, knockback, player.whoAmI);
				}
			return true;
		}
	}
}