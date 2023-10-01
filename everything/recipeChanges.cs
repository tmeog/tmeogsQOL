using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using tmeogsQOL.everything.items.BossSummons;

namespace tmeogsQOL.everything
{
	public class recipeChanges : ModSystem
	{
		public static RecipeGroup Watches;
		public static RecipeGroup Flowers;
		public static RecipeGroup Graves;
		public override void Unload() {
			Watches = null;
			Flowers = null;
			Graves = null;
		}

		public override void PostAddRecipes(){
			for (int i = 0; i < Main.recipe.Length; i++){
				switch (Main.recipe[i].createItem.type)
				{
					case ItemID.FragmentSolar:
						if (Main.recipe[i].HasIngredient(ItemID.FragmentNebula) && Main.recipe[i].HasIngredient(ItemID.FragmentVortex) && Main.recipe[i].HasIngredient(ItemID.FragmentStardust)){
							Main.recipe[i].DisableRecipe();
						}
						break;
					case ItemID.FragmentNebula:
						if (Main.recipe[i].HasIngredient(ItemID.FragmentSolar) && Main.recipe[i].HasIngredient(ItemID.FragmentVortex) && Main.recipe[i].HasIngredient(ItemID.FragmentStardust)){
							Main.recipe[i].DisableRecipe();
						}
						break;
					case ItemID.FragmentVortex:
						if (Main.recipe[i].HasIngredient(ItemID.FragmentNebula) && Main.recipe[i].HasIngredient(ItemID.FragmentSolar) && Main.recipe[i].HasIngredient(ItemID.FragmentStardust)){
							Main.recipe[i].DisableRecipe();
						}
						break;
					case ItemID.FragmentStardust:
						if (Main.recipe[i].HasIngredient(ItemID.FragmentNebula) && Main.recipe[i].HasIngredient(ItemID.FragmentVortex) && Main.recipe[i].HasIngredient(ItemID.FragmentSolar)){
							Main.recipe[i].DisableRecipe();
						}
						break;
				}
			}
		}

