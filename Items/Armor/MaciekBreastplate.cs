using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MaciekTestMod.Items.Armor{
	[AutoloadEquip(EquipType.Body)]
	
	public class MaciekBreastplate : ModItem{
		public override void SetStaticDefaults(){
			base.SetStaticDefaults();
			DisplayName.SetDefault("Maciek Breastplate");
			Tooltip.SetDefault("Immunity to some debuffs"
				+ "\n+20 max mana and +4 max minions"
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
			item.defense = 60;
		}

		public override void UpdateEquip(Player player){
			player.buffImmune[BuffID.OnFire] = true;
			player.buffImmune[BuffID.Bleeding] = true;
			player.buffImmune[BuffID.Poisoned] = true;
			player.buffImmune[BuffID.Darkness] = true;
			player.buffImmune[BuffID.Silenced] = true;
			player.buffImmune[BuffID.Cursed] = true;
			player.buffImmune[BuffID.Confused] = true;
			player.buffImmune[BuffID.Slow] = true;
			player.buffImmune[BuffID.Weak] = true;
			player.buffImmune[BuffID.CursedInferno] = true;
			player.buffImmune[BuffID.Chilled] = true;
			player.buffImmune[BuffID.Frozen] = true;
			player.buffImmune[BuffID.Burning] = true;
			player.statManaMax2 += 20;
			player.maxMinions += 4;
		}

		public override void AddRecipes(){
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Ingot", 24);
			recipe.AddTile(null, "AnvilBlock");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}