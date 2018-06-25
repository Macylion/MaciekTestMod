using Terraria.ID;
using Terraria.ModLoader;

namespace MaciekTestMod.Items{
	public class Book : ModItem{

		public override void SetStaticDefaults(){
			DisplayName.SetDefault("Maciek Crystal Ball");
			Tooltip.SetDefault("Such an Amazing Crystal Ball By Maciek");
		}


		public override void SetDefaults(){
			item.damage = 40;
			item.magic = true;
			item.mana = 0;
			item.noMelee = true;
			item.width = 32;
			item.height = 32;
			item.useTime = 10;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.knockBack = 3;
			item.value = 1000;
			item.rare = 2;
			item.UseSound = SoundID.Item29; 
			item.autoReuse = true;
			item.shoot = 2;
			item.shoot = mod.ProjectileType("Pro");
			item.shootSpeed = 16;
		}

		public override void AddRecipes(){
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Ingot", 13);
			recipe.AddTile(null, "AnvilBlock");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
