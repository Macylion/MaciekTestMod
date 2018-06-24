using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MaciekTestMod.Items{

	public class Summon : ModItem{

		public override void SetStaticDefaults(){
			DisplayName.SetDefault("???");
			Tooltip.SetDefault("??? ???");
		}

		public override void SetDefaults(){
			item.CloneDefaults(ItemID.LifeFruit);
			item.width = 20;
			item.height = 20;
			item.rare = 2;
			item.maxStack = 30;
			item.consumable = true;
			item.value = 100;
            item.rare = 1;
            item.useAnimation = 30;
            item.useTime = 30;
            item.useStyle = 4;
		}

		public override void AddRecipes(){
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Ingot", 32);
			recipe.AddTile(null, "AnvilBlock");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override bool CanUseItem(Player player){
			return true;
		}

		public override bool UseItem(Player player){
			NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("BigZombie"));
			Main.PlaySound(15, (int)player.position.X, (int)player.position.Y, 0);
			return true;
		}

	}
}