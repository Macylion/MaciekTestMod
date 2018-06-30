using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MaciekTestMod.Items{

	public class Potion : ModItem{

		public override void SetStaticDefaults(){
			DisplayName.SetDefault("Maciek Poison");
			Tooltip.SetDefault("It smells like poison");
		}

		public override void SetDefaults(){
			//item.CloneDefaults(ItemID.LesserHealingPotion);
			item.width = 20;
			item.height = 20;
			item.rare = 2;
			item.maxStack = 30;
			item.consumable = true;
			item.value = 10000;
            item.rare = 5;
			item.UseSound = SoundID.Item8;
            item.useAnimation = 30;
            item.useTime = 30;
            item.useStyle = 4;
		}

		public override void AddRecipes(){
			/*ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Ingot", 4);
			recipe.AddTile(null, "AnvilBlock");
			recipe.SetResult(this);
			recipe.AddRecipe();*/
		}

		public override bool CanUseItem(Player player){
			return true;
		}

		public override bool UseItem(Player player){
			player.AddBuff(mod.BuffType("Buff"), 8000, true);
			return true;
		}

	}
}