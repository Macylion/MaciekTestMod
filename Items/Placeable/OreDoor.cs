using Terraria.ID;
using Terraria.ModLoader;

namespace MaciekTestMod.Items.Placeable{

	public class OreDoor : ModItem{

		public override void SetStaticDefaults(){
			DisplayName.SetDefault("Maciek Door");
			Tooltip.SetDefault("");
		}

		public override void SetDefaults(){
			item.width = 14;
			item.height = 28;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 150;
			item.createTile = mod.TileType("MaciekDoorClosed");
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