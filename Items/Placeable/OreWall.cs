using Terraria.ModLoader;

namespace MaciekTestMod.Items.Placeable{

	public class OreWall : ModItem{
		public override void SetStaticDefaults(){
			DisplayName.SetDefault("Maciek Ore Wall");
			Tooltip.SetDefault("Such an Amazing Ore Wall By Maciek");
		}

		public override void SetDefaults(){
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createWall = mod.WallType("MaciekWall");
		}

		public override void AddRecipes(){
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Ore");
			recipe.AddTile(null, "AnvilBlock");
			recipe.SetResult(this, 4);
			recipe.AddRecipe();
		}
	}
}