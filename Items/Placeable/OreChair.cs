using Terraria.ID;
using Terraria.ModLoader;

namespace MaciekTestMod.Items.Placeable{

	public class OreChair : ModItem{
		public override void SetStaticDefaults(){
			DisplayName.SetDefault("Maciek Chair");
			Tooltip.SetDefault("");
		}

		public override void SetDefaults(){
			item.width = 12;
			item.height = 30;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 150;
			item.createTile = mod.TileType("MaciekChair");
		}

		public override void AddRecipes(){
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Ingot");
			recipe.AddTile(null, "AnvilBlock");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}