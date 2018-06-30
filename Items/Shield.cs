using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MaciekTestMod.Items{

	[AutoloadEquip(EquipType.Shield)]
	public class Shield : ModItem{
		public override void SetStaticDefaults(){
			DisplayName.SetDefault("Maciek Shield");
			Tooltip.SetDefault("More Damage"
				+ "\nMore Life Regen");
		}

		public override void SetDefaults(){
			item.width = 24;
			item.height = 28;
			item.value = 1000;
			item.rare = 2;
			item.accessory = true;
			item.defense = 25;
			item.lifeRegen = 2;
		}

		public override void UpdateAccessory(Player player, bool hideVisual){
			/*player.meleeDamage *= 2.5f;
			player.thrownDamage *= 2.5f;
			player.rangedDamage *= 2.5f;
			player.magicDamage *= 2.5f;
			player.minionDamage *= 2.5f;*/
			player.meleeDamage += 0.1f;
			player.thrownDamage += 0.1f;
			player.rangedDamage += 0.1f;
			player.magicDamage += 0.1f;
			player.minionDamage += 0.1f;
			player.lifeRegen += 2;
			player.endurance = 1f - 0.1f * (1f - player.endurance);

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