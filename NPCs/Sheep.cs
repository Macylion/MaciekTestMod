using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MaciekTestMod.NPCs{

	public class Sheep : ModNPC{

		public override void SetStaticDefaults(){
			DisplayName.SetDefault("Maciek Sheep");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Zombie];
		}

		public override void SetDefaults(){
			npc.width = 48;
			npc.height = 34;
			npc.damage = 0;
			//npc.friendly = true;
			npc.defense = 0;
			npc.lifeMax = 10;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = 6f;
			npc.knockBackResist = 0.5f;
			npc.aiStyle = 7;
			aiType = NPCID.Bunny;
			animationType = NPCID.Zombie;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo){
			return SpawnCondition.OverworldDaySlime.Chance * 0.8f;
		}

		public override void HitEffect(int hitDirection, double damage){
			
			for (int i = 0; i < 20; i++){
				int dustType = Main.rand.Next(139, 143);
				int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, dustType);
				Dust dust = Main.dust[dustIndex];
				dust.velocity.X = dust.velocity.X + Main.rand.Next(-50, 51) * 0.01f;
				dust.velocity.Y = dust.velocity.Y + Main.rand.Next(-50, 51) * 0.01f;
				dust.scale *= 10f + Main.rand.Next(-30, 31) * 0.01f;
			}
		}

		public override void NPCLoot(){
			if(Main.rand.Next(0, 1000) == 1000)
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("MagicSword"));
			Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Silk, Main.rand.Next(0, 4));
		}
	}
}