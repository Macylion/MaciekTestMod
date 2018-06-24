using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace MaciekTestMod.NPCs{

	public class BigZombie : ModNPC{

		public override void SetStaticDefaults(){
			DisplayName.SetDefault("Flying Circle");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Zombie];
		}

		public override void SetDefaults(){
            npc.aiStyle = 56;  
            npc.lifeMax = 5000;   
            npc.damage = 100;  
            npc.defense = 40;    
            npc.knockBackResist = 0f;
            npc.width = 100;
            npc.height = 100;
            animationType = NPCID.EyeofCthulhu;
            Main.npcFrameCount[npc.type] = 2;    
            npc.value = 10000;
            npc.boss = true;  
            npc.lavaImmune = true;
            npc.noGravity = true;
            npc.noTileCollide = true;
            music = MusicID.Boss2;
            npc.netAlways = true;
            npc.buffImmune[24] = true;
            npc.buffImmune[67] = true;
        }
        public override void AI(){
            if(npc.life < 5000 && npc.aiStyle == 56){
                npc.aiStyle = 5;
            }
        }
        public override void BossLoot(ref string name, ref int potionType){
            potionType = ItemID.LesserHealingPotion;
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("BossBag"), 1);
        }
        public override void ScaleExpertStats(int numPlayers, float bossLifeScale){
            npc.lifeMax = (int)(npc.lifeMax * 0.579f * bossLifeScale);
            npc.damage = (int)(npc.damage * 0.6f); 
        }
    }
}