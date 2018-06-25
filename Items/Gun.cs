using Terraria.ID;
using Terraria.ModLoader;

namespace MaciekTestMod.Items{
	public class Gun : ModItem{

		public override void SetStaticDefaults(){
			DisplayName.SetDefault("Maciek Gun");
			Tooltip.SetDefault("Such an Amazing Gun By Maciek");
		}


		public override void SetDefaults(){
			item.damage = 34;
			item.ranged = true;
			item.melee = false;
			item.noMelee = true;
			item.width = 33;
			item.height = 14;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = 5;
			item.knockBack = 0;
			item.value = 1000;
			item.rare = 2;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 2;
			item.shootSpeed = 1000;
			item.useAmmo = AmmoID.Bullet;
		}

		public override void AddRecipes(){
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Ingot", 14);
			recipe.AddTile(null, "AnvilBlock");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
