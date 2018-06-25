using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MaciekTestMod.NPCs{

	public class Zombie : ModNPC{

		public override void SetStaticDefaults(){
			DisplayName.SetDefault("Maciek Zombie");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Zombie];
		}

		public override void SetDefaults(){
			npc.width = 18;
			npc.height = 40;
			npc.damage = 50;
			npc.defense = 20;
			npc.lifeMax = 256;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = 60f;
			npc.knockBackResist = 0.5f;
			npc.aiStyle = 3;
			aiType = NPCID.Zombie;
			animationType = NPCID.Zombie;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo){
			return SpawnCondition.OverworldNightMonster.Chance * 2f;
		}

		public override void HitEffect(int hitDirection, double damage){
			
			for (int i = 0; i < 10; i++){
				int dustType = Main.rand.Next(139, 143);
				int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, dustType);
				Dust dust = Main.dust[dustIndex];
				dust.velocity.X = dust.velocity.X + Main.rand.Next(-50, 51) * 0.01f;
				dust.velocity.Y = dust.velocity.Y + Main.rand.Next(-50, 51) * 0.01f;
				dust.scale *= 1f + Main.rand.Next(-30, 31) * 0.01f;
			}
		}

		public override void NPCLoot(){
			Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Bag"));
		}
	}
}