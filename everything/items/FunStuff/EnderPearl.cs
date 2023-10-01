using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.Audio;
using tmeogsQOL.everything.proj;

namespace tmeogsQOL.everything.items.FunStuff
{
	public class EnderPearl : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 128;
			Item.height = 128;
			Item.useTime = 28;
			Item.useAnimation = 28;
			Item.useStyle = 1;
			Item.value = 10000;
			Item.rare = 11;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = false;
			Item.shootSpeed = 28f;
			Item.shoot = ModContent.ProjectileType<EnderPearlProj>();
			Item.consumable = true;
			Item.maxStack = 16;
			Item.noMelee = true;
			Item.noUseGraphic = true;
		}
	}
}