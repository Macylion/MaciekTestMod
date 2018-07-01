using Terraria;
using Terraria.ModLoader;

namespace MaciekTestMod.Items{
	[AutoloadEquip(EquipType.Wings)]

	public class MaciekWings : ModItem{
		public override void SetStaticDefaults(){
			DisplayName.SetDefault("Maciek Wings");
			Tooltip.SetDefault("Best wings");
		}

		public override void SetDefaults(){
			item.width = 22;
			item.height = 20;
			item.value = 10000;
			item.rare = 2;
			item.accessory = true;
		}
		
		public override void UpdateAccessory(Player player, bool hideVisual){
			player.wingTimeMax = 300;
		}

		public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising,
			ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend){
			ascentWhenFalling = 0.85f;
			ascentWhenRising = 0.15f;
			maxCanAscendMultiplier = 1f;
			maxAscentMultiplier = 3f;
			constantAscend = 0.135f;
		}

		public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration){
			speed = 12f;
			acceleration *= 4f;
		}

		public override void AddRecipes(){
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Ingot", 16);
			recipe.AddTile(null, "AnvilBlock");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}