		public override void AddRecipeGroups() {
			Watches = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.GoldWatch)}",
				ItemID.CopperWatch, ItemID.SilverWatch, ItemID.TinWatch, ItemID.TungstenWatch, ItemID.PlatinumWatch, ItemID.GoldWatch);

			RecipeGroup.RegisterGroup("tmeogsQOL:GoldWatch", Watches);

			Flowers = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.Daybloom)}",
				ItemID.Moonglow, ItemID.Daybloom, ItemID.Blinkroot, ItemID.Waterleaf, ItemID.Deathweed, ItemID.Fireblossom, ItemID.Shiverthorn);

			RecipeGroup.RegisterGroup("tmeogsQOL:Daybloom", Flowers);

			Graves = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.Tombstone)}",
				ItemID.Tombstone, ItemID.GraveMarker, ItemID.CrossGraveMarker, ItemID.Headstone, ItemID.Gravestone, ItemID.Obelisk, ItemID.RichGravestone1, ItemID.RichGravestone2, ItemID.RichGravestone3, ItemID.RichGravestone4, ItemID.RichGravestone5);

			RecipeGroup.RegisterGroup("tmeogsQOL:Graves", Graves);
		}

		public override void AddRecipes()
		{
			
			//pre-hardmode ores------------------------------------------------------------------------------------------

			Recipe Leadore = Recipe.Create(ItemID.LeadOre);
			Leadore.AddIngredient(ItemID.IronOre);
			Leadore.AddTile(TileID.WorkBenches);
			Leadore.Register();

			Recipe IronOre = Recipe.Create(ItemID.IronOre);
			IronOre.AddIngredient(ItemID.LeadOre);
			IronOre.AddTile(TileID.WorkBenches);
            IronOre.Register();

			Recipe CopperOre = Recipe.Create(ItemID.CopperOre);
			CopperOre.AddIngredient(ItemID.TinOre);
			CopperOre.AddTile(TileID.WorkBenches);
            CopperOre.Register();

			Recipe TinOre = Recipe.Create(ItemID.TinOre);
			TinOre.AddIngredient(ItemID.CopperOre);
			TinOre.AddTile(TileID.WorkBenches);
            TinOre.Register();

			Recipe SilverOre = Recipe.Create(ItemID.SilverOre);
			SilverOre.AddIngredient(ItemID.TungstenOre);
			SilverOre.AddTile(TileID.WorkBenches);
            SilverOre.Register();

			Recipe TungstenOre = Recipe.Create(ItemID.TungstenOre);
			TungstenOre.AddIngredient(ItemID.SilverOre);
			TungstenOre.AddTile(TileID.WorkBenches);
            TungstenOre.Register();

			Recipe GoldOre = Recipe.Create(ItemID.GoldOre);
			GoldOre.AddIngredient(ItemID.PlatinumOre);
			GoldOre.AddTile(TileID.WorkBenches);
            GoldOre.Register();

			Recipe PlatinumOre = Recipe.Create(ItemID.PlatinumOre);
			PlatinumOre.AddIngredient(ItemID.GoldOre);
			PlatinumOre.AddTile(TileID.WorkBenches);
            PlatinumOre.Register();

			Recipe CrimtaneOre = Recipe.Create(ItemID.CrimtaneOre);
			CrimtaneOre.AddIngredient(ItemID.DemoniteOre);
			CrimtaneOre.AddTile(TileID.WorkBenches);
            CrimtaneOre.Register();

			Recipe DemoniteOre = Recipe.Create(ItemID.DemoniteOre);
			DemoniteOre.AddIngredient(ItemID.CrimtaneOre);
			DemoniteOre.AddTile(TileID.WorkBenches);
            DemoniteOre.Register();

			//hardmode ores------------------------------------------------------------------------------------------

			Recipe CobaltOre = Recipe.Create(ItemID.CobaltOre);
			CobaltOre.AddIngredient(ItemID.PalladiumOre);
			CobaltOre.AddTile(TileID.WorkBenches);
            CobaltOre.Register();

			Recipe PalladiumOre = Recipe.Create(ItemID.PalladiumOre);
			PalladiumOre.AddIngredient(ItemID.CobaltOre);
			PalladiumOre.AddTile(TileID.WorkBenches);
            PalladiumOre.Register();

			Recipe MythrilOre = Recipe.Create(ItemID.MythrilOre);
			MythrilOre.AddIngredient(ItemID.OrichalcumOre);
			MythrilOre.AddTile(TileID.WorkBenches);
            MythrilOre.Register();

			Recipe OrichalcumOre = Recipe.Create(ItemID.OrichalcumOre);
			OrichalcumOre.AddIngredient(ItemID.MythrilOre);
			OrichalcumOre.AddTile(TileID.WorkBenches);
            OrichalcumOre.Register();
			
			Recipe TitaniumOre = Recipe.Create(ItemID.TitaniumOre);
			TitaniumOre.AddIngredient(ItemID.AdamantiteOre);
			TitaniumOre.AddTile(TileID.WorkBenches);
            TitaniumOre.Register();

			Recipe AdamantiteOre = Recipe.Create(ItemID.AdamantiteOre);
			AdamantiteOre.AddIngredient(ItemID.TitaniumOre);
			AdamantiteOre.AddTile(TileID.WorkBenches);
            AdamantiteOre.Register();

			//pre-hardmode bars------------------------------------------------------------------------------------------

			Recipe LeadBar = Recipe.Create(ItemID.LeadBar);
			LeadBar.AddIngredient(ItemID.IronBar);
			LeadBar.AddTile(TileID.WorkBenches);
            LeadBar.Register();

			Recipe IronBar = Recipe.Create(ItemID.IronBar);
			IronBar.AddIngredient(ItemID.LeadBar);
			IronBar.AddTile(TileID.WorkBenches);
            IronBar.Register();

			Recipe CopperBar = Recipe.Create(ItemID.CopperBar);
			CopperBar.AddIngredient(ItemID.TinBar);
			CopperBar.AddTile(TileID.WorkBenches);
            CopperBar.Register();

			Recipe TinBar = Recipe.Create(ItemID.TinBar);
			TinBar.AddIngredient(ItemID.CopperBar);
			TinBar.AddTile(TileID.WorkBenches);
            TinBar.Register();
				
			Recipe SilverBar = Recipe.Create(ItemID.SilverBar);
			SilverBar.AddIngredient(ItemID.TungstenBar);
			SilverBar.AddTile(TileID.WorkBenches);
            SilverBar.Register();

			Recipe TungstenBar = Recipe.Create(ItemID.TungstenBar);
			TungstenBar.AddIngredient(ItemID.SilverBar);
			TungstenBar.AddTile(TileID.WorkBenches);
            TungstenBar.Register();

			Recipe GoldBar = Recipe.Create(ItemID.GoldBar);
			GoldBar.AddIngredient(ItemID.PlatinumBar);
			GoldBar.AddTile(TileID.WorkBenches);
            GoldBar.Register();

			Recipe PlatinumBar = Recipe.Create(ItemID.PlatinumBar);
			PlatinumBar.AddIngredient(ItemID.GoldBar);
			PlatinumBar.AddTile(TileID.WorkBenches);
            PlatinumBar.Register();

			Recipe CrimtaneBar = Recipe.Create(ItemID.CrimtaneBar);
			CrimtaneBar.AddIngredient(ItemID.DemoniteBar);
			CrimtaneBar.AddTile(TileID.WorkBenches);
            CrimtaneBar.Register();

			Recipe DemoniteBar = Recipe.Create(ItemID.DemoniteBar);
			DemoniteBar.AddIngredient(ItemID.CrimtaneBar);
			DemoniteBar.AddTile(TileID.WorkBenches);
            DemoniteBar.Register();

			//hardmode bars------------------------------------------------------------------------------------------
			
			Recipe CobaltBar = Recipe.Create(ItemID.CobaltBar);
			CobaltBar.AddIngredient(ItemID.PalladiumBar);
			CobaltBar.AddTile(TileID.WorkBenches);
            CobaltBar.Register();

			Recipe PalladiumBar = Recipe.Create(ItemID.PalladiumBar);
			PalladiumBar.AddIngredient(ItemID.CobaltBar);
			PalladiumBar.AddTile(TileID.WorkBenches);
            PalladiumBar.Register();

			Recipe MythrilBar = Recipe.Create(ItemID.MythrilBar);
			MythrilBar.AddIngredient(ItemID.OrichalcumBar);
			MythrilBar.AddTile(TileID.WorkBenches);
            MythrilBar.Register();

			Recipe OrichalcumBar = Recipe.Create(ItemID.OrichalcumBar);
			OrichalcumBar.AddIngredient(ItemID.MythrilBar);
			OrichalcumBar.AddTile(TileID.WorkBenches);
            OrichalcumBar.Register();
			
			Recipe TitaniumBar = Recipe.Create(ItemID.TitaniumBar);
			TitaniumBar.AddIngredient(ItemID.AdamantiteBar);
			TitaniumBar.AddTile(TileID.WorkBenches);
            TitaniumBar.Register();

			Recipe AdamantiteBar = Recipe.Create(ItemID.AdamantiteBar);
			AdamantiteBar.AddIngredient(ItemID.TitaniumBar);
			AdamantiteBar.AddTile(TileID.WorkBenches);
            AdamantiteBar.Register();

			//pre-hardmode items------------------------------------------------------------------------------------------

			Recipe SlimeStaff = Recipe.Create(ItemID.SlimeStaff);
			SlimeStaff.AddIngredient(ItemID.Gel, 20);
            SlimeStaff.AddRecipeGroup("Wood", 10);
			SlimeStaff.AddTile(TileID.WorkBenches);
            SlimeStaff.Register();

			Recipe LifeCrystal = Recipe.Create(ItemID.LifeCrystal);
			LifeCrystal.AddIngredient(ItemID.HeartLantern);
			LifeCrystal.AddTile(TileID.Anvils);
            LifeCrystal.Register();

			Recipe WaterCandle = Recipe.Create(ItemID.WaterCandle);
			WaterCandle.AddIngredient(ItemID.Candle);
			WaterCandle.AddIngredient(ItemID.BottledWater);
			WaterCandle.AddTile(TileID.Bottles);
			WaterCandle.Register();

			Recipe WaterCandle2 = Recipe.Create(ItemID.WaterCandle);
			WaterCandle2.AddIngredient(ItemID.PlatinumCandle);
			WaterCandle2.AddIngredient(ItemID.BottledWater);
			WaterCandle2.AddTile(TileID.Bottles);
			WaterCandle2.Register();

			Recipe WaterCandle3 = Recipe.Create(ItemID.WaterCandle);
			WaterCandle3.AddIngredient(ItemID.Candle);
			WaterCandle3.AddCondition(Condition.NearWater);
			WaterCandle3.Register();

			Recipe WaterCandle4 = Recipe.Create(ItemID.WaterCandle);
			WaterCandle4.AddIngredient(ItemID.PlatinumCandle);
			WaterCandle4.AddCondition(Condition.NearWater);
			WaterCandle4.Register();

			Recipe Shadewood = Recipe.Create(ItemID.Shadewood);
			Shadewood.AddIngredient(ItemID.Ebonwood);
			Shadewood.AddTile(TileID.WorkBenches);
			Shadewood.Register();

			Recipe Ebonwood = Recipe.Create(ItemID.Ebonwood);
			Ebonwood.AddIngredient(ItemID.Shadewood);
			Ebonwood.AddTile(TileID.WorkBenches);
			Ebonwood.Register();

			Recipe CrimstoneBlock = Recipe.Create(ItemID.CrimstoneBlock);
			CrimstoneBlock.AddIngredient(ItemID.EbonstoneBlock);
			CrimstoneBlock.AddTile(TileID.WorkBenches);
			CrimstoneBlock.Register();

			Recipe EbonstoneBlock = Recipe.Create(ItemID.EbonstoneBlock);
			EbonstoneBlock.AddIngredient(ItemID.CrimstoneBlock);
			EbonstoneBlock.AddTile(TileID.WorkBenches);
			EbonstoneBlock.Register();

			Recipe Extractinator = Recipe.Create(ItemID.Extractinator);
			Extractinator.AddIngredient(ItemID.StoneBlock, 50);
			Extractinator.AddRecipeGroup("IronBar", 5);
			Extractinator.AddTile(TileID.Anvils);
			Extractinator.Register();

			Recipe LifeCrystal2 = Recipe.Create(ItemID.LifeCrystal);
			LifeCrystal2.AddIngredient(ItemID.StoneBlock, 30);
			LifeCrystal2.AddIngredient(ItemID.LesserHealingPotion, 3);
			LifeCrystal2.AddTile(TileID.WorkBenches);
			LifeCrystal2.Register();

			Recipe magicMirror = Recipe.Create(ItemID.MagicMirror);
			magicMirror.AddRecipeGroup("IronBar", 10);
			magicMirror.AddIngredient(ItemID.Glass, 10);
			magicMirror.AddIngredient(ItemID.FallenStar);
			magicMirror.Register();

			Recipe GuideVoodooDoll = Recipe.Create(ItemID.GuideVoodooDoll);
			GuideVoodooDoll.AddIngredient(ItemID.Silk, 10);
			GuideVoodooDoll.AddTile(TileID.Anvils);
			GuideVoodooDoll.Register();

			Recipe hermesBoots = Recipe.Create(ItemID.HermesBoots);
			hermesBoots.AddIngredient(ItemID.Silk, 5);
			hermesBoots.AddRecipeGroup("IronBar", 10);
			hermesBoots.AddTile(TileID.Anvils);
			hermesBoots.Register();

			Recipe blackLens = Recipe.Create(ItemID.BlackLens);
			blackLens.AddIngredient(ItemID.Lens);
			blackLens.AddIngredient(ItemID.BlackInk);
			blackLens.Register();

			Recipe waterTornado = Recipe.Create(ItemID.TsunamiInABottle);
			waterTornado.AddIngredient(ItemID.BottledWater);
			waterTornado.AddIngredient(ItemID.WaterBucket);
			waterTornado.AddCondition(Condition.NearWater);
			waterTornado.AddTile(TileID.Bottles);
			waterTornado.Register();

			Recipe fishBalloon1 = Recipe.Create(ItemID.BalloonPufferfish);
			fishBalloon1.AddIngredient(ItemID.ShinyRedBalloon);
			fishBalloon1.AddIngredient(ItemID.Tuna);
			fishBalloon1.Register();

			Recipe fishBalloon2 = Recipe.Create(ItemID.BalloonPufferfish);
			fishBalloon2.AddIngredient(ItemID.ShinyRedBalloon);
			fishBalloon2.AddIngredient(ItemID.Trout);
			fishBalloon2.Register();

			Recipe fishBalloon3 = Recipe.Create(ItemID.BalloonPufferfish);
			fishBalloon3.AddIngredient(ItemID.ShinyRedBalloon);
			fishBalloon3.AddIngredient(ItemID.Bass);
			fishBalloon3.Register();

			Recipe cloudBottle = Recipe.Create(ItemID.CloudinaBottle);
			cloudBottle.AddIngredient(ItemID.Cloud, 30);
			cloudBottle.AddIngredient(ItemID.Bottle);
			cloudBottle.Register();

			Recipe blizzardBottle = Recipe.Create(ItemID.BlizzardinaBottle);
			blizzardBottle.AddIngredient(ItemID.SnowBlock, 30);
			blizzardBottle.AddIngredient(ItemID.Bottle);
			blizzardBottle.Register();

			Recipe SandBottle = Recipe.Create(ItemID.SandstorminaBottle);
			SandBottle.AddIngredient(ItemID.SandBlock, 30);
			SandBottle.AddIngredient(ItemID.Bottle);
			SandBottle.Register();

			Recipe balloon = Recipe.Create(ItemID.ShinyRedBalloon);
			balloon.AddIngredient(ItemID.Cloud, 20);
			balloon.AddIngredient(ItemID.Gel, 20);
			balloon.AddIngredient(ItemID.Rope);
			balloon.AddTile(TileID.WorkBenches);
			balloon.Register();

			Recipe ezWings = Recipe.Create(ItemID.CreativeWings);
			ezWings.AddIngredient(ItemID.Feather, 20);
			ezWings.AddIngredient(ItemID.Cloud, 10);
			ezWings.AddIngredient(ItemID.LuckyHorseshoe);
			ezWings.AddTile(TileID.Anvils);
			ezWings.Register();

			Recipe moneyTrough = Recipe.Create(ItemID.MoneyTrough);
			moneyTrough.AddIngredient(ItemID.PiggyBank);
			moneyTrough.AddIngredient(ItemID.GoldCoin, 5);
			moneyTrough.AddTile(TileID.Anvils);
			moneyTrough.Register();

			Recipe shadowScale = Recipe.Create(ItemID.ShadowScale);
			shadowScale.AddIngredient(ItemID.TissueSample);
			shadowScale.AddTile(TileID.WorkBenches);
            shadowScale.Register();

			Recipe tissueSample = Recipe.Create(ItemID.TissueSample);
			tissueSample.AddIngredient(ItemID.ShadowScale);
			tissueSample.AddTile(TileID.WorkBenches);
            tissueSample.Register();
			
			Recipe goldkey1 = Recipe.Create(ItemID.GoldenKey);
			goldkey1.AddIngredient(ItemID.GoldBar, 5);
			goldkey1.AddTile(TileID.Anvils);
            goldkey1.Register();

			Recipe goldkey2 = Recipe.Create(ItemID.GoldenKey);
			goldkey2.AddIngredient(ItemID.PlatinumBar, 5);
			goldkey2.AddTile(TileID.Anvils);
            goldkey2.Register();

			Recipe chum = Recipe.Create(ItemID.ChumBucket);
			chum.AddIngredient(ItemID.Worm, 3);
			chum.AddIngredient(ItemID.EmptyBucket);
            chum.Register();

			Recipe fartThing = Recipe.Create(ItemID.WhoopieCushion);
			fartThing.AddIngredient(ItemID.Silk, 5);
			fartThing.AddIngredient(ItemID.Cloud, 20);
            fartThing.Register();

			Recipe duneriders = Recipe.Create(ItemID.SandBoots);
			duneriders.AddIngredient(ItemID.HermesBoots);
			duneriders.AddIngredient(ItemID.SandBlock, 50);
			duneriders.AddTile(TileID.Anvils);
			duneriders.Register();

			Recipe cobaltShield1 = Recipe.Create(ItemID.CobaltShield);
			cobaltShield1.AddIngredient(ItemID.CobaltBar, 10);
			cobaltShield1.AddTile(TileID.Anvils);
			cobaltShield1.Register();

			Recipe cobaltShield2 = Recipe.Create(ItemID.CobaltShield);
			cobaltShield2.AddIngredient(ItemID.PalladiumBar, 10);
			cobaltShield2.AddTile(TileID.Anvils);
			cobaltShield2.Register();

			Recipe luckyHorse1 = Recipe.Create(ItemID.LuckyHorseshoe);
			luckyHorse1.AddIngredient(ItemID.GoldBar, 8);
			luckyHorse1.AddTile(TileID.Anvils);
			luckyHorse1.Register();

			Recipe luckyHorse2 = Recipe.Create(ItemID.LuckyHorseshoe);
			luckyHorse2.AddIngredient(ItemID.PlatinumBar, 8);
			luckyHorse2.AddTile(TileID.Anvils);
			luckyHorse2.Register();

			Recipe aglet = Recipe.Create(ItemID.Aglet);
			aglet.AddRecipeGroup("IronBar");
			aglet.AddTile(TileID.Anvils);
			aglet.Register();
			
			Recipe enchantedSword1 = Recipe.Create(ItemID.EnchantedSword);
			enchantedSword1.AddIngredient(ItemID.FallenStar, 5);
			enchantedSword1.AddIngredient(ItemID.GoldBroadsword);
			enchantedSword1.Register();

			Recipe enchantedSword2 = Recipe.Create(ItemID.EnchantedSword);
			enchantedSword2.AddIngredient(ItemID.FallenStar, 5);
			enchantedSword2.AddIngredient(ItemID.PlatinumBroadsword);
			enchantedSword2.Register();

			Recipe armySpawn = Recipe.Create(ItemID.GoblinBattleStandard);
			armySpawn.AddIngredient(ItemID.Silk, 10);
			armySpawn.AddRecipeGroup("Wood", 5);
			armySpawn.AddTile(TileID.Anvils);
			armySpawn.Register();

			Recipe shuriken = Recipe.Create(ItemID.Shuriken, 50);
			shuriken.AddRecipeGroup("IronBar");
			shuriken.AddTile(TileID.Anvils);
			shuriken.Register();

			Recipe knife = Recipe.Create(ItemID.ThrowingKnife, 50);
			knife.AddRecipeGroup("IronBar");
			knife.AddTile(TileID.Anvils);
			knife.Register();

			Recipe flyingCarpet1 = Recipe.Create(ItemID.FlyingCarpet);
			flyingCarpet1.AddIngredient(ItemID.Silk, 5);
			flyingCarpet1.AddIngredient(ItemID.FallenStar, 3);
			flyingCarpet1.Register();

			Recipe flyingCarpet2 = Recipe.Create(ItemID.FlyingCarpet);
			flyingCarpet2.AddIngredient(ItemID.PharaohsMask);
			flyingCarpet2.AddIngredient(ItemID.PharaohsRobe);
			flyingCarpet2.Register();

			Recipe king = Recipe.Create(ItemID.KingStatue);
			king.AddIngredient(ItemID.StoneBlock, 20);
			king.AddTile(TileID.HeavyWorkBench);
			king.Register();

			Recipe queen = Recipe.Create(ItemID.QueenStatue);
			queen.AddIngredient(ItemID.StoneBlock, 20);
			queen.AddTile(TileID.HeavyWorkBench);
			queen.Register();

			Recipe corruptSeeds = Recipe.Create(ItemID.CorruptSeeds);
			corruptSeeds.AddIngredient(ItemID.CrimsonSeeds);
			corruptSeeds.AddTile(TileID.WorkBenches);
            corruptSeeds.Register();

			Recipe crimSeeds = Recipe.Create(ItemID.CrimsonSeeds);
			crimSeeds.AddIngredient(ItemID.CorruptSeeds);
			crimSeeds.AddTile(TileID.WorkBenches);
            crimSeeds.Register();

			Recipe burger1 = Recipe.Create(ItemID.Burger);
			burger1.AddIngredient(ItemID.RottenChunk, 20);
            burger1.Register();

			Recipe burger2 = Recipe.Create(ItemID.Burger);
			burger2.AddIngredient(ItemID.Vertebrae, 20);
            burger2.Register();

			Recipe shoe = Recipe.Create(ItemID.ShoeSpikes);
			shoe.AddIngredient(ItemID.ClimbingClaws);
			shoe.AddTile(TileID.WorkBenches);
            shoe.Register();
			
			Recipe claw = Recipe.Create(ItemID.ClimbingClaws);
			claw.AddIngredient(ItemID.ShoeSpikes);
			claw.AddTile(TileID.WorkBenches);
            claw.Register();

			Recipe bast = Recipe.Create(ItemID.CatBast);
			bast.AddRecipeGroup("IronBar", 10);
			bast.AddTile(TileID.HeavyWorkBench);
            bast.Register();

			Recipe radar = Recipe.Create(ItemID.Radar);
			radar.AddRecipeGroup("IronBar", 3);
			radar.AddTile(TileID.Anvils);
            radar.Register();

			Recipe arkalis = Recipe.Create(ItemID.Arkhalis);
			arkalis.AddIngredient(ItemID.GoldBar, 3);
			arkalis.AddIngredient(ItemID.EnchantedSword);
			arkalis.AddTile(TileID.Anvils);
            arkalis.Register();

			Recipe arkalis2 = Recipe.Create(ItemID.Arkhalis);
			arkalis2.AddIngredient(ItemID.PlatinumBar, 3);
			arkalis2.AddIngredient(ItemID.EnchantedSword);
			arkalis2.AddTile(TileID.Anvils);
            arkalis2.Register();

			Recipe jungleAglet = Recipe.Create(ItemID.AnkletoftheWind);
			jungleAglet.AddIngredient(ItemID.Vine, 2);
			jungleAglet.AddIngredient(ItemID.ManaCrystal);
			jungleAglet.AddTile(TileID.Anvils);
            jungleAglet.Register();

			Recipe Starpower = Recipe.Create(ItemID.BandofStarpower);
			Starpower.AddIngredient(ItemID.Chain);
			Starpower.AddIngredient(ItemID.ManaCrystal);
			Starpower.AddTile(TileID.WorkBenches);
            Starpower.Register();

			Recipe BandofRegen = Recipe.Create(ItemID.BandofRegeneration);
			BandofRegen.AddIngredient(ItemID.Chain);
			BandofRegen.AddIngredient(ItemID.LifeCrystal);
			BandofRegen.AddTile(TileID.WorkBenches);
            BandofRegen.Register();

			Recipe FlowerBoots = Recipe.Create(ItemID.FlowerBoots);
			FlowerBoots.AddRecipeGroup(Flowers, 5);
			FlowerBoots.AddTile(TileID.Anvils);
            FlowerBoots.Register();

			Recipe NaturesGift = Recipe.Create(ItemID.NaturesGift);
			NaturesGift.AddIngredient(ItemID.JungleRose);
			NaturesGift.AddIngredient(ItemID.ManaCrystal);
			NaturesGift.AddTile(TileID.WorkBenches);
            NaturesGift.Register();

			Recipe IceSkates = Recipe.Create(ItemID.IceSkates);
			IceSkates.AddIngredient(ItemID.IceBlock, 20);
			IceSkates.AddIngredient(ItemID.Silk, 10);
			IceSkates.AddIngredient(ItemID.IronBar);
			IceSkates.AddTile(TileID.Anvils);
            IceSkates.Register();

			//hardmode items------------------------------------------------------------------------------------------

			Recipe RodofDiscord = Recipe.Create(ItemID.RodofDiscord);
			RodofDiscord.AddIngredient(ItemID.TitaniumBar, 15);
			RodofDiscord.AddIngredient(ItemID.SoulofLight, 30);
			RodofDiscord.AddIngredient(ItemID.PixieDust, 50);
            RodofDiscord.AddTile(TileID.MythrilAnvil);
            RodofDiscord.Register();

			Recipe ShadowKey = Recipe.Create(ItemID.ShadowKey);
			ShadowKey.AddIngredient(ItemID.GoldenKey);
            ShadowKey.AddIngredient(ItemID.Obsidian, 20);
			ShadowKey.AddIngredient(ItemID.Bone);
			ShadowKey.AddTile(TileID.Anvils);
            ShadowKey.Register();

			Recipe rangerEmblem1 = Recipe.Create(ItemID.RangerEmblem);
			rangerEmblem1.AddIngredient(ItemID.WarriorEmblem);
			rangerEmblem1.AddTile(TileID.WorkBenches);
            rangerEmblem1.Register();

			Recipe rangerEmblem2 = Recipe.Create(ItemID.RangerEmblem);
			rangerEmblem2.AddIngredient(ItemID.SummonerEmblem);
			rangerEmblem2.AddTile(TileID.WorkBenches);
            rangerEmblem2.Register();

			Recipe rangerEmblem3 = Recipe.Create(ItemID.RangerEmblem);
			rangerEmblem3.AddIngredient(ItemID.SorcererEmblem);
			rangerEmblem3.AddTile(TileID.WorkBenches);
            rangerEmblem3.Register();

			Recipe warriorEmblem1 = Recipe.Create(ItemID.WarriorEmblem);
			warriorEmblem1.AddIngredient(ItemID.SummonerEmblem);
			warriorEmblem1.AddTile(TileID.WorkBenches);
            warriorEmblem1.Register();

			Recipe warriorEmblem2 = Recipe.Create(ItemID.WarriorEmblem);
			warriorEmblem2.AddIngredient(ItemID.SorcererEmblem);
			warriorEmblem2.AddTile(TileID.WorkBenches);
            warriorEmblem2.Register();

			Recipe warriorEmblem3 = Recipe.Create(ItemID.WarriorEmblem);
			warriorEmblem3.AddIngredient(ItemID.RangerEmblem);
			warriorEmblem3.AddTile(TileID.WorkBenches);
            warriorEmblem3.Register();

			Recipe summonerEmblem1 = Recipe.Create(ItemID.SummonerEmblem);
			summonerEmblem1.AddIngredient(ItemID.WarriorEmblem);
			summonerEmblem1.AddTile(TileID.WorkBenches);
            summonerEmblem1.Register();

			Recipe summonerEmblem2 = Recipe.Create(ItemID.SummonerEmblem);
			summonerEmblem2.AddIngredient(ItemID.SorcererEmblem);
			summonerEmblem2.AddTile(TileID.WorkBenches);
            summonerEmblem2.Register();

			Recipe summonerEmblem3 = Recipe.Create(ItemID.SummonerEmblem);
			summonerEmblem3.AddIngredient(ItemID.RangerEmblem);
			summonerEmblem3.AddTile(TileID.WorkBenches);
            summonerEmblem3.Register();

			Recipe sorcererEmblem1 = Recipe.Create(ItemID.SorcererEmblem);
			sorcererEmblem1.AddIngredient(ItemID.WarriorEmblem);
			sorcererEmblem1.AddTile(TileID.WorkBenches);
            sorcererEmblem1.Register();

			Recipe sorcererEmblem2 = Recipe.Create(ItemID.SorcererEmblem);
			sorcererEmblem2.AddIngredient(ItemID.SummonerEmblem);
			sorcererEmblem2.AddTile(TileID.WorkBenches);
            sorcererEmblem2.Register();

			Recipe sorcererEmblem3 = Recipe.Create(ItemID.SorcererEmblem);
			sorcererEmblem3.AddIngredient(ItemID.RangerEmblem);
			sorcererEmblem3.AddTile(TileID.WorkBenches);
            sorcererEmblem3.Register();

			Recipe lifeFruit = Recipe.Create(ItemID.LifeFruit);
			lifeFruit.AddIngredient(ItemID.LifeCrystal);
			lifeFruit.AddIngredient(ItemID.HallowedBar);
			lifeFruit.AddIngredient(ItemID.LesserHealingPotion, 3);
			lifeFruit.AddTile(TileID.MythrilAnvil);
			lifeFruit.Register();

			Recipe shinyButterfly = Recipe.Create(ItemID.EmpressButterfly);
			shinyButterfly.AddRecipeGroup("Butterflies");
			shinyButterfly.AddIngredient(ItemID.CrystalShard);
			shinyButterfly.AddTile(TileID.MythrilAnvil);
			shinyButterfly.Register();

			Recipe truffleWorm = Recipe.Create(ItemID.TruffleWorm);
			truffleWorm.AddIngredient(ItemID.Worm);
			truffleWorm.AddIngredient(ItemID.GlowingMushroom, 50);
			truffleWorm.AddTile(TileID.MythrilAnvil);
			truffleWorm.Register();

			Recipe giantFeather = Recipe.Create(ItemID.GiantHarpyFeather);
			giantFeather.AddIngredient(ItemID.Feather, 100);
			giantFeather.AddTile(TileID.MythrilAnvil);
			giantFeather.Register();

			Recipe vortex1 = Recipe.Create(ItemID.FragmentVortex);
			vortex1.AddIngredient(ItemID.FragmentNebula);
			vortex1.AddTile(TileID.WorkBenches);
            vortex1.Register();

			Recipe vortex2 = Recipe.Create(ItemID.FragmentVortex);
			vortex2.AddIngredient(ItemID.FragmentSolar);
			vortex2.AddTile(TileID.WorkBenches);
            vortex2.Register();

			Recipe vortex3 = Recipe.Create(ItemID.FragmentVortex);
			vortex3.AddIngredient(ItemID.FragmentStardust);
			vortex3.AddTile(TileID.WorkBenches);
            vortex3.Register();

			Recipe Solar1 = Recipe.Create(ItemID.FragmentSolar);
			Solar1.AddIngredient(ItemID.FragmentVortex);
			Solar1.AddTile(TileID.WorkBenches);
            Solar1.Register();

			Recipe Solar2 = Recipe.Create(ItemID.FragmentSolar);
			Solar2.AddIngredient(ItemID.FragmentStardust);
			Solar2.AddTile(TileID.WorkBenches);
            Solar2.Register();

			Recipe Solar3 = Recipe.Create(ItemID.FragmentSolar);
			Solar3.AddIngredient(ItemID.FragmentNebula);
			Solar3.AddTile(TileID.WorkBenches);
            Solar3.Register();

			Recipe Stardust1 = Recipe.Create(ItemID.FragmentStardust);
			Stardust1.AddIngredient(ItemID.FragmentNebula);
			Stardust1.AddTile(TileID.WorkBenches);
            Stardust1.Register();

			Recipe Stardust2 = Recipe.Create(ItemID.FragmentStardust);
			Stardust2.AddIngredient(ItemID.FragmentVortex);
			Stardust2.AddTile(TileID.WorkBenches);
            Stardust2.Register();

			Recipe Stardust3 = Recipe.Create(ItemID.FragmentStardust);
			Stardust3.AddIngredient(ItemID.FragmentSolar);
			Stardust3.AddTile(TileID.WorkBenches);
            Stardust3.Register();

			Recipe Nebula1 = Recipe.Create(ItemID.FragmentNebula);
			Nebula1.AddIngredient(ItemID.FragmentStardust);
			Nebula1.AddTile(TileID.WorkBenches);
            Nebula1.Register();

			Recipe Nebula2 = Recipe.Create(ItemID.FragmentNebula);
			Nebula2.AddIngredient(ItemID.FragmentSolar);
			Nebula2.AddTile(TileID.WorkBenches);
            Nebula2.Register();

			Recipe Nebula3 = Recipe.Create(ItemID.FragmentNebula);
			Nebula3.AddIngredient(ItemID.FragmentVortex);
			Nebula3.AddTile(TileID.WorkBenches);
            Nebula3.Register();

			Recipe Light = Recipe.Create(ItemID.SoulofLight);
			Light.AddIngredient(ItemID.SoulofNight);
			Light.AddTile(TileID.WorkBenches);
            Light.Register();

			Recipe Night = Recipe.Create(ItemID.SoulofNight);
			Night.AddIngredient(ItemID.SoulofLight);
			Night.AddTile(TileID.WorkBenches);
            Night.Register();

			Recipe powerCell = Recipe.Create(ItemID.LihzahrdPowerCell);
			powerCell.AddIngredient(ItemID.LunarTabletFragment, 2);
			powerCell.AddIngredient(ItemID.Glass, 5);
			powerCell.AddIngredient(ItemID.FallenStar, 3);
			powerCell.AddTile(TileID.MythrilAnvil);
            powerCell.Register();

			Recipe tabi = Recipe.Create(ItemID.Tabi);
			tabi.AddIngredient(ItemID.BlackBelt);
			tabi.AddTile(TileID.WorkBenches);
			tabi.Register();

			Recipe blackBelt = Recipe.Create(ItemID.BlackBelt);
			blackBelt.AddIngredient(ItemID.Tabi);
			blackBelt.AddTile(TileID.WorkBenches);
			blackBelt.Register();

			Recipe boneFeather = Recipe.Create(ItemID.BoneFeather);
			boneFeather.AddIngredient(ItemID.Bone, 100);
			boneFeather.AddTile(TileID.MythrilAnvil);
			boneFeather.Register();	

			Recipe paladinsShield1 = Recipe.Create(ItemID.PaladinsShield);
			paladinsShield1.AddIngredient(ItemID.CobaltShield);
			paladinsShield1.AddIngredient(ItemID.Ectoplasm, 10);
			paladinsShield1.AddIngredient(ItemID.PlatinumBar, 10);
			paladinsShield1.AddTile(TileID.MythrilAnvil);
			paladinsShield1.Register();

			Recipe paladinsShield2 = Recipe.Create(ItemID.PaladinsShield);
			paladinsShield2.AddIngredient(ItemID.CobaltShield);
			paladinsShield2.AddIngredient(ItemID.Ectoplasm, 10);
			paladinsShield2.AddIngredient(ItemID.GoldBar, 10);
			paladinsShield2.AddTile(TileID.MythrilAnvil);
			paladinsShield2.Register();

			Recipe jungleKey1 = Recipe.Create(ItemID.JungleKey);
			jungleKey1.AddIngredient(ItemID.CorruptionKey);
			jungleKey1.AddTile(TileID.WorkBenches);
			jungleKey1.Register();

			Recipe jungleKey2 = Recipe.Create(ItemID.JungleKey);
			jungleKey2.AddIngredient(ItemID.CrimsonKey);
			jungleKey2.AddTile(TileID.WorkBenches);
			jungleKey2.Register();

			Recipe jungleKey3 = Recipe.Create(ItemID.JungleKey);
			jungleKey3.AddIngredient(ItemID.HallowedKey);
			jungleKey3.AddTile(TileID.WorkBenches);
			jungleKey3.Register();

			Recipe jungleKey4 = Recipe.Create(ItemID.JungleKey);
			jungleKey4.AddIngredient(ItemID.FrozenKey);
			jungleKey4.AddTile(TileID.WorkBenches);
			jungleKey4.Register();

			Recipe jungleKey5 = Recipe.Create(ItemID.JungleKey);
			jungleKey5.AddIngredient(ItemID.DungeonDesertKey);
			jungleKey5.AddTile(TileID.WorkBenches);
			jungleKey5.Register();

			Recipe corruptionKey1 = Recipe.Create(ItemID.CorruptionKey);
			corruptionKey1.AddIngredient(ItemID.JungleKey);
			corruptionKey1.AddTile(TileID.WorkBenches);
			corruptionKey1.Register();

			Recipe corruptionKey2 = Recipe.Create(ItemID.CorruptionKey);
			corruptionKey2.AddIngredient(ItemID.HallowedKey);
			corruptionKey2.AddTile(TileID.WorkBenches);
			corruptionKey2.Register();

			Recipe corruptionKey3 = Recipe.Create(ItemID.CorruptionKey);
			corruptionKey3.AddIngredient(ItemID.FrozenKey);
			corruptionKey3.AddTile(TileID.WorkBenches);
			corruptionKey3.Register();

			Recipe corruptionKey4 = Recipe.Create(ItemID.CorruptionKey);
			corruptionKey4.AddIngredient(ItemID.CrimsonKey);
			corruptionKey4.AddTile(TileID.WorkBenches);
			corruptionKey4.Register();

			Recipe corruptionKey5 = Recipe.Create(ItemID.CorruptionKey);
			corruptionKey5.AddIngredient(ItemID.DungeonDesertKey);
			corruptionKey5.AddTile(TileID.WorkBenches);
			corruptionKey5.Register();

			Recipe crimsonKey1 = Recipe.Create(ItemID.CrimsonKey);
			crimsonKey1.AddIngredient(ItemID.JungleKey);
			crimsonKey1.AddTile(TileID.WorkBenches);
			crimsonKey1.Register();

			Recipe crimsonKey2 = Recipe.Create(ItemID.CrimsonKey);
			crimsonKey2.AddIngredient(ItemID.CorruptionKey);
			crimsonKey2.AddTile(TileID.WorkBenches);
			crimsonKey2.Register();

			Recipe crimsonKey3 = Recipe.Create(ItemID.CrimsonKey);
			crimsonKey3.AddIngredient(ItemID.HallowedKey);
			crimsonKey3.AddTile(TileID.WorkBenches);
			crimsonKey3.Register();

			Recipe crimsonKey4 = Recipe.Create(ItemID.CrimsonKey);
			crimsonKey4.AddIngredient(ItemID.FrozenKey);
			crimsonKey4.AddTile(TileID.WorkBenches);
			crimsonKey4.Register();

			Recipe crimsonKey5 = Recipe.Create(ItemID.CrimsonKey);
			crimsonKey5.AddIngredient(ItemID.DungeonDesertKey);
			crimsonKey5.AddTile(TileID.WorkBenches);
			crimsonKey5.Register();

			Recipe hallowedKey1 = Recipe.Create(ItemID.HallowedKey);
			hallowedKey1.AddIngredient(ItemID.JungleKey);
			hallowedKey1.AddTile(TileID.WorkBenches);
			hallowedKey1.Register();

			Recipe hallowedKey2 = Recipe.Create(ItemID.HallowedKey);
			hallowedKey2.AddIngredient(ItemID.CorruptionKey);
			hallowedKey2.AddTile(TileID.WorkBenches);
			hallowedKey2.Register();

			Recipe hallowedKey3 = Recipe.Create(ItemID.HallowedKey);
			hallowedKey3.AddIngredient(ItemID.CrimsonKey);
			hallowedKey3.AddTile(TileID.WorkBenches);
			hallowedKey3.Register();

			Recipe hallowedKey4 = Recipe.Create(ItemID.HallowedKey);
			hallowedKey4.AddIngredient(ItemID.FrozenKey);
			hallowedKey4.AddTile(TileID.WorkBenches);
			hallowedKey4.Register();

			Recipe hallowedKey5 = Recipe.Create(ItemID.HallowedKey);
			hallowedKey5.AddIngredient(ItemID.DungeonDesertKey);
			hallowedKey5.AddTile(TileID.WorkBenches);
			hallowedKey5.Register();

			Recipe frozenKey1 = Recipe.Create(ItemID.FrozenKey);
			frozenKey1.AddIngredient(ItemID.JungleKey);
			frozenKey1.AddTile(TileID.WorkBenches);
			frozenKey1.Register();

			Recipe frozenKey2 = Recipe.Create(ItemID.FrozenKey);
			frozenKey2.AddIngredient(ItemID.CorruptionKey);
			frozenKey2.AddTile(TileID.WorkBenches);
			frozenKey2.Register();

			Recipe frozenKey3 = Recipe.Create(ItemID.FrozenKey);
			frozenKey3.AddIngredient(ItemID.CrimsonKey);
			frozenKey3.AddTile(TileID.WorkBenches);
			frozenKey3.Register();

			Recipe frozenKey4 = Recipe.Create(ItemID.FrozenKey);
			frozenKey4.AddIngredient(ItemID.HallowedKey);
			frozenKey4.AddTile(TileID.WorkBenches);
			frozenKey4.Register();

			Recipe frozenKey5 = Recipe.Create(ItemID.FrozenKey);
			frozenKey5.AddIngredient(ItemID.DungeonDesertKey);
			frozenKey5.AddTile(TileID.WorkBenches);
			frozenKey5.Register();

			Recipe desertKey1 = Recipe.Create(ItemID.DungeonDesertKey);
			desertKey1.AddIngredient(ItemID.JungleKey);
			desertKey1.AddTile(TileID.WorkBenches);
			desertKey1.Register();

			Recipe desertKey2 = Recipe.Create(ItemID.DungeonDesertKey);
			desertKey2.AddIngredient(ItemID.CorruptionKey);
			desertKey2.AddTile(TileID.WorkBenches);
			desertKey2.Register();

			Recipe desertKey3 = Recipe.Create(ItemID.DungeonDesertKey);
			desertKey3.AddIngredient(ItemID.CrimsonKey);
			desertKey3.AddTile(TileID.WorkBenches);
			desertKey3.Register();

			Recipe desertKey4 = Recipe.Create(ItemID.DungeonDesertKey);
			desertKey4.AddIngredient(ItemID.HallowedKey);
			desertKey4.AddTile(TileID.WorkBenches);
			desertKey4.Register();

			Recipe desertKey5 = Recipe.Create(ItemID.DungeonDesertKey);
			desertKey5.AddIngredient(ItemID.FrozenKey);
			desertKey5.AddTile(TileID.WorkBenches);
			desertKey5.Register();

			Recipe biomekeys1 = Recipe.Create(ItemID.JungleKey);
			biomekeys1.AddIngredient(ItemID.GoldenKey, 5);
			biomekeys1.AddIngredient(ItemID.ChlorophyteBar, 50);
			biomekeys1.AddTile(ItemID.MythrilAnvil);
			biomekeys1.Register();

			Recipe biomekeys2 = Recipe.Create(ItemID.CorruptionKey);
			biomekeys2.AddIngredient(ItemID.GoldenKey, 5);
			biomekeys2.AddIngredient(ItemID.CursedFlame, 25);
			biomekeys2.AddTile(ItemID.MythrilAnvil);
			biomekeys2.Register();
			
			Recipe biomekeys3 = Recipe.Create(ItemID.CrimsonKey);
			biomekeys3.AddIngredient(ItemID.GoldenKey, 5);
			biomekeys3.AddIngredient(ItemID.Ichor, 25);
			biomekeys3.AddTile(ItemID.MythrilAnvil);
			biomekeys3.Register();

			Recipe biomekeys4 = Recipe.Create(ItemID.HallowedKey);
			biomekeys4.AddIngredient(ItemID.GoldenKey, 5);
			biomekeys4.AddIngredient(ItemID.PixieDust, 100);
			biomekeys4.AddTile(ItemID.MythrilAnvil);
			biomekeys4.Register();

			Recipe biomekeys5 = Recipe.Create(ItemID.FrozenKey);
			biomekeys5.AddIngredient(ItemID.GoldenKey, 5);
			biomekeys5.AddIngredient(ItemID.IceBlock, 500);
			biomekeys5.AddTile(ItemID.MythrilAnvil);
			biomekeys5.Register();

			Recipe biomekeys6 = Recipe.Create(ItemID.DungeonDesertKey);
			biomekeys6.AddIngredient(ItemID.GoldenKey, 5);
			biomekeys6.AddIngredient(ItemID.FossilOre, 50);
			biomekeys6.AddTile(ItemID.MythrilAnvil);
			biomekeys6.Register();

			Recipe laserDrill1 = Recipe.Create(ItemID.LaserDrill);
			laserDrill1.AddIngredient(ItemID.TitaniumDrill);
			laserDrill1.AddIngredient(ItemID.MartianConduitPlating);
			laserDrill1.AddTile(TileID.MythrilAnvil);
			laserDrill1.Register();

			Recipe laserDrill2 = Recipe.Create(ItemID.LaserDrill);
			laserDrill2.AddIngredient(ItemID.AdamantiteDrill);
			laserDrill2.AddIngredient(ItemID.MartianConduitPlating);
			laserDrill2.AddTile(TileID.MythrilAnvil);
			laserDrill2.Register();

			Recipe FroyoFeather = Recipe.Create(ItemID.IceFeather);
			FroyoFeather.AddIngredient(ItemID.FrostCore);
			FroyoFeather.AddIngredient(ItemID.Feather);
			FroyoFeather.AddTile(TileID.Anvils);
			FroyoFeather.Register();

			Recipe PaladinHammer = Recipe.Create(ItemID.PaladinsHammer);
			PaladinHammer.AddIngredient(ItemID.PaladinsShield);
			PaladinHammer.AddTile(TileID.WorkBenches);
			PaladinHammer.Register();

			Recipe PaladinShield = Recipe.Create(ItemID.PaladinsShield);
			PaladinShield.AddIngredient(ItemID.PaladinsHammer);
			PaladinShield.AddTile(TileID.WorkBenches);
			PaladinShield.Register();

			//pre-hardmode loot swap------------------------------------------------------------------------------------------

			//locked chests

			Recipe Muramasa1 = Recipe.Create(ItemID.Muramasa);
			Muramasa1.AddIngredient(ItemID.CobaltShield);
			Muramasa1.AddTile(TileID.WorkBenches);
			Muramasa1.Register();

			Recipe Muramasa2 = Recipe.Create(ItemID.Muramasa);
			Muramasa2.AddIngredient(ItemID.AquaScepter);
			Muramasa2.AddTile(TileID.WorkBenches);
			Muramasa2.Register();

			Recipe Muramasa3 = Recipe.Create(ItemID.Muramasa);
			Muramasa3.AddIngredient(ItemID.BlueMoon);
			Muramasa3.AddTile(TileID.WorkBenches);
			Muramasa3.Register();

			Recipe Muramasa4 = Recipe.Create(ItemID.Muramasa);
			Muramasa4.AddIngredient(ItemID.MagicMissile);
			Muramasa4.AddTile(TileID.WorkBenches);
			Muramasa4.Register();

			Recipe Muramasa5 = Recipe.Create(ItemID.Muramasa);
			Muramasa5.AddIngredient(ItemID.Handgun);
			Muramasa5.AddTile(TileID.WorkBenches);
			Muramasa5.Register();

			Recipe CobaltShield11 = Recipe.Create(ItemID.CobaltShield);
			CobaltShield11.AddIngredient(ItemID.Muramasa);
			CobaltShield11.AddTile(TileID.WorkBenches);
			CobaltShield11.Register();

			Recipe CobaltShield12 = Recipe.Create(ItemID.CobaltShield);
			CobaltShield12.AddIngredient(ItemID.AquaScepter);
			CobaltShield12.AddTile(TileID.WorkBenches);
			CobaltShield12.Register();

			Recipe CobaltShield3 = Recipe.Create(ItemID.CobaltShield);
			CobaltShield3.AddIngredient(ItemID.BlueMoon);
			CobaltShield3.AddTile(TileID.WorkBenches);
			CobaltShield3.Register();

			Recipe CobaltShield4 = Recipe.Create(ItemID.CobaltShield);
			CobaltShield4.AddIngredient(ItemID.MagicMissile);
			CobaltShield4.AddTile(TileID.WorkBenches);
			CobaltShield4.Register();

			Recipe CobaltShield5 = Recipe.Create(ItemID.CobaltShield);
			CobaltShield5.AddIngredient(ItemID.Handgun);
			CobaltShield5.AddTile(TileID.WorkBenches);
			CobaltShield5.Register();

			Recipe AquaScepter1 = Recipe.Create(ItemID.AquaScepter);
			AquaScepter1.AddIngredient(ItemID.Muramasa);
			AquaScepter1.AddTile(TileID.WorkBenches);
			AquaScepter1.Register();

			Recipe AquaScepter2 = Recipe.Create(ItemID.AquaScepter);
			AquaScepter2.AddIngredient(ItemID.CobaltShield);
			AquaScepter2.AddTile(TileID.WorkBenches);
			AquaScepter2.Register();

			Recipe AquaScepter3 = Recipe.Create(ItemID.AquaScepter);
			AquaScepter3.AddIngredient(ItemID.BlueMoon);
			AquaScepter3.AddTile(TileID.WorkBenches);
			AquaScepter3.Register();

			Recipe AquaScepter4 = Recipe.Create(ItemID.AquaScepter);
			AquaScepter4.AddIngredient(ItemID.MagicMissile);
			AquaScepter4.AddTile(TileID.WorkBenches);
			AquaScepter4.Register();

			Recipe AquaScepter5 = Recipe.Create(ItemID.AquaScepter);
			AquaScepter5.AddIngredient(ItemID.Handgun);
			AquaScepter5.AddTile(TileID.WorkBenches);
			AquaScepter5.Register();

			Recipe BlueMoon1 = Recipe.Create(ItemID.BlueMoon);
			BlueMoon1.AddIngredient(ItemID.Muramasa);
			BlueMoon1.AddTile(TileID.WorkBenches);
			BlueMoon1.Register();

			Recipe BlueMoon2 = Recipe.Create(ItemID.BlueMoon);
			BlueMoon2.AddIngredient(ItemID.CobaltShield);
			BlueMoon2.AddTile(TileID.WorkBenches);
			BlueMoon2.Register();

			Recipe BlueMoon3 = Recipe.Create(ItemID.BlueMoon);
			BlueMoon3.AddIngredient(ItemID.AquaScepter);
			BlueMoon3.AddTile(TileID.WorkBenches);
			BlueMoon3.Register();

			Recipe BlueMoon4 = Recipe.Create(ItemID.BlueMoon);
			BlueMoon4.AddIngredient(ItemID.MagicMissile);
			BlueMoon4.AddTile(TileID.WorkBenches);
			BlueMoon4.Register();

			Recipe BlueMoon5 = Recipe.Create(ItemID.BlueMoon);
			BlueMoon5.AddIngredient(ItemID.Handgun);
			BlueMoon5.AddTile(TileID.WorkBenches);
			BlueMoon5.Register();

			Recipe MagicMissile1 = Recipe.Create(ItemID.MagicMissile);
			MagicMissile1.AddIngredient(ItemID.Muramasa);
			MagicMissile1.AddTile(TileID.WorkBenches);
			MagicMissile1.Register();

			Recipe MagicMissile2 = Recipe.Create(ItemID.MagicMissile);
			MagicMissile2.AddIngredient(ItemID.CobaltShield);
			MagicMissile2.AddTile(TileID.WorkBenches);
			MagicMissile2.Register();

			Recipe MagicMissile3 = Recipe.Create(ItemID.MagicMissile);
			MagicMissile3.AddIngredient(ItemID.AquaScepter);
			MagicMissile3.AddTile(TileID.WorkBenches);
			MagicMissile3.Register();

			Recipe MagicMissile4 = Recipe.Create(ItemID.MagicMissile);
			MagicMissile4.AddIngredient(ItemID.BlueMoon);
			MagicMissile4.AddTile(TileID.WorkBenches);
			MagicMissile4.Register();

			Recipe MagicMissile5 = Recipe.Create(ItemID.MagicMissile);
			MagicMissile5.AddIngredient(ItemID.Handgun);
			MagicMissile5.AddTile(TileID.WorkBenches);
			MagicMissile5.Register();

			Recipe Handgun1 = Recipe.Create(ItemID.Handgun);
			Handgun1.AddIngredient(ItemID.Muramasa);
			Handgun1.AddTile(TileID.WorkBenches);
			Handgun1.Register();

			Recipe Handgun2 = Recipe.Create(ItemID.Handgun);
			Handgun2.AddIngredient(ItemID.CobaltShield);
			Handgun2.AddTile(TileID.WorkBenches);
			Handgun2.Register();

			Recipe Handgun3 = Recipe.Create(ItemID.Handgun);
			Handgun3.AddIngredient(ItemID.AquaScepter);
			Handgun3.AddTile(TileID.WorkBenches);
			Handgun3.Register();

			Recipe Handgun4 = Recipe.Create(ItemID.Handgun);
			Handgun4.AddIngredient(ItemID.BlueMoon);
			Handgun4.AddTile(TileID.WorkBenches);
			Handgun4.Register();

			Recipe Handgun5 = Recipe.Create(ItemID.Handgun);
			Handgun5.AddIngredient(ItemID.MagicMissile);
			Handgun5.AddTile(TileID.WorkBenches);
			Handgun5.Register();

			//sky chest

			Recipe ShinyRedBalloon1 = Recipe.Create(ItemID.ShinyRedBalloon);
			ShinyRedBalloon1.AddIngredient(ItemID.Starfury);
			ShinyRedBalloon1.AddTile(TileID.WorkBenches);
			ShinyRedBalloon1.Register();

			Recipe ShinyRedBalloon2 = Recipe.Create(ItemID.ShinyRedBalloon);
			ShinyRedBalloon2.AddIngredient(ItemID.LuckyHorseshoe);
			ShinyRedBalloon2.AddTile(TileID.WorkBenches);
			ShinyRedBalloon2.Register();

			Recipe ShinyRedBalloon3 = Recipe.Create(ItemID.ShinyRedBalloon);
			ShinyRedBalloon3.AddIngredient(ItemID.CelestialMagnet);
			ShinyRedBalloon3.AddTile(TileID.WorkBenches);
			ShinyRedBalloon3.Register();

			Recipe Starfury1 = Recipe.Create(ItemID.Starfury);
			Starfury1.AddIngredient(ItemID.ShinyRedBalloon);
			Starfury1.AddTile(TileID.WorkBenches);
			Starfury1.Register();

			Recipe Starfury2 = Recipe.Create(ItemID.Starfury);
			Starfury2.AddIngredient(ItemID.LuckyHorseshoe);
			Starfury2.AddTile(TileID.WorkBenches);
			Starfury2.Register();

			Recipe Starfury3 = Recipe.Create(ItemID.Starfury);
			Starfury3.AddIngredient(ItemID.CelestialCuffs);
			Starfury3.AddTile(TileID.WorkBenches);
			Starfury3.Register();

			Recipe LuckyHorseshoe1 = Recipe.Create(ItemID.LuckyHorseshoe);
			LuckyHorseshoe1.AddIngredient(ItemID.ShinyRedBalloon);
			LuckyHorseshoe1.AddTile(TileID.WorkBenches);
			LuckyHorseshoe1.Register();

			Recipe LuckyHorseshoe2 = Recipe.Create(ItemID.LuckyHorseshoe);
			LuckyHorseshoe2.AddIngredient(ItemID.Starfury);
			LuckyHorseshoe2.AddTile(TileID.WorkBenches);
			LuckyHorseshoe2.Register();

			Recipe LuckyHorseshoe3 = Recipe.Create(ItemID.LuckyHorseshoe);
			LuckyHorseshoe3.AddIngredient(ItemID.CelestialMagnet);
			LuckyHorseshoe3.AddTile(TileID.WorkBenches);
			LuckyHorseshoe3.Register();

			Recipe CelestialMagnet1 = Recipe.Create(ItemID.CelestialMagnet);
			CelestialMagnet1.AddIngredient(ItemID.Starfury);
			CelestialMagnet1.AddTile(TileID.WorkBenches);
			CelestialMagnet1.Register();

			Recipe CelestialMagnet2 = Recipe.Create(ItemID.CelestialMagnet);
			CelestialMagnet2.AddIngredient(ItemID.ShinyRedBalloon);
			CelestialMagnet2.AddTile(TileID.WorkBenches);
			CelestialMagnet2.Register();

			Recipe CelestialMagnet3 = Recipe.Create(ItemID.CelestialMagnet);
			CelestialMagnet3.AddIngredient(ItemID.LuckyHorseshoe);
			CelestialMagnet3.AddTile(TileID.WorkBenches);
			CelestialMagnet3.Register();
			
			//main bosses----------------
			
			//king slime-----

			Recipe ninjaHood1 = Recipe.Create(ItemID.NinjaHood);
			ninjaHood1.AddIngredient(ItemID.NinjaShirt);
			ninjaHood1.AddTile(TileID.WorkBenches);
			ninjaHood1.Register();

			Recipe ninjaHood2 = Recipe.Create(ItemID.NinjaHood);
			ninjaHood2.AddIngredient(ItemID.NinjaPants);
			ninjaHood2.AddTile(TileID.WorkBenches);
			ninjaHood2.Register();

			Recipe ninjaShirt1 = Recipe.Create(ItemID.NinjaShirt);
			ninjaShirt1.AddIngredient(ItemID.NinjaHood);
			ninjaShirt1.AddTile(TileID.WorkBenches);
			ninjaShirt1.Register();

			Recipe ninjaShirt2 = Recipe.Create(ItemID.NinjaShirt);
			ninjaShirt2.AddIngredient(ItemID.NinjaPants);
			ninjaShirt2.AddTile(TileID.WorkBenches);
			ninjaShirt2.Register();

			Recipe ninjaPants1 = Recipe.Create(ItemID.NinjaPants);
			ninjaPants1.AddIngredient(ItemID.NinjaShirt);
			ninjaPants1.AddTile(TileID.WorkBenches);
			ninjaPants1.Register();

			Recipe ninjaPants2 = Recipe.Create(ItemID.NinjaPants);
			ninjaPants2.AddIngredient(ItemID.NinjaHood);
			ninjaPants2.AddTile(TileID.WorkBenches);
			ninjaPants2.Register();

			Recipe slimeHook = Recipe.Create(ItemID.SlimeHook);
			slimeHook.AddIngredient(ItemID.SlimeGun);
			slimeHook.AddTile(TileID.WorkBenches);
			slimeHook.Register();

			Recipe slimeGun = Recipe.Create(ItemID.SlimeGun);
			slimeGun.AddIngredient(ItemID.SlimeHook);
			slimeGun.AddTile(TileID.WorkBenches);
			slimeGun.Register();

			Recipe saddle = Recipe.Create(ItemID.SlimySaddle);
			saddle.AddIngredient(ItemID.SlimeGun);
			saddle.AddTile(TileID.WorkBenches);
			saddle.Register();

			Recipe saddle2 = Recipe.Create(ItemID.SlimySaddle);
			saddle2.AddIngredient(ItemID.SlimeHook);
			saddle2.AddTile(TileID.WorkBenches);
			saddle2.Register();

			//eater of worlds and brain of cuthulu-----

			Recipe wormScarf = Recipe.Create(ItemID.WormScarf);
			wormScarf.AddIngredient(ItemID.BrainOfConfusion);
			wormScarf.AddTile(TileID.WorkBenches);
			wormScarf.Register();

			Recipe confusingbrain = Recipe.Create(ItemID.BrainOfConfusion);
			confusingbrain.AddIngredient(ItemID.WormScarf);
			confusingbrain.AddTile(TileID.WorkBenches);
			confusingbrain.Register();

			//queen bee-----

			Recipe beeGun1 = Recipe.Create(ItemID.BeeGun);
			beeGun1.AddIngredient(ItemID.BeeKeeper);
			beeGun1.AddTile(TileID.WorkBenches);
			beeGun1.Register();

			Recipe beeGun2 = Recipe.Create(ItemID.BeeGun);
			beeGun2.AddIngredient(ItemID.BeesKnees);
			beeGun2.AddTile(TileID.WorkBenches);
			beeGun2.Register();

			Recipe beeKeeper1 = Recipe.Create(ItemID.BeeKeeper);
			beeKeeper1.AddIngredient(ItemID.BeesKnees);
			beeKeeper1.AddTile(TileID.WorkBenches);
			beeKeeper1.Register();

			Recipe beeKeeper2 = Recipe.Create(ItemID.BeeKeeper);
			beeKeeper2.AddIngredient(ItemID.BeeGun);
			beeKeeper2.AddTile(TileID.WorkBenches);
			beeKeeper2.Register();

			Recipe beeBow1 = Recipe.Create(ItemID.BeesKnees);
			beeBow1.AddIngredient(ItemID.BeeKeeper);
			beeBow1.AddTile(TileID.WorkBenches);
			beeBow1.Register();

			Recipe beeBow2 = Recipe.Create(ItemID.BeesKnees);
			beeBow2.AddIngredient(ItemID.BeeGun);
			beeBow2.AddTile(TileID.WorkBenches);
			beeBow2.Register();

			Recipe hiveWand1 = Recipe.Create(ItemID.HiveWand);
			hiveWand1.AddIngredient(ItemID.BeeHat);
			hiveWand1.AddTile(TileID.WorkBenches);
			hiveWand1.Register();

			Recipe hiveWand2 = Recipe.Create(ItemID.HiveWand);
			hiveWand2.AddIngredient(ItemID.BeeShirt);
			hiveWand2.AddTile(TileID.WorkBenches);
			hiveWand2.Register();

			Recipe hiveWand3 = Recipe.Create(ItemID.HiveWand);
			hiveWand3.AddIngredient(ItemID.BeePants);
			hiveWand3.AddTile(TileID.WorkBenches);
			hiveWand3.Register();

			Recipe beeHat1 = Recipe.Create(ItemID.BeeHat);
			beeHat1.AddIngredient(ItemID.HiveWand);
			beeHat1.AddTile(TileID.WorkBenches);
			beeHat1.Register();

			Recipe beeHat2 = Recipe.Create(ItemID.BeeHat);
			beeHat2.AddIngredient(ItemID.BeeShirt);
			beeHat2.AddTile(TileID.WorkBenches);
			beeHat2.Register();

			Recipe beeHat3 = Recipe.Create(ItemID.BeeHat);
			beeHat3.AddIngredient(ItemID.BeePants);
			beeHat3.AddTile(TileID.WorkBenches);
			beeHat3.Register();

			Recipe beeShirt1 = Recipe.Create(ItemID.BeeShirt);
			beeShirt1.AddIngredient(ItemID.HiveWand);
			beeShirt1.AddTile(TileID.WorkBenches);
			beeShirt1.Register();

			Recipe beeShirt2 = Recipe.Create(ItemID.BeeShirt);
			beeShirt2.AddIngredient(ItemID.BeeHat);
			beeShirt2.AddTile(TileID.WorkBenches);
			beeShirt2.Register();

			Recipe beeShirt3 = Recipe.Create(ItemID.BeeShirt);
			beeShirt3.AddIngredient(ItemID.BeePants);
			beeShirt3.AddTile(TileID.WorkBenches);
			beeShirt3.Register();

			Recipe beePant1 = Recipe.Create(ItemID.BeePants);
			beePant1.AddIngredient(ItemID.HiveWand);
			beePant1.AddTile(TileID.WorkBenches);
			beePant1.Register();

			Recipe beePant2 = Recipe.Create(ItemID.BeePants);
			beePant2.AddIngredient(ItemID.BeeHat);
			beePant2.AddTile(TileID.WorkBenches);
			beePant2.Register();

			Recipe beePant3 = Recipe.Create(ItemID.BeePants);
			beePant3.AddIngredient(ItemID.BeeShirt);
			beePant3.AddTile(TileID.WorkBenches);
			beePant3.Register();

			//skeletron-----

			Recipe skeleMask1 = Recipe.Create(ItemID.SkeletronMask);
			skeleMask1.AddIngredient(ItemID.SkeletronHand);
			skeleMask1.AddTile(TileID.WorkBenches);
			skeleMask1.Register();

			Recipe skeleMask2 = Recipe.Create(ItemID.SkeletronMask);
			skeleMask2.AddIngredient(ItemID.BookofSkulls);
			skeleMask2.AddTile(TileID.WorkBenches);
			skeleMask2.Register();

			Recipe skeleHand1 = Recipe.Create(ItemID.SkeletronHand);
			skeleHand1.AddIngredient(ItemID.SkeletronMask);
			skeleHand1.AddTile(TileID.WorkBenches);
			skeleHand1.Register();

			Recipe skeleHand2 = Recipe.Create(ItemID.SkeletronHand);
			skeleHand2.AddIngredient(ItemID.BookofSkulls);
			skeleHand2.AddTile(TileID.WorkBenches);
			skeleHand2.Register();

			Recipe bookofSkele1 = Recipe.Create(ItemID.BookofSkulls);
			bookofSkele1.AddIngredient(ItemID.SkeletronMask);
			bookofSkele1.AddTile(TileID.WorkBenches);
			bookofSkele1.Register();

			Recipe bookofSkele2 = Recipe.Create(ItemID.BookofSkulls);
			bookofSkele2.AddIngredient(ItemID.SkeletronHand);
			bookofSkele2.AddTile(TileID.WorkBenches);
			bookofSkele2.Register();

			//deerclops-----

			Recipe pewmatic1 = Recipe.Create(ItemID.PewMaticHorn);
			pewmatic1.AddIngredient(ItemID.WeatherPain);
			pewmatic1.AddTile(TileID.WorkBenches);
			pewmatic1.Register();

			Recipe pewmatic2 = Recipe.Create(ItemID.PewMaticHorn);
			pewmatic2.AddIngredient(ItemID.HoundiusShootius);
			pewmatic2.AddTile(TileID.WorkBenches);
			pewmatic2.Register();

			Recipe pewmatic3 = Recipe.Create(ItemID.PewMaticHorn);
			pewmatic3.AddIngredient(ItemID.LucyTheAxe);
			pewmatic3.AddTile(TileID.WorkBenches);
			pewmatic3.Register();

			Recipe weatherPain1 = Recipe.Create(ItemID.WeatherPain);
			weatherPain1.AddIngredient(ItemID.PewMaticHorn);
			weatherPain1.AddTile(TileID.WorkBenches);
			weatherPain1.Register();

			Recipe weatherPain2 = Recipe.Create(ItemID.WeatherPain);
			weatherPain2.AddIngredient(ItemID.HoundiusShootius);
			weatherPain2.AddTile(TileID.WorkBenches);
			weatherPain2.Register();

			Recipe weatherPain3 = Recipe.Create(ItemID.WeatherPain);
			weatherPain3.AddIngredient(ItemID.LucyTheAxe);
			weatherPain3.AddTile(TileID.WorkBenches);
			weatherPain3.Register();

			Recipe weirdName1 = Recipe.Create(ItemID.HoundiusShootius);
			weirdName1.AddIngredient(ItemID.WeatherPain);
			weirdName1.AddTile(TileID.WorkBenches);
			weirdName1.Register();

			Recipe weirdName2 = Recipe.Create(ItemID.HoundiusShootius);
			weirdName2.AddIngredient(ItemID.PewMaticHorn);
			weirdName2.AddTile(TileID.WorkBenches);
			weirdName2.Register();

			Recipe weirdName3 = Recipe.Create(ItemID.HoundiusShootius);
			weirdName3.AddIngredient(ItemID.LucyTheAxe);
			weirdName3.AddTile(TileID.WorkBenches);
			weirdName3.Register();

			Recipe lucy1 = Recipe.Create(ItemID.LucyTheAxe);
			lucy1.AddIngredient(ItemID.WeatherPain);
			lucy1.AddTile(TileID.WorkBenches);
			lucy1.Register();

			Recipe lucy2 = Recipe.Create(ItemID.LucyTheAxe);
			lucy2.AddIngredient(ItemID.PewMaticHorn);
			lucy2.AddTile(TileID.WorkBenches);
			lucy2.Register();

			Recipe lucy3 = Recipe.Create(ItemID.LucyTheAxe);
			lucy3.AddIngredient(ItemID.HoundiusShootius);
			lucy3.AddTile(TileID.WorkBenches);
			lucy3.Register();

			//wall of flesh-----

			Recipe bigSword1 = Recipe.Create(ItemID.BreakerBlade);
			bigSword1.AddIngredient(ItemID.ClockworkAssaultRifle);
			bigSword1.AddTile(TileID.WorkBenches);
			bigSword1.Register();

			Recipe bigSword2 = Recipe.Create(ItemID.BreakerBlade);
			bigSword2.AddIngredient(ItemID.LaserRifle);
			bigSword2.AddTile(TileID.WorkBenches);
			bigSword2.Register();

			Recipe bigSword3 = Recipe.Create(ItemID.BreakerBlade);
			bigSword3.AddIngredient(ItemID.FireWhip);
			bigSword3.AddTile(TileID.WorkBenches);
			bigSword3.Register();

			Recipe clockGun1 = Recipe.Create(ItemID.ClockworkAssaultRifle);
			clockGun1.AddIngredient(ItemID.BreakerBlade);
			clockGun1.AddTile(TileID.WorkBenches);
			clockGun1.Register();

			Recipe clockGun2 = Recipe.Create(ItemID.ClockworkAssaultRifle);
			clockGun2.AddIngredient(ItemID.LaserRifle);
			clockGun2.AddTile(TileID.WorkBenches);
			clockGun2.Register();

			Recipe clockGun3 = Recipe.Create(ItemID.ClockworkAssaultRifle);
			clockGun3.AddIngredient(ItemID.FireWhip);
			clockGun3.AddTile(TileID.WorkBenches);
			clockGun3.Register();

			Recipe laserRifle1 = Recipe.Create(ItemID.LaserRifle);
			laserRifle1.AddIngredient(ItemID.BreakerBlade);
			laserRifle1.AddTile(TileID.WorkBenches);
			laserRifle1.Register();

			Recipe laserRifle2 = Recipe.Create(ItemID.LaserRifle);
			laserRifle2.AddIngredient(ItemID.ClockworkAssaultRifle);
			laserRifle2.AddTile(TileID.WorkBenches);
			laserRifle2.Register();

			Recipe laserRifle3 = Recipe.Create(ItemID.LaserRifle);
			laserRifle3.AddIngredient(ItemID.FireWhip);
			laserRifle3.AddTile(TileID.WorkBenches);
			laserRifle3.Register();

			Recipe firecracker1 = Recipe.Create(ItemID.FireWhip);
			firecracker1.AddIngredient(ItemID.BreakerBlade);
			firecracker1.AddTile(TileID.WorkBenches);
			firecracker1.Register();

			Recipe firecracker2 = Recipe.Create(ItemID.FireWhip);
			firecracker2.AddIngredient(ItemID.ClockworkAssaultRifle);
			firecracker2.AddTile(TileID.WorkBenches);
			firecracker2.Register();

			Recipe firecracker3 = Recipe.Create(ItemID.FireWhip);
			firecracker3.AddIngredient(ItemID.LaserRifle);
			firecracker3.AddTile(TileID.WorkBenches);
			firecracker3.Register();

			//hardmode loot swap------------------------------------------------------------------------------------------

			//bosses-------------------------------------------

			//queen slime-----

			Recipe crystalHood1 = Recipe.Create(ItemID.CrystalNinjaHelmet);
			crystalHood1.AddIngredient(ItemID.CrystalNinjaChestplate);
			crystalHood1.AddTile(TileID.WorkBenches);
			crystalHood1.Register();

			Recipe crystalHood2 = Recipe.Create(ItemID.CrystalNinjaHelmet);
			crystalHood2.AddIngredient(ItemID.CrystalNinjaLeggings);
			crystalHood2.AddTile(TileID.WorkBenches);
			crystalHood2.Register();

			Recipe crystalChest1 = Recipe.Create(ItemID.CrystalNinjaChestplate);
			crystalChest1.AddIngredient(ItemID.CrystalNinjaHelmet);
			crystalChest1.AddTile(TileID.WorkBenches);
			crystalChest1.Register();

			Recipe crystalChest2 = Recipe.Create(ItemID.CrystalNinjaChestplate);
			crystalChest2.AddIngredient(ItemID.CrystalNinjaLeggings);
			crystalChest2.AddTile(TileID.WorkBenches);
			crystalChest2.Register();

			Recipe crystalLeg1 = Recipe.Create(ItemID.CrystalNinjaLeggings);
			crystalLeg1.AddIngredient(ItemID.CrystalNinjaChestplate);
			crystalLeg1.AddTile(TileID.WorkBenches);
			crystalLeg1.Register();

			Recipe crystalLeg2 = Recipe.Create(ItemID.CrystalNinjaLeggings);
			crystalLeg2.AddIngredient(ItemID.CrystalNinjaHelmet);
			crystalLeg2.AddTile(TileID.WorkBenches);
			crystalLeg2.Register();

			//plantera-----

			Recipe nadeLauncher1 = Recipe.Create(ItemID.GrenadeLauncher);
			nadeLauncher1.AddIngredient(ItemID.VenusMagnum);
			nadeLauncher1.AddTile(TileID.WorkBenches);
			nadeLauncher1.Register();

			Recipe nadeLauncher2 = Recipe.Create(ItemID.GrenadeLauncher);
			nadeLauncher2.AddIngredient(ItemID.NettleBurst);
			nadeLauncher2.AddTile(TileID.WorkBenches);
			nadeLauncher2.Register();

			Recipe nadeLauncher3 = Recipe.Create(ItemID.GrenadeLauncher);
			nadeLauncher3.AddIngredient(ItemID.LeafBlower);
			nadeLauncher3.AddTile(TileID.WorkBenches);
			nadeLauncher3.Register();

			Recipe nadeLauncher4 = Recipe.Create(ItemID.GrenadeLauncher);
			nadeLauncher4.AddIngredient(ItemID.FlowerPow);
			nadeLauncher4.AddTile(TileID.WorkBenches);
			nadeLauncher4.Register();

			Recipe nadeLauncher5 = Recipe.Create(ItemID.GrenadeLauncher);
			nadeLauncher5.AddIngredient(ItemID.WaspGun);
			nadeLauncher5.AddTile(TileID.WorkBenches);
			nadeLauncher5.Register();

			Recipe nadeLauncher6 = Recipe.Create(ItemID.GrenadeLauncher);
			nadeLauncher6.AddIngredient(ItemID.Seedler);
			nadeLauncher6.AddTile(TileID.WorkBenches);
			nadeLauncher6.Register();

			Recipe venusGun1 = Recipe.Create(ItemID.VenusMagnum);
			venusGun1.AddIngredient(ItemID.GrenadeLauncher);
			venusGun1.AddTile(TileID.WorkBenches);
			venusGun1.Register();

			Recipe venusGun2 = Recipe.Create(ItemID.VenusMagnum);
			venusGun2.AddIngredient(ItemID.NettleBurst);
			venusGun2.AddTile(TileID.WorkBenches);
			venusGun2.Register();

			Recipe venusGun3 = Recipe.Create(ItemID.VenusMagnum);
			venusGun3.AddIngredient(ItemID.LeafBlower);
			venusGun3.AddTile(TileID.WorkBenches);
			venusGun3.Register();

			Recipe venusGun4 = Recipe.Create(ItemID.VenusMagnum);
			venusGun4.AddIngredient(ItemID.FlowerPow);
			venusGun4.AddTile(TileID.WorkBenches);
			venusGun4.Register();

			Recipe venusGun5 = Recipe.Create(ItemID.VenusMagnum);
			venusGun5.AddIngredient(ItemID.WaspGun);
			venusGun5.AddTile(TileID.WorkBenches);
			venusGun5.Register();

			Recipe venusGun6 = Recipe.Create(ItemID.VenusMagnum);
			venusGun6.AddIngredient(ItemID.Seedler);
			venusGun6.AddTile(TileID.WorkBenches);
			venusGun6.Register();

			Recipe nettleBurst1 = Recipe.Create(ItemID.NettleBurst);
			nettleBurst1.AddIngredient(ItemID.GrenadeLauncher);
			nettleBurst1.AddTile(TileID.WorkBenches);
			nettleBurst1.Register();

			Recipe nettleBurst2 = Recipe.Create(ItemID.NettleBurst);
			nettleBurst2.AddIngredient(ItemID.VenusMagnum);
			nettleBurst2.AddTile(TileID.WorkBenches);
			nettleBurst2.Register();

			Recipe nettleBurst3 = Recipe.Create(ItemID.NettleBurst);
			nettleBurst3.AddIngredient(ItemID.LeafBlower);
			nettleBurst3.AddTile(TileID.WorkBenches);
			nettleBurst3.Register();

			Recipe nettleBurst4 = Recipe.Create(ItemID.NettleBurst);
			nettleBurst4.AddIngredient(ItemID.FlowerPow);
			nettleBurst4.AddTile(TileID.WorkBenches);
			nettleBurst4.Register();

			Recipe nettleBurst5 = Recipe.Create(ItemID.NettleBurst);
			nettleBurst5.AddIngredient(ItemID.WaspGun);
			nettleBurst5.AddTile(TileID.WorkBenches);
			nettleBurst5.Register();

			Recipe nettleBurst6 = Recipe.Create(ItemID.NettleBurst);
			nettleBurst6.AddIngredient(ItemID.Seedler);
			nettleBurst6.AddTile(TileID.WorkBenches);
			nettleBurst6.Register();

			Recipe leafBlower1 = Recipe.Create(ItemID.LeafBlower);
			leafBlower1.AddIngredient(ItemID.GrenadeLauncher);
			leafBlower1.AddTile(TileID.WorkBenches);
			leafBlower1.Register();

			Recipe leafBlower2 = Recipe.Create(ItemID.LeafBlower);
			leafBlower2.AddIngredient(ItemID.VenusMagnum);
			leafBlower2.AddTile(TileID.WorkBenches);
			leafBlower2.Register();

			Recipe leafBlower3 = Recipe.Create(ItemID.LeafBlower);
			leafBlower3.AddIngredient(ItemID.NettleBurst);
			leafBlower3.AddTile(TileID.WorkBenches);
			leafBlower3.Register();

			Recipe leafBlower4 = Recipe.Create(ItemID.LeafBlower);
			leafBlower4.AddIngredient(ItemID.FlowerPow);
			leafBlower4.AddTile(TileID.WorkBenches);
			leafBlower4.Register();

			Recipe leafBlower5 = Recipe.Create(ItemID.LeafBlower);
			leafBlower5.AddIngredient(ItemID.WaspGun);
			leafBlower5.AddTile(TileID.WorkBenches);
			leafBlower5.Register();

			Recipe leafBlower6 = Recipe.Create(ItemID.LeafBlower);
			leafBlower6.AddIngredient(ItemID.Seedler);
			leafBlower6.AddTile(TileID.WorkBenches);
			leafBlower6.Register();

			Recipe flowerPow1 = Recipe.Create(ItemID.FlowerPow);
			flowerPow1.AddIngredient(ItemID.GrenadeLauncher);
			flowerPow1.AddTile(TileID.WorkBenches);
			flowerPow1.Register();

			Recipe flowerPow2 = Recipe.Create(ItemID.FlowerPow);
			flowerPow2.AddIngredient(ItemID.VenusMagnum);
			flowerPow2.AddTile(TileID.WorkBenches);
			flowerPow2.Register();

			Recipe flowerPow3 = Recipe.Create(ItemID.FlowerPow);
			flowerPow3.AddIngredient(ItemID.NettleBurst);
			flowerPow3.AddTile(TileID.WorkBenches);
			flowerPow3.Register();

			Recipe flowerPow4 = Recipe.Create(ItemID.FlowerPow);
			flowerPow4.AddIngredient(ItemID.LeafBlower);
			flowerPow4.AddTile(TileID.WorkBenches);
			flowerPow4.Register();

			Recipe flowerPow5 = Recipe.Create(ItemID.FlowerPow);
			flowerPow5.AddIngredient(ItemID.WaspGun);
			flowerPow5.AddTile(TileID.WorkBenches);
			flowerPow5.Register();

			Recipe flowerPow6 = Recipe.Create(ItemID.FlowerPow);
			flowerPow6.AddIngredient(ItemID.Seedler);
			flowerPow6.AddTile(TileID.WorkBenches);
			flowerPow6.Register();

			Recipe waspGun1 = Recipe.Create(ItemID.WaspGun);
			waspGun1.AddIngredient(ItemID.GrenadeLauncher);
			waspGun1.AddTile(TileID.WorkBenches);
			waspGun1.Register();

			Recipe waspGun2 = Recipe.Create(ItemID.WaspGun);
			waspGun2.AddIngredient(ItemID.VenusMagnum);
			waspGun2.AddTile(TileID.WorkBenches);
			waspGun2.Register();

			Recipe waspGun3 = Recipe.Create(ItemID.WaspGun);
			waspGun3.AddIngredient(ItemID.NettleBurst);
			waspGun3.AddTile(TileID.WorkBenches);
			waspGun3.Register();

			Recipe waspGun4 = Recipe.Create(ItemID.WaspGun);
			waspGun4.AddIngredient(ItemID.LeafBlower);
			waspGun4.AddTile(TileID.WorkBenches);
			waspGun4.Register();

			Recipe waspGun5 = Recipe.Create(ItemID.WaspGun);
			waspGun5.AddIngredient(ItemID.FlowerPow);
			waspGun5.AddTile(TileID.WorkBenches);
			waspGun5.Register();

			Recipe waspGun6 = Recipe.Create(ItemID.WaspGun);
			waspGun6.AddIngredient(ItemID.Seedler);
			waspGun6.AddTile(TileID.WorkBenches);
			waspGun6.Register();

			Recipe seedler1 = Recipe.Create(ItemID.Seedler);
			seedler1.AddIngredient(ItemID.GrenadeLauncher);
			seedler1.AddTile(TileID.WorkBenches);
			seedler1.Register();

			Recipe seedler2 = Recipe.Create(ItemID.Seedler);
			seedler2.AddIngredient(ItemID.VenusMagnum);
			seedler2.AddTile(TileID.WorkBenches);
			seedler2.Register();

			Recipe seedler3 = Recipe.Create(ItemID.Seedler);
			seedler3.AddIngredient(ItemID.NettleBurst);
			seedler3.AddTile(TileID.WorkBenches);
			seedler3.Register();

			Recipe seedler4 = Recipe.Create(ItemID.Seedler);
			seedler4.AddIngredient(ItemID.LeafBlower);
			seedler4.AddTile(TileID.WorkBenches);
			seedler4.Register();

			Recipe seedler5 = Recipe.Create(ItemID.Seedler);
			seedler5.AddIngredient(ItemID.FlowerPow);
			seedler5.AddTile(TileID.WorkBenches);
			seedler5.Register();

			Recipe seedler6 = Recipe.Create(ItemID.Seedler);
			seedler6.AddIngredient(ItemID.WaspGun);
			seedler6.AddTile(TileID.WorkBenches);
			seedler6.Register();

			//golem-----

			Recipe stynger1 = Recipe.Create(ItemID.Stynger);
			stynger1.AddIngredient(ItemID.PossessedHatchet);
			stynger1.AddTile(TileID.WorkBenches);
			stynger1.Register();

			Recipe stynger2 = Recipe.Create(ItemID.Stynger);
			stynger2.AddIngredient(ItemID.SunStone);
			stynger2.AddTile(TileID.WorkBenches);
			stynger2.Register();

			Recipe stynger3 = Recipe.Create(ItemID.Stynger);
			stynger3.AddIngredient(ItemID.EyeoftheGolem);
			stynger3.AddTile(TileID.WorkBenches);
			stynger3.Register();

			Recipe stynger4 = Recipe.Create(ItemID.Stynger);
			stynger4.AddIngredient(ItemID.HeatRay);
			stynger4.AddTile(TileID.WorkBenches);
			stynger4.Register();

			Recipe stynger5 = Recipe.Create(ItemID.Stynger);
			stynger5.AddIngredient(ItemID.StaffofEarth);
			stynger5.AddTile(TileID.WorkBenches);
			stynger5.Register();

			Recipe stynger6 = Recipe.Create(ItemID.Stynger);
			stynger6.AddIngredient(ItemID.GolemFist);
			stynger6.AddTile(TileID.WorkBenches);
			stynger6.Register();

			Recipe hatchet1 = Recipe.Create(ItemID.PossessedHatchet);
			hatchet1.AddIngredient(ItemID.Stynger);
			hatchet1.AddTile(TileID.WorkBenches);
			hatchet1.Register();

			Recipe hatchet2 = Recipe.Create(ItemID.PossessedHatchet);
			hatchet2.AddIngredient(ItemID.SunStone);
			hatchet2.AddTile(TileID.WorkBenches);
			hatchet2.Register();

			Recipe hatchet3 = Recipe.Create(ItemID.PossessedHatchet);
			hatchet3.AddIngredient(ItemID.EyeoftheGolem);
			hatchet3.AddTile(TileID.WorkBenches);
			hatchet3.Register();

			Recipe hatchet4 = Recipe.Create(ItemID.PossessedHatchet);
			hatchet4.AddIngredient(ItemID.HeatRay);
			hatchet4.AddTile(TileID.WorkBenches);
			hatchet4.Register();

			Recipe hatchet5 = Recipe.Create(ItemID.PossessedHatchet);
			hatchet5.AddIngredient(ItemID.StaffofEarth);
			hatchet5.AddTile(TileID.WorkBenches);
			hatchet5.Register();

			Recipe hatchet6 = Recipe.Create(ItemID.PossessedHatchet);
			hatchet6.AddIngredient(ItemID.GolemFist);
			hatchet6.AddTile(TileID.WorkBenches);
			hatchet6.Register();

			Recipe sunStone1 = Recipe.Create(ItemID.SunStone);
			sunStone1.AddIngredient(ItemID.Stynger);
			sunStone1.AddTile(TileID.WorkBenches);
			sunStone1.Register();

			Recipe sunStone2 = Recipe.Create(ItemID.SunStone);
			sunStone2.AddIngredient(ItemID.PossessedHatchet);
			sunStone2.AddTile(TileID.WorkBenches);
			sunStone2.Register();

			Recipe sunStone3 = Recipe.Create(ItemID.SunStone);
			sunStone3.AddIngredient(ItemID.EyeoftheGolem);
			sunStone3.AddTile(TileID.WorkBenches);
			sunStone3.Register();

			Recipe sunStone4 = Recipe.Create(ItemID.SunStone);
			sunStone4.AddIngredient(ItemID.HeatRay);
			sunStone4.AddTile(TileID.WorkBenches);
			sunStone4.Register();

			Recipe sunStone5 = Recipe.Create(ItemID.SunStone);
			sunStone5.AddIngredient(ItemID.StaffofEarth);
			sunStone5.AddTile(TileID.WorkBenches);
			sunStone5.Register();

			Recipe sunStone6 = Recipe.Create(ItemID.SunStone);
			sunStone6.AddIngredient(ItemID.GolemFist);
			sunStone6.AddTile(TileID.WorkBenches);
			sunStone6.Register();

			Recipe golemEye1 = Recipe.Create(ItemID.EyeoftheGolem);
			golemEye1.AddIngredient(ItemID.Stynger);
			golemEye1.AddTile(TileID.WorkBenches);
			golemEye1.Register();

			Recipe golemEye2 = Recipe.Create(ItemID.EyeoftheGolem);
			golemEye2.AddIngredient(ItemID.PossessedHatchet);
			golemEye2.AddTile(TileID.WorkBenches);
			golemEye2.Register();

			Recipe golemEye3 = Recipe.Create(ItemID.EyeoftheGolem);
			golemEye3.AddIngredient(ItemID.SunStone);
			golemEye3.AddTile(TileID.WorkBenches);
			golemEye3.Register();

			Recipe golemEye4 = Recipe.Create(ItemID.EyeoftheGolem);
			golemEye4.AddIngredient(ItemID.HeatRay);
			golemEye4.AddTile(TileID.WorkBenches);
			golemEye4.Register();

			Recipe golemEye5 = Recipe.Create(ItemID.EyeoftheGolem);
			golemEye5.AddIngredient(ItemID.StaffofEarth);
			golemEye5.AddTile(TileID.WorkBenches);
			golemEye5.Register();

			Recipe golemEye6 = Recipe.Create(ItemID.EyeoftheGolem);
			golemEye6.AddIngredient(ItemID.GolemFist);
			golemEye6.AddTile(TileID.WorkBenches);
			golemEye6.Register();

			Recipe heatRay1 = Recipe.Create(ItemID.HeatRay);
			heatRay1.AddIngredient(ItemID.Stynger);
			heatRay1.AddTile(TileID.WorkBenches);
			heatRay1.Register();

			Recipe heatRay2 = Recipe.Create(ItemID.HeatRay);
			heatRay2.AddIngredient(ItemID.PossessedHatchet);
			heatRay2.AddTile(TileID.WorkBenches);
			heatRay2.Register();

			Recipe heatRay3 = Recipe.Create(ItemID.HeatRay);
			heatRay3.AddIngredient(ItemID.SunStone);
			heatRay3.AddTile(TileID.WorkBenches);
			heatRay3.Register();

			Recipe heatRay4 = Recipe.Create(ItemID.HeatRay);
			heatRay4.AddIngredient(ItemID.EyeoftheGolem);
			heatRay4.AddTile(TileID.WorkBenches);
			heatRay4.Register();

			Recipe heatRay5 = Recipe.Create(ItemID.HeatRay);
			heatRay5.AddIngredient(ItemID.StaffofEarth);
			heatRay5.AddTile(TileID.WorkBenches);
			heatRay5.Register();

			Recipe heatRay6 = Recipe.Create(ItemID.HeatRay);
			heatRay6.AddIngredient(ItemID.GolemFist);
			heatRay6.AddTile(TileID.WorkBenches);
			heatRay6.Register();

			Recipe earthStaff1 = Recipe.Create(ItemID.StaffofEarth);
			earthStaff1.AddIngredient(ItemID.Stynger);
			earthStaff1.AddTile(TileID.WorkBenches);
			earthStaff1.Register();

			Recipe earthStaff2 = Recipe.Create(ItemID.StaffofEarth);
			earthStaff2.AddIngredient(ItemID.PossessedHatchet);
			earthStaff2.AddTile(TileID.WorkBenches);
			earthStaff2.Register();

			Recipe earthStaff3 = Recipe.Create(ItemID.StaffofEarth);
			earthStaff3.AddIngredient(ItemID.SunStone);
			earthStaff3.AddTile(TileID.WorkBenches);
			earthStaff3.Register();

			Recipe earthStaff4 = Recipe.Create(ItemID.StaffofEarth);
			earthStaff4.AddIngredient(ItemID.EyeoftheGolem);
			earthStaff4.AddTile(TileID.WorkBenches);
			earthStaff4.Register();

			Recipe earthStaff5 = Recipe.Create(ItemID.StaffofEarth);
			earthStaff5.AddIngredient(ItemID.HeatRay);
			earthStaff5.AddTile(TileID.WorkBenches);
			earthStaff5.Register();

			Recipe earthStaff6 = Recipe.Create(ItemID.StaffofEarth);
			earthStaff6.AddIngredient(ItemID.GolemFist);
			earthStaff6.AddTile(TileID.WorkBenches);
			earthStaff6.Register();

			Recipe golemFist1 = Recipe.Create(ItemID.GolemFist);
			golemFist1.AddIngredient(ItemID.Stynger);
			golemFist1.AddTile(TileID.WorkBenches);
			golemFist1.Register();

			Recipe golemFist2 = Recipe.Create(ItemID.GolemFist);
			golemFist2.AddIngredient(ItemID.PossessedHatchet);
			golemFist2.AddTile(TileID.WorkBenches);
			golemFist2.Register();

			Recipe golemFist3 = Recipe.Create(ItemID.GolemFist);
			golemFist3.AddIngredient(ItemID.SunStone);
			golemFist3.AddTile(TileID.WorkBenches);
			golemFist3.Register();

			Recipe golemFist4 = Recipe.Create(ItemID.GolemFist);
			golemFist4.AddIngredient(ItemID.EyeoftheGolem);
			golemFist4.AddTile(TileID.WorkBenches);
			golemFist4.Register();

			Recipe golemFist5 = Recipe.Create(ItemID.GolemFist);
			golemFist5.AddIngredient(ItemID.HeatRay);
			golemFist5.AddTile(TileID.WorkBenches);
			golemFist5.Register();

			Recipe golemFist6 = Recipe.Create(ItemID.GolemFist);
			golemFist6.AddIngredient(ItemID.StaffofEarth);
			golemFist6.AddTile(TileID.WorkBenches);
			golemFist6.Register();

			//empress of light-----

			Recipe nightGlow1 = Recipe.Create(ItemID.FairyQueenMagicItem);
			nightGlow1.AddIngredient(ItemID.PiercingStarlight);
			nightGlow1.AddTile(TileID.WorkBenches);
			nightGlow1.Register();

			Recipe nightGlow2 = Recipe.Create(ItemID.FairyQueenMagicItem);
			nightGlow2.AddIngredient(ItemID.RainbowWhip);
			nightGlow2.AddTile(TileID.WorkBenches);
			nightGlow2.Register();

			Recipe nightGlow3 = Recipe.Create(ItemID.FairyQueenMagicItem);
			nightGlow3.AddIngredient(ItemID.FairyQueenRangedItem);
			nightGlow3.AddTile(TileID.WorkBenches);
			nightGlow3.Register();

			Recipe starlight1 = Recipe.Create(ItemID.PiercingStarlight);
			starlight1.AddIngredient(ItemID.FairyQueenMagicItem);
			starlight1.AddTile(TileID.WorkBenches);
			starlight1.Register();

			Recipe starlight2 = Recipe.Create(ItemID.PiercingStarlight);
			starlight2.AddIngredient(ItemID.RainbowWhip);
			starlight2.AddTile(TileID.WorkBenches);
			starlight2.Register();

			Recipe starlight3 = Recipe.Create(ItemID.PiercingStarlight);
			starlight3.AddIngredient(ItemID.FairyQueenRangedItem);
			starlight3.AddTile(TileID.WorkBenches);
			starlight3.Register();

			Recipe rainbowWhip1 = Recipe.Create(ItemID.RainbowWhip);
			rainbowWhip1.AddIngredient(ItemID.FairyQueenMagicItem);
			rainbowWhip1.AddTile(TileID.WorkBenches);
			rainbowWhip1.Register();

			Recipe rainbowWhip2 = Recipe.Create(ItemID.RainbowWhip);
			rainbowWhip2.AddIngredient(ItemID.PiercingStarlight);
			rainbowWhip2.AddTile(TileID.WorkBenches);
			rainbowWhip2.Register();

			Recipe rainbowWhip3 = Recipe.Create(ItemID.RainbowWhip);
			rainbowWhip3.AddIngredient(ItemID.FairyQueenRangedItem);
			rainbowWhip3.AddTile(TileID.WorkBenches);
			rainbowWhip3.Register();

			Recipe eventide1 = Recipe.Create(ItemID.FairyQueenRangedItem);
			eventide1.AddIngredient(ItemID.FairyQueenMagicItem);
			eventide1.AddTile(TileID.WorkBenches);
			eventide1.Register();

			Recipe eventide2 = Recipe.Create(ItemID.FairyQueenRangedItem);
			eventide2.AddIngredient(ItemID.PiercingStarlight);
			eventide2.AddTile(TileID.WorkBenches);
			eventide2.Register();

			Recipe eventide3 = Recipe.Create(ItemID.FairyQueenRangedItem);
			eventide3.AddIngredient(ItemID.RainbowWhip);
			eventide3.AddTile(TileID.WorkBenches);
			eventide3.Register();

			//duke fishron-----

			Recipe bubbleGun1 = Recipe.Create(ItemID.BubbleGun);
			bubbleGun1.AddIngredient(ItemID.Flairon);
			bubbleGun1.AddTile(TileID.WorkBenches);
			bubbleGun1.Register();

			Recipe bubbleGun2 = Recipe.Create(ItemID.BubbleGun);
			bubbleGun2.AddIngredient(ItemID.TempestStaff);
			bubbleGun2.AddTile(TileID.WorkBenches);
			bubbleGun2.Register();

			Recipe bubbleGun3 = Recipe.Create(ItemID.BubbleGun);
			bubbleGun3.AddIngredient(ItemID.RazorbladeTyphoon);
			bubbleGun3.AddTile(TileID.WorkBenches);
			bubbleGun3.Register();

			Recipe bubbleGun4 = Recipe.Create(ItemID.BubbleGun);
			bubbleGun4.AddIngredient(ItemID.Tsunami);
			bubbleGun4.AddTile(TileID.WorkBenches);
			bubbleGun4.Register();

			Recipe flairon1 = Recipe.Create(ItemID.Flairon);
			flairon1.AddIngredient(ItemID.RazorbladeTyphoon);
			flairon1.AddTile(TileID.WorkBenches);
			flairon1.Register();

			Recipe flairon2 = Recipe.Create(ItemID.Flairon);
			flairon2.AddIngredient(ItemID.Flairon);
			flairon2.AddTile(TileID.WorkBenches);
			flairon2.Register();

			Recipe flairon3 = Recipe.Create(ItemID.Flairon);
			flairon3.AddIngredient(ItemID.TempestStaff);
			flairon3.AddTile(TileID.WorkBenches);
			flairon3.Register();

			Recipe flairon4 = Recipe.Create(ItemID.Flairon);
			flairon4.AddIngredient(ItemID.Tsunami);
			flairon4.AddTile(TileID.WorkBenches);
			flairon4.Register();

			Recipe tornadoStaff1 = Recipe.Create(ItemID.TempestStaff);
			tornadoStaff1.AddIngredient(ItemID.BubbleGun);
			tornadoStaff1.AddTile(TileID.WorkBenches);
			tornadoStaff1.Register();

			Recipe tornadoStaff2 = Recipe.Create(ItemID.TempestStaff);
			tornadoStaff2.AddIngredient(ItemID.Flairon);
			tornadoStaff2.AddTile(TileID.WorkBenches);
			tornadoStaff2.Register();

			Recipe tornadoStaff3 = Recipe.Create(ItemID.TempestStaff);
			tornadoStaff3.AddIngredient(ItemID.RazorbladeTyphoon);
			tornadoStaff3.AddTile(TileID.WorkBenches);
			tornadoStaff3.Register();

			Recipe tornadoStaff4 = Recipe.Create(ItemID.TempestStaff);
			tornadoStaff4.AddIngredient(ItemID.Tsunami);
			tornadoStaff4.AddTile(TileID.WorkBenches);
			tornadoStaff4.Register();

			Recipe tsunami1 = Recipe.Create(ItemID.Tsunami);
			tsunami1.AddIngredient(ItemID.BubbleGun);
			tsunami1.AddTile(TileID.WorkBenches);
			tsunami1.Register();

			Recipe tsunami2 = Recipe.Create(ItemID.Tsunami);
			tsunami2.AddIngredient(ItemID.Flairon);
			tsunami2.AddTile(TileID.WorkBenches);
			tsunami2.Register();
			
			Recipe tsunami3 = Recipe.Create(ItemID.Tsunami);
			tsunami3.AddIngredient(ItemID.RazorbladeTyphoon);
			tsunami3.AddTile(TileID.WorkBenches);
			tsunami3.Register();

			Recipe tsunami4 = Recipe.Create(ItemID.Tsunami);
			tsunami4.AddIngredient(ItemID.TempestStaff);
			tsunami4.AddTile(TileID.WorkBenches);
			tsunami4.Register();

			Recipe razor1 = Recipe.Create(ItemID.RazorbladeTyphoon);
			razor1.AddIngredient(ItemID.Flairon);
			razor1.AddTile(TileID.WorkBenches);
			razor1.Register();

			Recipe razor2 = Recipe.Create(ItemID.RazorbladeTyphoon);
			razor2.AddIngredient(ItemID.TempestStaff);
			razor2.AddTile(TileID.WorkBenches);
			razor2.Register();

			Recipe razor3 = Recipe.Create(ItemID.RazorbladeTyphoon);
			razor3.AddIngredient(ItemID.BubbleGun);
			razor3.AddTile(TileID.WorkBenches);
			razor3.Register();

			Recipe razor4 = Recipe.Create(ItemID.RazorbladeTyphoon);
			razor4.AddIngredient(ItemID.Tsunami);
			razor4.AddTile(TileID.WorkBenches);
			razor4.Register();

			//moonlord-----

			Recipe meow1 = Recipe.Create(ItemID.Meowmere);
			meow1.AddIngredient(ItemID.Terrarian);
			meow1.AddTile(TileID.WorkBenches);
			meow1.Register();

			Recipe meow2 = Recipe.Create(ItemID.Meowmere);
			meow2.AddIngredient(ItemID.StarWrath);
			meow2.AddTile(TileID.WorkBenches);
			meow2.Register();

			Recipe meow3 = Recipe.Create(ItemID.Meowmere);
			meow3.AddIngredient(ItemID.SDMG);
			meow3.AddTile(TileID.WorkBenches);
			meow3.Register();

			Recipe meow4 = Recipe.Create(ItemID.Meowmere);
			meow4.AddIngredient(ItemID.LastPrism);
			meow4.AddTile(TileID.WorkBenches);
			meow4.Register();

			Recipe meow5 = Recipe.Create(ItemID.Meowmere);
			meow5.AddIngredient(ItemID.LunarFlareBook);
			meow5.AddTile(TileID.WorkBenches);
			meow5.Register();

			Recipe meow6 = Recipe.Create(ItemID.Meowmere);
			meow6.AddIngredient(ItemID.RainbowCrystalStaff);
			meow6.AddTile(TileID.WorkBenches);
			meow6.Register();

			Recipe meow7 = Recipe.Create(ItemID.Meowmere);
			meow7.AddIngredient(ItemID.MoonlordTurretStaff);
			meow7.AddTile(TileID.WorkBenches);
			meow7.Register();

			Recipe meow8 = Recipe.Create(ItemID.Meowmere);
			meow8.AddIngredient(ItemID.Celeb2);
			meow8.AddTile(TileID.WorkBenches);
			meow8.Register();

			Recipe terrarian1 = Recipe.Create(ItemID.Terrarian);
			terrarian1.AddIngredient(ItemID.Meowmere);
			terrarian1.AddTile(TileID.WorkBenches);
			terrarian1.Register();

			Recipe terrarian2 = Recipe.Create(ItemID.Terrarian);
			terrarian2.AddIngredient(ItemID.StarWrath);
			terrarian2.AddTile(TileID.WorkBenches);
			terrarian2.Register();

			Recipe terrarian3 = Recipe.Create(ItemID.Terrarian);
			terrarian3.AddIngredient(ItemID.SDMG);
			terrarian3.AddTile(TileID.WorkBenches);
			terrarian3.Register();

			Recipe terrarian4 = Recipe.Create(ItemID.Terrarian);
			terrarian4.AddIngredient(ItemID.LastPrism);
			terrarian4.AddTile(TileID.WorkBenches);
			terrarian4.Register();

			Recipe terrarian5 = Recipe.Create(ItemID.Terrarian);
			terrarian5.AddIngredient(ItemID.LunarFlareBook);
			terrarian5.AddTile(TileID.WorkBenches);
			terrarian5.Register();

			Recipe terrarian6 = Recipe.Create(ItemID.Terrarian);
			terrarian6.AddIngredient(ItemID.RainbowCrystalStaff);
			terrarian6.AddTile(TileID.WorkBenches);
			terrarian6.Register();

			Recipe terrarian7 = Recipe.Create(ItemID.Terrarian);
			terrarian7.AddIngredient(ItemID.MoonlordTurretStaff);
			terrarian7.AddTile(TileID.WorkBenches);
			terrarian7.Register();

			Recipe terrarian8 = Recipe.Create(ItemID.Terrarian);
			terrarian8.AddIngredient(ItemID.Celeb2);
			terrarian8.AddTile(TileID.WorkBenches);
			terrarian8.Register();

			Recipe starWrath1 = Recipe.Create(ItemID.StarWrath);
			starWrath1.AddIngredient(ItemID.Meowmere);
			starWrath1.AddTile(TileID.WorkBenches);
			starWrath1.Register();

			Recipe starWrath2 = Recipe.Create(ItemID.StarWrath);
			starWrath2.AddIngredient(ItemID.Terrarian);
			starWrath2.AddTile(TileID.WorkBenches);
			starWrath2.Register();

			Recipe starWrath3 = Recipe.Create(ItemID.StarWrath);
			starWrath3.AddIngredient(ItemID.SDMG);
			starWrath3.AddTile(TileID.WorkBenches);
			starWrath3.Register();

			Recipe starWrath4 = Recipe.Create(ItemID.StarWrath);
			starWrath4.AddIngredient(ItemID.LastPrism);
			starWrath4.AddTile(TileID.WorkBenches);
			starWrath4.Register();

			Recipe starWrath5 = Recipe.Create(ItemID.StarWrath);
			starWrath5.AddIngredient(ItemID.LunarFlareBook);
			starWrath5.AddTile(TileID.WorkBenches);
			starWrath5.Register();

			Recipe starWrath6 = Recipe.Create(ItemID.StarWrath);
			starWrath6.AddIngredient(ItemID.RainbowCrystalStaff);
			starWrath6.AddTile(TileID.WorkBenches);
			starWrath6.Register();

			Recipe starWrath7 = Recipe.Create(ItemID.StarWrath);
			starWrath7.AddIngredient(ItemID.MoonlordTurretStaff);
			starWrath7.AddTile(TileID.WorkBenches);
			starWrath7.Register();

			Recipe starWrath8 = Recipe.Create(ItemID.StarWrath);
			starWrath8.AddIngredient(ItemID.Celeb2);
			starWrath8.AddTile(TileID.WorkBenches);
			starWrath8.Register();

			Recipe sdmg1 = Recipe.Create(ItemID.SDMG);
			sdmg1.AddIngredient(ItemID.Meowmere);
			sdmg1.AddTile(TileID.WorkBenches);
			sdmg1.Register();

			Recipe sdmg2 = Recipe.Create(ItemID.SDMG);
			sdmg2.AddIngredient(ItemID.Terrarian);
			sdmg2.AddTile(TileID.WorkBenches);
			sdmg2.Register();

			Recipe sdmg3 = Recipe.Create(ItemID.SDMG);
			sdmg3.AddIngredient(ItemID.StarWrath);
			sdmg3.AddTile(TileID.WorkBenches);
			sdmg3.Register();

			Recipe sdmg4 = Recipe.Create(ItemID.SDMG);
			sdmg4.AddIngredient(ItemID.LastPrism);
			sdmg4.AddTile(TileID.WorkBenches);
			sdmg4.Register();

			Recipe sdmg5 = Recipe.Create(ItemID.SDMG);
			sdmg5.AddIngredient(ItemID.LunarFlareBook);
			sdmg5.AddTile(TileID.WorkBenches);
			sdmg5.Register();

			Recipe sdmg6 = Recipe.Create(ItemID.SDMG);
			sdmg6.AddIngredient(ItemID.RainbowCrystalStaff);
			sdmg6.AddTile(TileID.WorkBenches);
			sdmg6.Register();

			Recipe sdmg7 = Recipe.Create(ItemID.SDMG);
			sdmg7.AddIngredient(ItemID.MoonlordTurretStaff);
			sdmg7.AddTile(TileID.WorkBenches);
			sdmg7.Register();

			Recipe sdmg8 = Recipe.Create(ItemID.SDMG);
			sdmg8.AddIngredient(ItemID.Celeb2);
			sdmg8.AddTile(TileID.WorkBenches);
			sdmg8.Register();

			Recipe lastPrism1 = Recipe.Create(ItemID.LastPrism);
			lastPrism1.AddIngredient(ItemID.Meowmere);
			lastPrism1.AddTile(TileID.WorkBenches);
			lastPrism1.Register();

			Recipe lastPrism2 = Recipe.Create(ItemID.LastPrism);
			lastPrism2.AddIngredient(ItemID.Terrarian);
			lastPrism2.AddTile(TileID.WorkBenches);
			lastPrism2.Register();

			Recipe lastPrism3 = Recipe.Create(ItemID.LastPrism);
			lastPrism3.AddIngredient(ItemID.StarWrath);
			lastPrism3.AddTile(TileID.WorkBenches);
			lastPrism3.Register();

			Recipe lastPrism4 = Recipe.Create(ItemID.LastPrism);
			lastPrism4.AddIngredient(ItemID.SDMG);
			lastPrism4.AddTile(TileID.WorkBenches);
			lastPrism4.Register();

			Recipe lastPrism5 = Recipe.Create(ItemID.LastPrism);
			lastPrism5.AddIngredient(ItemID.LunarFlareBook);
			lastPrism5.AddTile(TileID.WorkBenches);
			lastPrism5.Register();

			Recipe lastPrism6 = Recipe.Create(ItemID.LastPrism);
			lastPrism6.AddIngredient(ItemID.RainbowCrystalStaff);
			lastPrism6.AddTile(TileID.WorkBenches);
			lastPrism6.Register();

			Recipe lastPrism7 = Recipe.Create(ItemID.LastPrism);
			lastPrism7.AddIngredient(ItemID.MoonlordTurretStaff);
			lastPrism7.AddTile(TileID.WorkBenches);
			lastPrism7.Register();

			Recipe lastPrism8 = Recipe.Create(ItemID.LastPrism);
			lastPrism8.AddIngredient(ItemID.Celeb2);
			lastPrism8.AddTile(TileID.WorkBenches);
			lastPrism8.Register();

			Recipe lunarFlare1 = Recipe.Create(ItemID.LunarFlareBook);
			lunarFlare1.AddIngredient(ItemID.Meowmere);
			lunarFlare1.AddTile(TileID.WorkBenches);
			lunarFlare1.Register();

			Recipe lunarFlare2 = Recipe.Create(ItemID.LunarFlareBook);
			lunarFlare2.AddIngredient(ItemID.Terrarian);
			lunarFlare2.AddTile(TileID.WorkBenches);
			lunarFlare2.Register();

			Recipe lunarFlare3 = Recipe.Create(ItemID.LunarFlareBook);
			lunarFlare3.AddIngredient(ItemID.StarWrath);
			lunarFlare3.AddTile(TileID.WorkBenches);
			lunarFlare3.Register();

			Recipe lunarFlare4 = Recipe.Create(ItemID.LunarFlareBook);
			lunarFlare4.AddIngredient(ItemID.SDMG);
			lunarFlare4.AddTile(TileID.WorkBenches);
			lunarFlare4.Register();

			Recipe lunarFlare5 = Recipe.Create(ItemID.LunarFlareBook);
			lunarFlare5.AddIngredient(ItemID.LastPrism);
			lunarFlare5.AddTile(TileID.WorkBenches);
			lunarFlare5.Register();

			Recipe lunarFlare6 = Recipe.Create(ItemID.LunarFlareBook);
			lunarFlare6.AddIngredient(ItemID.RainbowCrystalStaff);
			lunarFlare6.AddTile(TileID.WorkBenches);
			lunarFlare6.Register();

			Recipe lunarFlare7 = Recipe.Create(ItemID.LunarFlareBook);
			lunarFlare7.AddIngredient(ItemID.MoonlordTurretStaff);
			lunarFlare7.AddTile(TileID.WorkBenches);
			lunarFlare7.Register();

			Recipe lunarFlare8 = Recipe.Create(ItemID.LunarFlareBook);
			lunarFlare8.AddIngredient(ItemID.Celeb2);
			lunarFlare8.AddTile(TileID.WorkBenches);
			lunarFlare8.Register();
		
			Recipe rainbowStaff1 = Recipe.Create(ItemID.RainbowCrystalStaff);
			rainbowStaff1.AddIngredient(ItemID.Meowmere);
			rainbowStaff1.AddTile(TileID.WorkBenches);
			rainbowStaff1.Register();

			Recipe rainbowStaff2 = Recipe.Create(ItemID.RainbowCrystalStaff);
			rainbowStaff2.AddIngredient(ItemID.Terrarian);
			rainbowStaff2.AddTile(TileID.WorkBenches);
			rainbowStaff2.Register();

			Recipe rainbowStaff3 = Recipe.Create(ItemID.RainbowCrystalStaff);
			rainbowStaff3.AddIngredient(ItemID.StarWrath);
			rainbowStaff3.AddTile(TileID.WorkBenches);
			rainbowStaff3.Register();

			Recipe rainbowStaff4 = Recipe.Create(ItemID.RainbowCrystalStaff);
			rainbowStaff4.AddIngredient(ItemID.SDMG);
			rainbowStaff4.AddTile(TileID.WorkBenches);
			rainbowStaff4.Register();

			Recipe rainbowStaff5 = Recipe.Create(ItemID.RainbowCrystalStaff);
			rainbowStaff5.AddIngredient(ItemID.LastPrism);
			rainbowStaff5.AddTile(TileID.WorkBenches);
			rainbowStaff5.Register();

			Recipe rainbowStaff6 = Recipe.Create(ItemID.RainbowCrystalStaff);
			rainbowStaff6.AddIngredient(ItemID.LunarFlareBook);
			rainbowStaff6.AddTile(TileID.WorkBenches);
			rainbowStaff6.Register();

			Recipe rainbowStaff7 = Recipe.Create(ItemID.RainbowCrystalStaff);
			rainbowStaff7.AddIngredient(ItemID.MoonlordTurretStaff);
			rainbowStaff7.AddTile(TileID.WorkBenches);
			rainbowStaff7.Register();

			Recipe rainbowStaff8 = Recipe.Create(ItemID.RainbowCrystalStaff);
			rainbowStaff8.AddIngredient(ItemID.Celeb2);
			rainbowStaff8.AddTile(TileID.WorkBenches);
			rainbowStaff8.Register();

			Recipe lunarStaff1 = Recipe.Create(ItemID.MoonlordTurretStaff);
			lunarStaff1.AddIngredient(ItemID.Meowmere);
			lunarStaff1.AddTile(TileID.WorkBenches);
			lunarStaff1.Register();

			Recipe lunarStaff2 = Recipe.Create(ItemID.MoonlordTurretStaff);
			lunarStaff2.AddIngredient(ItemID.Terrarian);
			lunarStaff2.AddTile(TileID.WorkBenches);
			lunarStaff2.Register();

			Recipe lunarStaff3 = Recipe.Create(ItemID.MoonlordTurretStaff);
			lunarStaff3.AddIngredient(ItemID.StarWrath);
			lunarStaff3.AddTile(TileID.WorkBenches);
			lunarStaff3.Register();

			Recipe lunarStaff4 = Recipe.Create(ItemID.MoonlordTurretStaff);
			lunarStaff4.AddIngredient(ItemID.SDMG);
			lunarStaff4.AddTile(TileID.WorkBenches);
			lunarStaff4.Register();

			Recipe lunarStaff5 = Recipe.Create(ItemID.MoonlordTurretStaff);
			lunarStaff5.AddIngredient(ItemID.LastPrism);
			lunarStaff5.AddTile(TileID.WorkBenches);
			lunarStaff5.Register();

			Recipe lunarStaff6 = Recipe.Create(ItemID.MoonlordTurretStaff);
			lunarStaff6.AddIngredient(ItemID.LunarFlareBook);
			lunarStaff6.AddTile(TileID.WorkBenches);
			lunarStaff6.Register();

			Recipe lunarStaff7 = Recipe.Create(ItemID.MoonlordTurretStaff);
			lunarStaff7.AddIngredient(ItemID.RainbowCrystalStaff);
			lunarStaff7.AddTile(TileID.WorkBenches);
			lunarStaff7.Register();

			Recipe lunarStaff8 = Recipe.Create(ItemID.MoonlordTurretStaff);
			lunarStaff8.AddIngredient(ItemID.Celeb2);
			lunarStaff8.AddTile(TileID.WorkBenches);
			lunarStaff8.Register();

			Recipe celebmk21 = Recipe.Create(ItemID.Celeb2);
			celebmk21.AddIngredient(ItemID.Meowmere);
			celebmk21.AddTile(TileID.WorkBenches);
			celebmk21.Register();

			Recipe celebmk22 = Recipe.Create(ItemID.Celeb2);
			celebmk22.AddIngredient(ItemID.Terrarian);
			celebmk22.AddTile(TileID.WorkBenches);
			celebmk22.Register();

			Recipe celebmk23 = Recipe.Create(ItemID.Celeb2);
			celebmk23.AddIngredient(ItemID.StarWrath);
			celebmk23.AddTile(TileID.WorkBenches);
			celebmk23.Register();

			Recipe celebmk24 = Recipe.Create(ItemID.Celeb2);
			celebmk24.AddIngredient(ItemID.SDMG);
			celebmk24.AddTile(TileID.WorkBenches);
			celebmk24.Register();

			Recipe celebmk25 = Recipe.Create(ItemID.Celeb2);
			celebmk25.AddIngredient(ItemID.LastPrism);
			celebmk25.AddTile(TileID.WorkBenches);
			celebmk25.Register();

			Recipe celebmk26 = Recipe.Create(ItemID.Celeb2);
			celebmk26.AddIngredient(ItemID.LunarFlareBook);
			celebmk26.AddTile(TileID.WorkBenches);
			celebmk26.Register();

			Recipe celebmk27 = Recipe.Create(ItemID.Celeb2);
			celebmk27.AddIngredient(ItemID.RainbowCrystalStaff);
			celebmk27.AddTile(TileID.WorkBenches);
			celebmk27.Register();

			Recipe celebmk28 = Recipe.Create(ItemID.Celeb2);
			celebmk28.AddIngredient(ItemID.MoonlordTurretStaff);
			celebmk28.AddTile(TileID.WorkBenches);
			celebmk28.Register();

			//mini-bosses-------------------------------------------

			//martian saucer

			Recipe Xenopopper1 = Recipe.Create(ItemID.Xenopopper);
			Xenopopper1.AddIngredient(ItemID.XenoStaff);
			Xenopopper1.AddTile(TileID.WorkBenches);
			Xenopopper1.Register();

			Recipe Xenopopper2 = Recipe.Create(ItemID.Xenopopper);
			Xenopopper2.AddIngredient(ItemID.LaserMachinegun);
			Xenopopper2.AddTile(TileID.WorkBenches);
			Xenopopper2.Register();

			Recipe Xenopopper3 = Recipe.Create(ItemID.Xenopopper);
			Xenopopper3.AddIngredient(ItemID.ElectrosphereLauncher);
			Xenopopper3.AddTile(TileID.WorkBenches);
			Xenopopper3.Register();

			Recipe Xenopopper4 = Recipe.Create(ItemID.Xenopopper);
			Xenopopper4.AddIngredient(ItemID.InfluxWaver);
			Xenopopper4.AddTile(TileID.WorkBenches);
			Xenopopper4.Register();

			Recipe Xenopopper5 = Recipe.Create(ItemID.Xenopopper);
			Xenopopper5.AddIngredient(ItemID.CosmicCarKey);
			Xenopopper5.AddTile(TileID.WorkBenches);
			Xenopopper5.Register();

			Recipe XenoStaff1 = Recipe.Create(ItemID.XenoStaff);
			XenoStaff1.AddIngredient(ItemID.Xenopopper);
			XenoStaff1.AddTile(TileID.WorkBenches);
			XenoStaff1.Register();

			Recipe XenoStaff2 = Recipe.Create(ItemID.XenoStaff);
			XenoStaff2.AddIngredient(ItemID.LaserMachinegun);
			XenoStaff2.AddTile(TileID.WorkBenches);
			XenoStaff2.Register();

			Recipe XenoStaff3 = Recipe.Create(ItemID.XenoStaff);
			XenoStaff3.AddIngredient(ItemID.ElectrosphereLauncher);
			XenoStaff3.AddTile(TileID.WorkBenches);
			XenoStaff3.Register();

			Recipe XenoStaff4 = Recipe.Create(ItemID.XenoStaff);
			XenoStaff4.AddIngredient(ItemID.InfluxWaver);
			XenoStaff4.AddTile(TileID.WorkBenches);
			XenoStaff4.Register();

			Recipe XenoStaff5 = Recipe.Create(ItemID.XenoStaff);
			XenoStaff5.AddIngredient(ItemID.CosmicCarKey);
			XenoStaff5.AddTile(TileID.WorkBenches);
			XenoStaff5.Register();

			Recipe LaserMachinegun1 = Recipe.Create(ItemID.LaserMachinegun);
			LaserMachinegun1.AddIngredient(ItemID.Xenopopper);
			LaserMachinegun1.AddTile(TileID.WorkBenches);
			LaserMachinegun1.Register();

			Recipe LaserMachinegun2 = Recipe.Create(ItemID.LaserMachinegun);
			LaserMachinegun2.AddIngredient(ItemID.XenoStaff);
			LaserMachinegun2.AddTile(TileID.WorkBenches);
			LaserMachinegun2.Register();

			Recipe LaserMachinegun3 = Recipe.Create(ItemID.LaserMachinegun);
			LaserMachinegun3.AddIngredient(ItemID.ElectrosphereLauncher);
			LaserMachinegun3.AddTile(TileID.WorkBenches);
			LaserMachinegun3.Register();

			Recipe LaserMachinegun4 = Recipe.Create(ItemID.LaserMachinegun);
			LaserMachinegun4.AddIngredient(ItemID.InfluxWaver);
			LaserMachinegun4.AddTile(TileID.WorkBenches);
			LaserMachinegun4.Register();

			Recipe LaserMachinegun5 = Recipe.Create(ItemID.LaserMachinegun);
			LaserMachinegun5.AddIngredient(ItemID.CosmicCarKey);
			LaserMachinegun5.AddTile(TileID.WorkBenches);
			LaserMachinegun5.Register();

			Recipe ElectrosphereLauncher1 = Recipe.Create(ItemID.ElectrosphereLauncher);
			ElectrosphereLauncher1.AddIngredient(ItemID.Xenopopper);
			ElectrosphereLauncher1.AddTile(TileID.WorkBenches);
			ElectrosphereLauncher1.Register();

			Recipe ElectrosphereLauncher2 = Recipe.Create(ItemID.ElectrosphereLauncher);
			ElectrosphereLauncher2.AddIngredient(ItemID.XenoStaff);
			ElectrosphereLauncher2.AddTile(TileID.WorkBenches);
			ElectrosphereLauncher2.Register();

			Recipe ElectrosphereLauncher3 = Recipe.Create(ItemID.ElectrosphereLauncher);
			ElectrosphereLauncher3.AddIngredient(ItemID.LaserMachinegun);
			ElectrosphereLauncher3.AddTile(TileID.WorkBenches);
			ElectrosphereLauncher3.Register();

			Recipe ElectrosphereLauncher4 = Recipe.Create(ItemID.ElectrosphereLauncher);
			ElectrosphereLauncher4.AddIngredient(ItemID.InfluxWaver);
			ElectrosphereLauncher4.AddTile(TileID.WorkBenches);
			ElectrosphereLauncher4.Register();

			Recipe ElectrosphereLauncher5 = Recipe.Create(ItemID.ElectrosphereLauncher);
			ElectrosphereLauncher5.AddIngredient(ItemID.CosmicCarKey);
			ElectrosphereLauncher5.AddTile(TileID.WorkBenches);
			ElectrosphereLauncher5.Register();

			Recipe InfluxWaver1 = Recipe.Create(ItemID.InfluxWaver);
			InfluxWaver1.AddIngredient(ItemID.Xenopopper);
			InfluxWaver1.AddTile(TileID.WorkBenches);
			InfluxWaver1.Register();

			Recipe InfluxWaver2 = Recipe.Create(ItemID.InfluxWaver);
			InfluxWaver2.AddIngredient(ItemID.XenoStaff);
			InfluxWaver2.AddTile(TileID.WorkBenches);
			InfluxWaver2.Register();

			Recipe InfluxWaver3 = Recipe.Create(ItemID.InfluxWaver);
			InfluxWaver3.AddIngredient(ItemID.LaserMachinegun);
			InfluxWaver3.AddTile(TileID.WorkBenches);
			InfluxWaver3.Register();

			Recipe InfluxWaver4 = Recipe.Create(ItemID.InfluxWaver);
			InfluxWaver4.AddIngredient(ItemID.ElectrosphereLauncher);
			InfluxWaver4.AddTile(TileID.WorkBenches);
			InfluxWaver4.Register();

			Recipe InfluxWaver5 = Recipe.Create(ItemID.InfluxWaver);
			InfluxWaver5.AddIngredient(ItemID.CosmicCarKey);
			InfluxWaver5.AddTile(TileID.WorkBenches);
			InfluxWaver5.Register();

			Recipe CosmicCarKey1 = Recipe.Create(ItemID.CosmicCarKey);
			CosmicCarKey1.AddIngredient(ItemID.Xenopopper);
			CosmicCarKey1.AddTile(TileID.WorkBenches);
			CosmicCarKey1.Register();

			Recipe CosmicCarKey2 = Recipe.Create(ItemID.CosmicCarKey);
			CosmicCarKey2.AddIngredient(ItemID.XenoStaff);
			CosmicCarKey2.AddTile(TileID.WorkBenches);
			CosmicCarKey2.Register();

			Recipe CosmicCarKey3 = Recipe.Create(ItemID.CosmicCarKey);
			CosmicCarKey3.AddIngredient(ItemID.LaserMachinegun);
			CosmicCarKey3.AddTile(TileID.WorkBenches);
			CosmicCarKey3.Register();

			Recipe CosmicCarKey4 = Recipe.Create(ItemID.CosmicCarKey);
			CosmicCarKey4.AddIngredient(ItemID.ElectrosphereLauncher);
			CosmicCarKey4.AddTile(TileID.WorkBenches);
			CosmicCarKey4.Register();

			Recipe CosmicCarKey5 = Recipe.Create(ItemID.CosmicCarKey);
			CosmicCarKey5.AddIngredient(ItemID.InfluxWaver);
			CosmicCarKey5.AddTile(TileID.WorkBenches);
			CosmicCarKey5.Register();

			//hallowed mimic

			Recipe flyKnife1 = Recipe.Create(ItemID.FlyingKnife);
			flyKnife1.AddIngredient(ItemID.DaedalusStormbow);
			flyKnife1.AddTile(TileID.WorkBenches);
			flyKnife1.Register();

			Recipe flyKnife2 = Recipe.Create(ItemID.FlyingKnife);
			flyKnife2.AddIngredient(ItemID.IlluminantHook);
			flyKnife2.AddTile(TileID.WorkBenches);
			flyKnife2.Register();

			Recipe flyKnife3 = Recipe.Create(ItemID.FlyingKnife);
			flyKnife3.AddIngredient(ItemID.CrystalVileShard);
			flyKnife3.AddTile(TileID.WorkBenches);
			flyKnife3.Register();

			Recipe bowthatyouwant1 = Recipe.Create(ItemID.DaedalusStormbow);
			bowthatyouwant1.AddIngredient(ItemID.FlyingKnife);
			bowthatyouwant1.AddTile(TileID.WorkBenches);
			bowthatyouwant1.Register();

			Recipe bowthatyouwant2 = Recipe.Create(ItemID.DaedalusStormbow);
			bowthatyouwant2.AddIngredient(ItemID.IlluminantHook);
			bowthatyouwant2.AddTile(TileID.WorkBenches);
			bowthatyouwant2.Register();

			Recipe bowthatyouwant3 = Recipe.Create(ItemID.DaedalusStormbow);
			bowthatyouwant3.AddIngredient(ItemID.CrystalVileShard);
			bowthatyouwant3.AddTile(TileID.WorkBenches);
			bowthatyouwant3.Register();

			Recipe illumHook1 = Recipe.Create(ItemID.IlluminantHook);
			illumHook1.AddIngredient(ItemID.FlyingKnife);
			illumHook1.AddTile(TileID.WorkBenches);
			illumHook1.Register();

			Recipe illumHook2 = Recipe.Create(ItemID.IlluminantHook);
			illumHook2.AddIngredient(ItemID.DaedalusStormbow);
			illumHook2.AddTile(TileID.WorkBenches);
			illumHook2.Register();

			Recipe illumHook3 = Recipe.Create(ItemID.IlluminantHook);
			illumHook3.AddIngredient(ItemID.CrystalVileShard);
			illumHook3.AddTile(TileID.WorkBenches);
			illumHook3.Register();

			Recipe CryVileShard1 = Recipe.Create(ItemID.CrystalVileShard);
			CryVileShard1.AddIngredient(ItemID.FlyingKnife);
			CryVileShard1.AddTile(TileID.WorkBenches);
			CryVileShard1.Register();

			Recipe CryVileShard2 = Recipe.Create(ItemID.CrystalVileShard);
			CryVileShard2.AddIngredient(ItemID.DaedalusStormbow);
			CryVileShard2.AddTile(TileID.WorkBenches);
			CryVileShard2.Register();

			Recipe CryVileShard3 = Recipe.Create(ItemID.CrystalVileShard);
			CryVileShard3.AddIngredient(ItemID.IlluminantHook);
			CryVileShard3.AddTile(TileID.WorkBenches);
			CryVileShard3.Register();

			Recipe ChainGuio = Recipe.Create(ItemID.ChainGuillotines);
			ChainGuio.AddIngredient(ItemID.ClingerStaff);
			ChainGuio.AddTile(TileID.WorkBenches);
			ChainGuio.Register();

			Recipe ChainGuio2 = Recipe.Create(ItemID.ChainGuillotines);
			ChainGuio2.AddIngredient(ItemID.WormHook);
			ChainGuio2.AddTile(TileID.WorkBenches);
			ChainGuio2.Register();

			Recipe ChainGuio3 = Recipe.Create(ItemID.ChainGuillotines);
			ChainGuio3.AddIngredient(ItemID.DartRifle);
			ChainGuio3.AddTile(TileID.WorkBenches);
			ChainGuio3.Register();

			Recipe ChainGuio4 = Recipe.Create(ItemID.ChainGuillotines);
			ChainGuio4.AddIngredient(ItemID.PutridScent);
			ChainGuio4.AddTile(TileID.WorkBenches);
			ChainGuio4.Register();

			Recipe ChainGuio5 = Recipe.Create(ItemID.ChainGuillotines);
			ChainGuio5.AddIngredient(ItemID.TendonHook);
			ChainGuio5.AddTile(TileID.WorkBenches);
			ChainGuio5.Register();

			Recipe ChainGuio6 = Recipe.Create(ItemID.ChainGuillotines);
			ChainGuio6.AddIngredient(ItemID.FleshKnuckles);
			ChainGuio6.AddTile(TileID.WorkBenches);
			ChainGuio6.Register();

			Recipe ChainGuio7 = Recipe.Create(ItemID.ChainGuillotines);
			ChainGuio7.AddIngredient(ItemID.SoulDrain);
			ChainGuio7.AddTile(TileID.WorkBenches);
			ChainGuio7.Register();

			Recipe ChainGuio8 = Recipe.Create(ItemID.ChainGuillotines);
			ChainGuio8.AddIngredient(ItemID.FetidBaghnakhs);
			ChainGuio8.AddTile(TileID.WorkBenches);
			ChainGuio8.Register();

			Recipe ChainGuio9 = Recipe.Create(ItemID.ChainGuillotines);
			ChainGuio9.AddIngredient(ItemID.DartPistol);
			ChainGuio9.AddTile(TileID.WorkBenches);
			ChainGuio9.Register();

			Recipe ClingerStaff = Recipe.Create(ItemID.ClingerStaff);
			ClingerStaff.AddIngredient(ItemID.ChainGuillotines);
			ClingerStaff.AddTile(TileID.WorkBenches);
			ClingerStaff.Register();

			Recipe ClingerStaff2 = Recipe.Create(ItemID.ClingerStaff);
			ClingerStaff2.AddIngredient(ItemID.WormHook);
			ClingerStaff2.AddTile(TileID.WorkBenches);
			ClingerStaff2.Register();

			Recipe ClingerStaff3 = Recipe.Create(ItemID.ClingerStaff);
			ClingerStaff3.AddIngredient(ItemID.DartRifle);
			ClingerStaff3.AddTile(TileID.WorkBenches);
			ClingerStaff3.Register();

			Recipe ClingerStaff4 = Recipe.Create(ItemID.ClingerStaff);
			ClingerStaff4.AddIngredient(ItemID.PutridScent);
			ClingerStaff4.AddTile(TileID.WorkBenches);
			ClingerStaff4.Register();

			Recipe ClingerStaff5 = Recipe.Create(ItemID.ClingerStaff);
			ClingerStaff5.AddIngredient(ItemID.TendonHook);
			ClingerStaff5.AddTile(TileID.WorkBenches);
			ClingerStaff5.Register();

			Recipe ClingerStaff6 = Recipe.Create(ItemID.ClingerStaff);
			ClingerStaff6.AddIngredient(ItemID.FleshKnuckles);
			ClingerStaff6.AddTile(TileID.WorkBenches);
			ClingerStaff6.Register();

			Recipe ClingerStaff7 = Recipe.Create(ItemID.ClingerStaff);
			ClingerStaff7.AddIngredient(ItemID.SoulDrain);
			ClingerStaff7.AddTile(TileID.WorkBenches);
			ClingerStaff7.Register();

			Recipe ClingerStaff8 = Recipe.Create(ItemID.ClingerStaff);
			ClingerStaff8.AddIngredient(ItemID.FetidBaghnakhs);
			ClingerStaff8.AddTile(TileID.WorkBenches);
			ClingerStaff8.Register();

			Recipe ClingerStaff9 = Recipe.Create(ItemID.ClingerStaff);
			ClingerStaff9.AddIngredient(ItemID.DartPistol);
			ClingerStaff9.AddTile(TileID.WorkBenches);
			ClingerStaff9.Register();

			Recipe WormHook = Recipe.Create(ItemID.WormHook);
			WormHook.AddIngredient(ItemID.ChainGuillotines);
			WormHook.AddTile(TileID.WorkBenches);
			WormHook.Register();

			Recipe WormHook2 = Recipe.Create(ItemID.WormHook);
			WormHook2.AddIngredient(ItemID.ClingerStaff);
			WormHook2.AddTile(TileID.WorkBenches);
			WormHook2.Register();

			Recipe WormHook3 = Recipe.Create(ItemID.WormHook);
			WormHook3.AddIngredient(ItemID.DartRifle);
			WormHook3.AddTile(TileID.WorkBenches);
			WormHook3.Register();

			Recipe WormHook4 = Recipe.Create(ItemID.WormHook);
			WormHook4.AddIngredient(ItemID.PutridScent);
			WormHook4.AddTile(TileID.WorkBenches);
			WormHook4.Register();

			Recipe WormHook5 = Recipe.Create(ItemID.WormHook);
			WormHook5.AddIngredient(ItemID.TendonHook);
			WormHook5.AddTile(TileID.WorkBenches);
			WormHook5.Register();

			Recipe WormHook6 = Recipe.Create(ItemID.WormHook);
			WormHook6.AddIngredient(ItemID.FleshKnuckles);
			WormHook6.AddTile(TileID.WorkBenches);
			WormHook6.Register();

			Recipe WormHook7 = Recipe.Create(ItemID.WormHook);
			WormHook7.AddIngredient(ItemID.SoulDrain);
			WormHook7.AddTile(TileID.WorkBenches);
			WormHook7.Register();

			Recipe WormHook8 = Recipe.Create(ItemID.WormHook);
			WormHook8.AddIngredient(ItemID.FetidBaghnakhs);
			WormHook8.AddTile(TileID.WorkBenches);
			WormHook8.Register();

			Recipe WormHook9 = Recipe.Create(ItemID.WormHook);
			WormHook9.AddIngredient(ItemID.DartPistol);
			WormHook9.AddTile(TileID.WorkBenches);
			WormHook9.Register();

			Recipe DartRifle = Recipe.Create(ItemID.WormHook);
			DartRifle.AddIngredient(ItemID.ChainGuillotines);
			DartRifle.AddTile(TileID.WorkBenches);
			DartRifle.Register();

			Recipe DartRifle2 = Recipe.Create(ItemID.DartRifle);
			DartRifle2.AddIngredient(ItemID.ClingerStaff);
			DartRifle2.AddTile(TileID.WorkBenches);
			DartRifle2.Register();

			Recipe DartRifle3 = Recipe.Create(ItemID.DartRifle);
			DartRifle3.AddIngredient(ItemID.WormHook);
			DartRifle3.AddTile(TileID.WorkBenches);
			DartRifle3.Register();

			Recipe DartRifle4 = Recipe.Create(ItemID.DartRifle);
			DartRifle4.AddIngredient(ItemID.PutridScent);
			DartRifle4.AddTile(TileID.WorkBenches);
			DartRifle4.Register();

			Recipe DartRifle5 = Recipe.Create(ItemID.DartRifle);
			DartRifle5.AddIngredient(ItemID.TendonHook);
			DartRifle5.AddTile(TileID.WorkBenches);
			DartRifle5.Register();

			Recipe DartRifle6 = Recipe.Create(ItemID.DartRifle);
			DartRifle6.AddIngredient(ItemID.FleshKnuckles);
			DartRifle6.AddTile(TileID.WorkBenches);
			DartRifle6.Register();

			Recipe DartRifle7 = Recipe.Create(ItemID.DartRifle);
			DartRifle7.AddIngredient(ItemID.SoulDrain);
			DartRifle7.AddTile(TileID.WorkBenches);
			DartRifle7.Register();

			Recipe DartRifle8 = Recipe.Create(ItemID.DartRifle);
			DartRifle8.AddIngredient(ItemID.FetidBaghnakhs);
			DartRifle8.AddTile(TileID.WorkBenches);
			DartRifle8.Register();

			Recipe DartRifle9 = Recipe.Create(ItemID.DartRifle);
			DartRifle9.AddIngredient(ItemID.DartPistol);
			DartRifle9.AddTile(TileID.WorkBenches);
			DartRifle9.Register();

			Recipe PutridScent = Recipe.Create(ItemID.PutridScent);
			PutridScent.AddIngredient(ItemID.ChainGuillotines);
			PutridScent.AddTile(TileID.WorkBenches);
			PutridScent.Register();

			Recipe PutridScent2 = Recipe.Create(ItemID.PutridScent);
			PutridScent2.AddIngredient(ItemID.ClingerStaff);
			PutridScent2.AddTile(TileID.WorkBenches);
			PutridScent2.Register();

			Recipe PutridScent3 = Recipe.Create(ItemID.PutridScent);
			PutridScent3.AddIngredient(ItemID.WormHook);
			PutridScent3.AddTile(TileID.WorkBenches);
			PutridScent3.Register();

			Recipe PutridScent4 = Recipe.Create(ItemID.PutridScent);
			PutridScent4.AddIngredient(ItemID.DartRifle);
			PutridScent4.AddTile(TileID.WorkBenches);
			PutridScent4.Register();

			Recipe PutridScent5 = Recipe.Create(ItemID.PutridScent);
			PutridScent5.AddIngredient(ItemID.TendonHook);
			PutridScent5.AddTile(TileID.WorkBenches);
			PutridScent5.Register();

			Recipe PutridScent6 = Recipe.Create(ItemID.PutridScent);
			PutridScent6.AddIngredient(ItemID.FleshKnuckles);
			PutridScent6.AddTile(TileID.WorkBenches);
			PutridScent6.Register();

			Recipe PutridScent7 = Recipe.Create(ItemID.PutridScent);
			PutridScent7.AddIngredient(ItemID.SoulDrain);
			PutridScent7.AddTile(TileID.WorkBenches);
			PutridScent7.Register();

			Recipe PutridScent8 = Recipe.Create(ItemID.PutridScent);
			PutridScent8.AddIngredient(ItemID.FetidBaghnakhs);
			PutridScent8.AddTile(TileID.WorkBenches);
			PutridScent8.Register();

			Recipe PutridScent9 = Recipe.Create(ItemID.PutridScent);
			PutridScent9.AddIngredient(ItemID.DartPistol);
			PutridScent9.AddTile(TileID.WorkBenches);
			PutridScent9.Register();

			Recipe TendonHook = Recipe.Create(ItemID.TendonHook);
			TendonHook.AddIngredient(ItemID.ChainGuillotines);
			TendonHook.AddTile(TileID.WorkBenches);
			TendonHook.Register();

			Recipe TendonHook2 = Recipe.Create(ItemID.TendonHook);
			TendonHook2.AddIngredient(ItemID.ClingerStaff);
			TendonHook2.AddTile(TileID.WorkBenches);
			TendonHook2.Register();

			Recipe TendonHook3 = Recipe.Create(ItemID.TendonHook);
			TendonHook3.AddIngredient(ItemID.WormHook);
			TendonHook3.AddTile(TileID.WorkBenches);
			TendonHook3.Register();

			Recipe TendonHook4 = Recipe.Create(ItemID.TendonHook);
			TendonHook4.AddIngredient(ItemID.DartRifle);
			TendonHook4.AddTile(TileID.WorkBenches);
			TendonHook4.Register();

			Recipe TendonHook5 = Recipe.Create(ItemID.TendonHook);
			TendonHook5.AddIngredient(ItemID.PutridScent);
			TendonHook5.AddTile(TileID.WorkBenches);
			TendonHook5.Register();

			Recipe TendonHook6 = Recipe.Create(ItemID.TendonHook);
			TendonHook6.AddIngredient(ItemID.FleshKnuckles);
			TendonHook6.AddTile(TileID.WorkBenches);
			TendonHook6.Register();

			Recipe TendonHook7 = Recipe.Create(ItemID.TendonHook);
			TendonHook7.AddIngredient(ItemID.SoulDrain);
			TendonHook7.AddTile(TileID.WorkBenches);
			TendonHook7.Register();

			Recipe TendonHook8 = Recipe.Create(ItemID.TendonHook);
			TendonHook8.AddIngredient(ItemID.FetidBaghnakhs);
			TendonHook8.AddTile(TileID.WorkBenches);
			TendonHook8.Register();

			Recipe TendonHook9 = Recipe.Create(ItemID.TendonHook);
			TendonHook9.AddIngredient(ItemID.DartPistol);
			TendonHook9.AddTile(TileID.WorkBenches);
			TendonHook9.Register();

			Recipe FleshKnuckles = Recipe.Create(ItemID.FleshKnuckles);
			FleshKnuckles.AddIngredient(ItemID.ChainGuillotines);
			FleshKnuckles.AddTile(TileID.WorkBenches);
			FleshKnuckles.Register();

			Recipe FleshKnuckles2 = Recipe.Create(ItemID.FleshKnuckles);
			FleshKnuckles2.AddIngredient(ItemID.ClingerStaff);
			FleshKnuckles2.AddTile(TileID.WorkBenches);
			FleshKnuckles2.Register();

			Recipe FleshKnuckles3 = Recipe.Create(ItemID.FleshKnuckles);
			FleshKnuckles3.AddIngredient(ItemID.WormHook);
			FleshKnuckles3.AddTile(TileID.WorkBenches);
			FleshKnuckles3.Register();

			Recipe FleshKnuckles4 = Recipe.Create(ItemID.FleshKnuckles);
			FleshKnuckles4.AddIngredient(ItemID.DartRifle);
			FleshKnuckles4.AddTile(TileID.WorkBenches);
			FleshKnuckles4.Register();

			Recipe FleshKnuckles5 = Recipe.Create(ItemID.FleshKnuckles);
			FleshKnuckles5.AddIngredient(ItemID.PutridScent);
			FleshKnuckles5.AddTile(TileID.WorkBenches);
			FleshKnuckles5.Register();

			Recipe FleshKnuckles6 = Recipe.Create(ItemID.FleshKnuckles);
			FleshKnuckles6.AddIngredient(ItemID.TendonHook);
			FleshKnuckles6.AddTile(TileID.WorkBenches);
			FleshKnuckles6.Register();

			Recipe FleshKnuckles7 = Recipe.Create(ItemID.FleshKnuckles);
			FleshKnuckles7.AddIngredient(ItemID.SoulDrain);
			FleshKnuckles7.AddTile(TileID.WorkBenches);
			FleshKnuckles7.Register();

			Recipe FleshKnuckles8 = Recipe.Create(ItemID.FleshKnuckles);
			FleshKnuckles8.AddIngredient(ItemID.FetidBaghnakhs);
			FleshKnuckles8.AddTile(TileID.WorkBenches);
			FleshKnuckles8.Register();

			Recipe FleshKnuckles9 = Recipe.Create(ItemID.FleshKnuckles);
			FleshKnuckles9.AddIngredient(ItemID.DartPistol);
			FleshKnuckles9.AddTile(TileID.WorkBenches);
			FleshKnuckles9.Register();

			Recipe SoulDrain = Recipe.Create(ItemID.SoulDrain);
			SoulDrain.AddIngredient(ItemID.ChainGuillotines);
			SoulDrain.AddTile(TileID.WorkBenches);
			SoulDrain.Register();

			Recipe SoulDrain2 = Recipe.Create(ItemID.SoulDrain);
			SoulDrain2.AddIngredient(ItemID.ClingerStaff);
			SoulDrain2.AddTile(TileID.WorkBenches);
			SoulDrain2.Register();

			Recipe SoulDrain3 = Recipe.Create(ItemID.SoulDrain);
			SoulDrain3.AddIngredient(ItemID.WormHook);
			SoulDrain3.AddTile(TileID.WorkBenches);
			SoulDrain3.Register();

			Recipe SoulDrain4 = Recipe.Create(ItemID.SoulDrain);
			SoulDrain4.AddIngredient(ItemID.DartRifle);
			SoulDrain4.AddTile(TileID.WorkBenches);
			SoulDrain4.Register();

			Recipe SoulDrain5 = Recipe.Create(ItemID.SoulDrain);
			SoulDrain5.AddIngredient(ItemID.PutridScent);
			SoulDrain5.AddTile(TileID.WorkBenches);
			SoulDrain5.Register();

			Recipe SoulDrain6 = Recipe.Create(ItemID.SoulDrain);
			SoulDrain6.AddIngredient(ItemID.TendonHook);
			SoulDrain6.AddTile(TileID.WorkBenches);
			SoulDrain6.Register();

			Recipe SoulDrain7 = Recipe.Create(ItemID.SoulDrain);
			SoulDrain7.AddIngredient(ItemID.FleshKnuckles);
			SoulDrain7.AddTile(TileID.WorkBenches);
			SoulDrain7.Register();

			Recipe SoulDrain8 = Recipe.Create(ItemID.SoulDrain);
			SoulDrain8.AddIngredient(ItemID.FetidBaghnakhs);
			SoulDrain8.AddTile(TileID.WorkBenches);
			SoulDrain8.Register();

			Recipe SoulDrain9 = Recipe.Create(ItemID.SoulDrain);
			SoulDrain9.AddIngredient(ItemID.DartPistol);
			SoulDrain9.AddTile(TileID.WorkBenches);
			SoulDrain9.Register();

			Recipe FetidBaghnakhs = Recipe.Create(ItemID.FetidBaghnakhs);
			FetidBaghnakhs.AddIngredient(ItemID.ChainGuillotines);
			FetidBaghnakhs.AddTile(TileID.WorkBenches);
			FetidBaghnakhs.Register();

			Recipe FetidBaghnakhs2 = Recipe.Create(ItemID.FetidBaghnakhs);
			FetidBaghnakhs2.AddIngredient(ItemID.ClingerStaff);
			FetidBaghnakhs2.AddTile(TileID.WorkBenches);
			FetidBaghnakhs2.Register();

			Recipe FetidBaghnakhs3 = Recipe.Create(ItemID.FetidBaghnakhs);
			FetidBaghnakhs3.AddIngredient(ItemID.WormHook);
			FetidBaghnakhs3.AddTile(TileID.WorkBenches);
			FetidBaghnakhs3.Register();

			Recipe FetidBaghnakhs4 = Recipe.Create(ItemID.FetidBaghnakhs);
			FetidBaghnakhs4.AddIngredient(ItemID.DartRifle);
			FetidBaghnakhs4.AddTile(TileID.WorkBenches);
			FetidBaghnakhs4.Register();

			Recipe FetidBaghnakhs5 = Recipe.Create(ItemID.FetidBaghnakhs);
			FetidBaghnakhs5.AddIngredient(ItemID.PutridScent);
			FetidBaghnakhs5.AddTile(TileID.WorkBenches);
			FetidBaghnakhs5.Register();

			Recipe FetidBaghnakhs6 = Recipe.Create(ItemID.FetidBaghnakhs);
			FetidBaghnakhs6.AddIngredient(ItemID.TendonHook);
			FetidBaghnakhs6.AddTile(TileID.WorkBenches);
			FetidBaghnakhs6.Register();

			Recipe FetidBaghnakhs7 = Recipe.Create(ItemID.FetidBaghnakhs);
			FetidBaghnakhs7.AddIngredient(ItemID.FleshKnuckles);
			FetidBaghnakhs7.AddTile(TileID.WorkBenches);
			FetidBaghnakhs7.Register();

			Recipe FetidBaghnakhs8 = Recipe.Create(ItemID.FetidBaghnakhs);
			FetidBaghnakhs8.AddIngredient(ItemID.SoulDrain);
			FetidBaghnakhs8.AddTile(TileID.WorkBenches);
			FetidBaghnakhs8.Register();

			Recipe FetidBaghnakhs9 = Recipe.Create(ItemID.FetidBaghnakhs);
			FetidBaghnakhs9.AddIngredient(ItemID.DartPistol);
			FetidBaghnakhs9.AddTile(TileID.WorkBenches);
			FetidBaghnakhs9.Register();

			Recipe DartPistol = Recipe.Create(ItemID.DartPistol);
			DartPistol.AddIngredient(ItemID.ChainGuillotines);
			DartPistol.AddTile(TileID.WorkBenches);
			DartPistol.Register();

			Recipe DartPistol2 = Recipe.Create(ItemID.DartPistol);
			DartPistol2.AddIngredient(ItemID.ClingerStaff);
			DartPistol2.AddTile(TileID.WorkBenches);
			DartPistol2.Register();

			Recipe DartPistol3 = Recipe.Create(ItemID.DartPistol);
			DartPistol3.AddIngredient(ItemID.WormHook);
			DartPistol3.AddTile(TileID.WorkBenches);
			DartPistol3.Register();

			Recipe DartPistol4 = Recipe.Create(ItemID.DartPistol);
			DartPistol4.AddIngredient(ItemID.DartRifle);
			DartPistol4.AddTile(TileID.WorkBenches);
			DartPistol4.Register();

			Recipe DartPistol5 = Recipe.Create(ItemID.DartPistol);
			DartPistol5.AddIngredient(ItemID.PutridScent);
			DartPistol5.AddTile(TileID.WorkBenches);
			DartPistol5.Register();

			Recipe DartPistol6 = Recipe.Create(ItemID.DartPistol);
			DartPistol6.AddIngredient(ItemID.TendonHook);
			DartPistol6.AddTile(TileID.WorkBenches);
			DartPistol6.Register();

			Recipe DartPistol7 = Recipe.Create(ItemID.DartPistol);
			DartPistol7.AddIngredient(ItemID.FleshKnuckles);
			DartPistol7.AddTile(TileID.WorkBenches);
			DartPistol7.Register();

			Recipe DartPistol8 = Recipe.Create(ItemID.DartPistol);
			DartPistol8.AddIngredient(ItemID.SoulDrain);
			DartPistol8.AddTile(TileID.WorkBenches);
			DartPistol8.Register();

			Recipe DartPistol9 = Recipe.Create(ItemID.DartPistol);
			DartPistol9.AddIngredient(ItemID.FetidBaghnakhs);
			DartPistol9.AddTile(TileID.WorkBenches);
			DartPistol9.Register();
		}
	}
}