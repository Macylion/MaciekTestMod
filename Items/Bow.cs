using Terraria.ID;
using Terraria.ModLoader;

namespace MaciekTestMod.Items{
	public class Bow : ModItem{

		public override void SetStaticDefaults(){
			DisplayName.SetDefault("Maciek Bow");
			Tooltip.SetDefault("Such an Amazing Bow By Maciek");
		}


		public override void SetDefaults(){
			item.damage = 20;
			item.ranged = true;
			item.noMelee = true;
			item.width = 24;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.knockBack = 3;
			item.value = 1000;
			item.rare = 2;
			item.UseSound = SoundID.Item20;
			item.autoReuse = true;
			item.shoot = 2;
			item.shootSpeed = 250;
			item.useAmmo = AmmoID.Arrow;
		}

		public override void AddRecipes(){
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Ingot", 12);
			recipe.AddTile(null, "AnvilBlock");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
