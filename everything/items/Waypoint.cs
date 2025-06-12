using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using tmeogsQOL.everything.proj;
using static System.Net.Mime.MediaTypeNames;

namespace tmeogsQOL.everything.items
{
    public class Waypoint : ModItem
    {
        public Vector2 WaypointPos;
        public bool WaypointSet = false;
        public int projectileID = -1;

        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        //TODO: re-sprite
        //TODO: 2 projectiles, fix that, SDAHHJKLASDHKLJASLK

        public override void SetDefaults()
        {
            Item.width = 64;
            Item.height = 64;
            Item.useTime = 15;
            Item.useAnimation = 15;
            Item.useStyle = ItemUseStyleID.Thrust;
            Item.value = 10000;
            Item.rare = ItemRarityID.Green;
            Item.noMelee = true;
            Item.autoReuse = false;
            Item.consumable = false;
        }

        public override bool AltFunctionUse(Player player)
        {
            return true;
        }

        public override bool CanUseItem(Player player)
        {
            for (int i = 0; i < Main.maxNPCs; i++)
            {
                if (Main.npc[i].active && Main.npc[i].boss)
                {
                    return false;
                }
            }
            return true;
        }

        public override bool? UseItem(Player player)
        {
            if (player.altFunctionUse == 0) //left click
            {
                if (WaypointSet)
                {
                    SoundEngine.PlaySound(new SoundStyle("tmeogsQOL/everything/Sounds/RiftOpenClose") { Volume = 0.75f, Pitch = 0f }, player.Center);
                    int tempPortal = Projectile.NewProjectile(player.GetSource_ItemUse(Item), player.Center.X, player.Center.Y, 0, 0, ModContent.ProjectileType<WaypointProj>(), 0, 0, Main.myPlayer);
                    Main.projectile[tempPortal].timeLeft = 110;
                    player.Teleport(WaypointPos, 1);
                }
            }
            if (player.altFunctionUse == 2) //right click
            { 
                WaypointPos = player.position;
                WaypointSet = true;

                if (projectileID != -1)
                {
                    Main.projectile[projectileID].Kill();
                }
                SoundEngine.PlaySound(new SoundStyle("tmeogsQOL/everything/Sounds/RiftShatter") { Volume = 0.75f, Pitch = 0f }, player.Center);
                projectileID = Projectile.NewProjectile(player.GetSource_ItemUse(Item), player.Center.X, player.Center.Y, 0, 0, ModContent.ProjectileType<WaypointProj>(), 0, 0, Main.myPlayer);
            }
            return true;
        }

        public override void AddRecipes()
        {
			Recipe r = CreateRecipe();
			r.AddIngredient(ItemID.PlatinumBar, 10);
			r.AddIngredient(ItemID.Silk, 20);
            r.AddIngredient(ItemID.Diamond, 5);
            r.AddTile(TileID.Anvils);
			r.Register();

			Recipe r2 = CreateRecipe();
			r2.AddIngredient(ItemID.GoldBar, 10);
			r2.AddIngredient(ItemID.Silk, 20);
            r2.AddIngredient(ItemID.Diamond, 5);
            r2.AddTile(TileID.Anvils);
			r2.Register();
        }
    }
}