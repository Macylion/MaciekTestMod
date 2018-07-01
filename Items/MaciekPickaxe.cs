using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MaciekTestMod.Items{
	public class MaciekPickaxe : ModItem{
		public override void SetStaticDefaults(){
			DisplayName.SetDefault("Maciek Pickaxe");
			Tooltip.SetDefault("Don't use me!!!");
		}

		public override void SetDefaults(){
			item.damage = 64;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 5;
			item.useAnimation = 5;
			item.pick = 375;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 100000000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes(){
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Ingot", 16);
			recipe.AddTile(null, "AnvilBlock");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override void MeleeEffects(Player player, Rectangle hitbox){
			if (Main.rand.Next(10) == 0){
				int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, mod.DustType("Sparkle"));
			}
		}
	}
}