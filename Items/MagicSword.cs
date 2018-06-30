using Terraria.ID;
using Terraria.ModLoader;

namespace MaciekTestMod.Items{

	public class MagicSword : ModItem{

		public override void SetStaticDefaults(){
			DisplayName.SetDefault("Maciek Magic Sword");
			Tooltip.SetDefault("Such an Amazing Magic Sword By Maciek");
		}

		public override void SetDefaults(){
			item.damage = 42;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 10;
			item.useAnimation = 20;
			item.reuseDelay = 1;
			item.useStyle = 1;
			item.knockBack = 2;
			item.value = 1000000;
			item.rare = 1;
			item.UseSound = SoundID.Item8;
			item.autoReuse = true;
			item.shoot = 2;
			item.shoot = mod.ProjectileType("Pro");
			item.shootSpeed = 16;
		}

		public override void AddRecipes(){
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Ingot", 10);
			recipe.AddIngredient(null, "MaciekSword", 1);
			recipe.AddIngredient(null, "Book", 1);
			recipe.AddTile(null, "AnvilBlock");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
