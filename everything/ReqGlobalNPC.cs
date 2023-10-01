using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.ItemDropRules;
using tmeogsQOL.everything.items;
using tmeogsQOL.everything.items.BossSummons;
using Microsoft.Xna.Framework;
using Terraria.Localization;
using Terraria.Chat;
using System;

namespace tmeogsQOL.everything
{
	public class ReqGlobalNPC : GlobalNPC
    {
		public override void Load() {
        	NPC.LunarShieldPowerNormal = ModContent.GetInstance<Config>().PillarHP;
    	}

		public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot) {
			if (npc.type == NPCID.SkeletronHead)
				npcLoot.Add(ItemDropRule.Common(ItemID.Bone, 1, 82, 82));
		}
		
		public override void ModifyShop(NPCShop shop){
			
			if (shop.NpcType  == NPCID.Truffle){
				shop.Add(ItemID.GlowingMushroom);
			}

			if (shop.NpcType == NPCID.DD2Bartender){
				shop.Add(new Item(ItemID.DefenderMedal) {shopCustomPrice = 10000});
			}

			if (shop.NpcType == NPCID.Demolitionist){
				shop.Add(ItemID.ScarabBomb);
				shop.Add(new Item(ItemID.Beenade) {shopCustomPrice  = 500}, Condition.DownedQueenBee);
			}

			if (shop.NpcType == NPCID.Merchant){
				shop.Add(ModContent.ItemType<TravelMerchantShopReset>());

				shop.Add(new Item(ItemID.Cobweb) {shopCustomPrice  = 500});

				shop.Add(ItemID.Marshmallow);

				shop.Add(new Item(ItemID.Gel) {shopCustomPrice  = 5});	

				shop.Add(ItemID.RecallPotion);

				shop.Add(ModContent.ItemType<DifficultyChanger>());

				shop.Add(new Item(ItemID.Burger) {shopCustomPrice = 50000}, Condition.DownedEowOrBoc);

				shop.Add(new Item(ItemID.SoulofLight) {shopCustomPrice = 5000}, Condition.Hardmode);
				shop.Add(new Item(ItemID.SoulofNight) {shopCustomPrice = 5000}, Condition.Hardmode);
			}

			if (shop.NpcType == NPCID.Dryad){
				shop.Add(ItemID.Pumpkin);
			}
		}
	}
}