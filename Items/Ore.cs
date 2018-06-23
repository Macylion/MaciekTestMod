using Terraria.ID;
using Terraria.ModLoader;

namespace MaciekTestMod.Items{
	public class Ore : ModItem{

		public override void SetStaticDefaults(){
			DisplayName.SetDefault("Maciek Ore Block");
			Tooltip.SetDefault("Such an Amazing Ore Block By Maciek");
		}


		public override void SetDefaults(){
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.value = 100;
			item.rare = 1;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("Blocko");
		}

		public override void AddRecipes(){
			//ModRecipe recipe = new ModRecipe(mod);
			//recipe.AddIngredient(ItemID.DirtBlock, 0);
			//recipe.SetResult(this);
			//recipe.AddRecipe();
		}
	}
}
