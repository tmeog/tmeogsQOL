using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace tmeogsQOL.everything
{
	public class ReqGlobalItem : GlobalItem
    {
	    public override void SetDefaults(Item item) {
    		
		//----------------------------------------------item changes
			
			if (item.type == ItemID.LifeCrystal) {
        		item.useTime = 15;
				item.useAnimation = 15;
				item.autoReuse = true;
   			}

			if (item.type == ItemID.LifeFruit) {
        		item.useTime = 15;
				item.useAnimation = 15;
				item.autoReuse = true;
   			}

			if (item.type == ItemID.ManaCrystal) {
        		item.useTime = 15;
				item.useAnimation = 15;
				item.autoReuse = true;
   			}

			if (item.type == ItemID.Rope) {
        		item.useTime = 5;
				item.useAnimation = 5;
				item.autoReuse = true;
   			}

			if (item.type == ItemID.VineRope) {
        		item.useTime = 5;
				item.useAnimation = 5;
				item.autoReuse = true;
   			}

			if (item.type == ItemID.WebRope) {
        		item.useTime = 5;
				item.useAnimation = 5;
				item.autoReuse = true;
   			}

			if (item.type == ItemID.SilkRope) {
        		item.useTime = 5;
				item.useAnimation = 5;
				item.autoReuse = true;
   			}

		//----------------------------------------------weapon/tool changes
		
			if (ModContent.GetInstance<Config>().GoodAxe){
				if (item.type == ItemID.CopperAxe){
					item.axe = 100;
					item.useTime = 10;
					item.useAnimation = 10;
					item.tileBoost += 10;
					item.damage = 1;
				}
			}

		//----------------------------------------------events

			if(item.type == ItemID.SnowGlobe){
				item.consumable = false;
			}

			if(item.type == ItemID.BloodMoonStarter){
				item.consumable = false;
			}

			if(item.type == ItemID.PumpkinMoonMedallion){
				item.consumable = false;
			}

			if(item.type == ItemID.NaughtyPresent){
				item.consumable = false;
			}

			if(item.type == ItemID.GoblinBattleStandard){
				item.consumable = false;
			}

			if(item.type == ItemID.SolarTablet){
				item.consumable = false;
			}

			if(item.type == ItemID.PirateMap){
				item.consumable = false;
			}
		}
	}
}