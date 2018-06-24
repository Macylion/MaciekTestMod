using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MaciekTestMod.Items{

	public class BossBag : ModItem{

		public override void SetStaticDefaults(){
			DisplayName.SetDefault("Treasure Bag");
			Tooltip.SetDefault("<right> for Loot");
		}

		public override void SetDefaults(){
			item.width = 20;
			item.height = 20;
			item.rare = 2;
			item.maxStack = 30;
		}

		public override bool CanRightClick(){
			return true;
		}

		public override void RightClick(Player player){
			player.TryGettingDevArmor();
			player.QuickSpawnItem(mod.ItemType("Ore"), Main.rand.Next(10, 50));

		}
	}
}