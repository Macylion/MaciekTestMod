using Terraria;
using Terraria.ModLoader;

namespace MaciekTestMod.Items.Armor{
	[AutoloadEquip(EquipType.Head)]

	public class MaciekHelmet : ModItem{

		public override void SetStaticDefaults(){
			DisplayName.SetDefault("Maciek helmet");
			Tooltip.SetDefault("Nothing special"
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
			item.defense = 30;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs){
			return body.type == mod.ItemType("MaciekBreastplate") && legs.type == mod.ItemType("MaciekLeggings");
		}

		public override void UpdateArmorSet(Player player){
			player.meleeDamage *= 2f;
			player.thrownDamage *= 2f;
			player.rangedDamage *= 2f;
			player.magicDamage *= 2f;
			player.minionDamage *= 2f;
			player.statLifeMax2 += 100;
			player.statManaMax2 += 100;
			player.lifeRegen += 8;
			player.manaRegen += 8;
		}

		public override void AddRecipes(){
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Ingot", 20);
			recipe.AddTile(null, "AnvilBlock");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}