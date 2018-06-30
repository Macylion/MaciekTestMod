using Terraria.ID;
using Terraria.ModLoader;

namespace MaciekTestMod.Items{

	public class MaciekSword : ModItem{

		public override void SetStaticDefaults(){
			DisplayName.SetDefault("Maciek Sword");
			Tooltip.SetDefault("Such an Amazing Sword By Maciek");
		}

		public override void SetDefaults(){
			item.damage = 32;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 5;
			item.useAnimation = 16;
			item.reuseDelay = 1;
			item.useStyle = 1;
			item.knockBack = 2;
			item.value = 1000000;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes(){
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Ingot", 11);
			recipe.AddTile(null, "AnvilBlock");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
