using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MaciekTestMod.Items{

	[AutoloadEquip(EquipType.Shield)]
	public class OPShield : ModItem{
		public override void SetStaticDefaults(){
			DisplayName.SetDefault("Maciek OPShield");
			Tooltip.SetDefault("Maciek OP Shield"
				+ "\nOnly for gods");
		}

		public override void SetDefaults(){
			item.width = 24;
			item.height = 28;
			item.value = 100000;
			item.rare = 2;
			item.accessory = true;
			item.defense = 1000;
			item.lifeRegen = 1000;
		}

		public override void UpdateAccessory(Player player, bool hideVisual){
			player.meleeDamage *= 555f;
			player.thrownDamage *= 555f;
			player.rangedDamage *= 555f;
			player.magicDamage *= 555f;
			player.minionDamage *= 555f;
			player.lifeRegen += 10;
			player.lifeRegen *= 1000;
			player.endurance = 1f - 0.1f * (1f - player.endurance);

		}

		public override void AddRecipes(){
			/*ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Ingot", 12);
			recipe.AddTile(null, "AnvilBlock");
			recipe.SetResult(this);
			recipe.AddRecipe();*/
		}
	}
}