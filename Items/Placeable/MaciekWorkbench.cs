using Terraria.ID;
using Terraria.ModLoader;

namespace MaciekTestMod.Items.Placeable{
	public class MaciekWorkbench : ModItem{

		public override void SetStaticDefaults(){
			DisplayName.SetDefault("Maciek Maciek Workbench");
			Tooltip.SetDefault("Workbench");
		}

		public override void SetDefaults(){
			item.width = 28;
			item.height = 14;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 150;
			item.createTile = mod.TileType("Workbench");
		}

		public override void AddRecipes(){
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Ingot", 10);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}