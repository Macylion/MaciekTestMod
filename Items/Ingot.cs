using Terraria.ID;
using Terraria.ModLoader;

namespace MaciekTestMod.Items{
	public class Ingot : ModItem{

		public override void SetStaticDefaults(){
			DisplayName.SetDefault("Maciek Ingot");
			Tooltip.SetDefault("Such an Amazing Ingot By Maciek");
		}


		public override void SetDefaults(){
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = 500;
			item.rare = 2;
		}

		public override void AddRecipes(){
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Ore", 4);
			recipe.AddTile(null, "AnvilBlock");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
