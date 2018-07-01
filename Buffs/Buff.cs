using Terraria;
using Terraria.ModLoader;

namespace MaciekTestMod.Buffs{

	public class Buff : ModBuff{

		public override void SetDefaults(){
			DisplayName.SetDefault("Maciek Blessing");
			Description.SetDefault("You are pro"
				+ "\nbecause"
				+ "\n100% increased damage"
				+ "\n+100 Life and Mana"
				+ "\nIncreased Life and Mana Regen");
			Main.debuff[Type] = false;
			Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = false;
			longerExpertDebuff = true;
		}

		public override void Update(Player player, ref int buffIndex){
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
	}
}