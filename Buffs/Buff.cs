using Terraria;
using Terraria.ModLoader;

namespace MaciekTestMod.Buffs{

	public class Buff : ModBuff{

		public override void SetDefaults(){
			DisplayName.SetDefault("Maciek Blessing");
			Description.SetDefault("You are pro");
			Main.debuff[Type] = true;
			Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = true;
			longerExpertDebuff = true;
		}

		public override void Update(Player player, ref int buffIndex){
			
		}
	}
}