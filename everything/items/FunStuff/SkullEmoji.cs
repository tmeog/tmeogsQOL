using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.Audio;
using tmeogsQOL.everything.proj;

namespace tmeogsQOL.everything.items.FunStuff
{
	public class SkullEmoji : ModItem
	{
		public override void SetDefaults()
		{
			Item.DamageType = DamageClass.Ranged;
			Item.damage = 600;
			Item.crit = 40;
			Item.knockBack = 5;

			Item.width = 64;
			Item.height = 128;

			Item.useTime = 28;
			Item.useAnimation = 28;
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
	}
}