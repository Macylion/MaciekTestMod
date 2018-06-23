using Terraria.ID;
using Terraria.ModLoader;
using MaciekTestMod;

namespace MaciekTestMod.Placeable{

	public class AnvilItem : ModItem{

		public override void SetStaticDefaults(){
			DisplayName.SetDefault("MaciekBench");
			Tooltip.SetDefault("Such an Amazing MaciekBench By Maciek");
		}

		public override void SetDefaults(){
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 150;
			item.createTile = mod.TileType("AnvilBlock");
		}

		public override void AddRecipes(){
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Ore", 8);
			//recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}