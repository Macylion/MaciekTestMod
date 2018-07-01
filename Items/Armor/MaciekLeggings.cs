using Terraria;
using Terraria.ModLoader;

namespace MaciekTestMod.Items.Armor{
	[AutoloadEquip(EquipType.Legs)]

	public class MaciekLeggings : ModItem{
		public override void SetStaticDefaults(){
			DisplayName.SetDefault("Maciek Leggings");
			Tooltip.SetDefault("Increased movement speed"
				+ "\nSet bonus:"
				+ "\n100% increased damage"
				+ "\n+100 Life and Mana"
				+ "\nIncreased Life and Mana Regen");
		}

		public override void SetDefaults(){
			item.width = 18;
			item.height = 18;
			item.value = 10000000;
			item.rare = 2;
			item.defense = 45;
		}

		public override void UpdateEquip(Player player){
			player.moveSpeed += 0.5f;
		}

		public override void AddRecipes(){
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Ingot", 19);
			recipe.AddTile(null, "AnvilBlock");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}