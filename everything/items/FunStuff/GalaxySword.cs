using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.Audio;
using tmeogsQOL.everything.proj;

namespace tmeogsQOL.everything.items.FunStuff
{
	public class GalaxySword : ModItem
	{
		int swings = 0;

		public override void SetStaticDefaults()
		{
			Main.RegisterItemAnimation(Item.type, new DrawAnimationVertical(5, 12)); // first is speed(?) second is frames
			ItemID.Sets.AnimatesAsSoul[Item.type] = true;
		}

		public override void SetDefaults()
		{
			Item.DamageType = DamageClass.Melee;
			Item.damage = 600;
			Item.crit = 40;
			Item.knockBack = 5;
			Item.width = 128;
			Item.height = 128;
			Item.useTime = 28;
			Item.useAnimation = 28;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.value = 10000;
			Item.rare = ItemRarityID.Purple;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.shootSpeed = 28f;
			Item.shoot = ProjectileID.None;
		}

		public override bool? UseItem(Player player)
        {
			switch (swings){
				case 0:
					Item.shoot = ModContent.ProjectileType<SunDeathProj>(); // set proj for next swing
					Item.shootSpeed = 7f;
					
					swings++;
					break;
				case 1:
					Item.shoot = ModContent.ProjectileType<StarProj>(); // set proj for next swing
					Item.shootSpeed = 56f;
					swings++;
					break;
				case 2:
					Item.shoot = ModContent.ProjectileType<BlackHoleProj>(); // set proj for next swing
					SoundEngine.PlaySound(SoundID.Item9, player.Center);
					swings++;
					break;
				case 3:
					foreach (NPC npc in Main.npc)
        			{
            			if (npc.active && !npc.friendly && npc.damage > 0 && npc.type != NPCID.CultistTablet){
            			    Vector2 pullDirection = (player.Center - npc.Center).SafeNormalize(Vector2.Zero);
            			    npc.velocity = pullDirection * 10f;
            			}
        			}
					SoundEngine.PlaySound(new SoundStyle("tmeogsQOL/everything/Sounds/BlackHole") { Volume = 0.5f, Pitch = 0f }, player.Center);
					Item.shoot = ModContent.ProjectileType<SwordSwingProj>(); // set proj for next swing
					swings = 0;
					break;
			}
			return true;
		}

		public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback) {
			if (type == ModContent.ProjectileType<StarProj>()){
				float numberProjectiles = 3;
				float rotation = MathHelper.ToRadians(25);
				position += Vector2.Normalize(velocity) * 45f;
				for (int i = 0; i < numberProjectiles; i++) {
					Vector2 perturbedSpeed = velocity.RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .2f;
					Projectile.NewProjectile(source, position, perturbedSpeed, type, damage, knockback, player.whoAmI);
				}
			} else {
				Projectile.NewProjectile(source, position, velocity, type, damage, knockback, player.whoAmI);
			}
			return false;
		}
	}
}