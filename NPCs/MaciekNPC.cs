using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace MaciekTestMod.NPCs {

	[AutoloadHead]
	public class MaciekNPC : ModNPC
	{
		public override string Texture{
			get{
				return "MaciekTestMod/NPCs/MaciekNPC";
			}
		}

		public override string[] AltTextures{
			get{
				return new string[] { "MaciekTestMod/NPCs/MaciekNPC" };
			}
		}

		public override bool Autoload(ref string name){
			name = "MaciekNPC";
			return mod.Properties.Autoload;
		}

		public override void SetStaticDefaults(){
			DisplayName.SetDefault("MaciekNPC");
			Main.npcFrameCount[npc.type] = 25;
			NPCID.Sets.ExtraFramesCount[npc.type] = 9;
			NPCID.Sets.AttackFrameCount[npc.type] = 4;
			NPCID.Sets.DangerDetectRange[npc.type] = 700;
			NPCID.Sets.AttackType[npc.type] = 0;
			NPCID.Sets.AttackTime[npc.type] = 90;
			NPCID.Sets.AttackAverageChance[npc.type] = 30;
			NPCID.Sets.HatOffsetY[npc.type] = 4;
		}

		public override void SetDefaults(){
			npc.townNPC = true;
			npc.friendly = true;
			npc.width = 18;
			npc.height = 40;
			npc.aiStyle = 7;
			npc.damage = 10;
			npc.defense = 15;
			npc.lifeMax = 250;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.knockBackResist = 0.5f;
			animationType = NPCID.Guide;
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

		public override bool CanTownNPCSpawn(int numTownNPCs, int money){
			return true;
		}

		public override bool CheckConditions(int left, int right, int top, int bottom)
		{
			int score = 0;
			for (int x = left; x <= right; x++){
				for (int y = top; y <= bottom; y++){
					int type = Main.tile[x, y].type;
					if (type == mod.TileType("Blocko")){
						score++;
					}
					if (true){
						score++;
					}
				}
			}
			return score >= (right - left) * (bottom - top) / 2;
		}

		public override string TownNPCName()
		{
			switch (WorldGen.genRand.Next(4)){
				case 0:
					return "Maciuś";
				case 1:
					return "Maciej";
				default:
					return "Maciek";
			}
		}

		public override void FindFrame(int frameHeight){

		}

		public override string GetChat(){
			return "Don't talk to me!";
		}

		public override void SetChatButtons(ref string button, ref string button2){
			button = Language.GetTextValue("LegacyInterface.28");
		}

		public override void OnChatButtonClicked(bool firstButton, ref bool shop){
			if (firstButton){
				shop = true;
			}
		}

		public override void SetupShop(Chest shop, ref int nextSlot){
			shop.item[nextSlot].SetDefaults(mod.ItemType("Potion"));
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("Bag"));
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("Book"));
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("Bow"));
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("Gun"));
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("Ingot"));
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("MaciekSword"));
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("MagicSword"));
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("Ore"));
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("Summon"));
			nextSlot++;
		}

		public override void NPCLoot(){
			Item.NewItem(npc.getRect(), mod.ItemType("MagicSword"));
		}

		public override void TownNPCAttackStrength(ref int damage, ref float knockback){
			damage = 200;
			knockback = 4f;
		}

		public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown){
			cooldown = 10;
			randExtraCooldown = 10;
		}

		public override void TownNPCAttackProj(ref int projType, ref int attackDelay){
			projType = mod.ProjectileType("Pro");
			attackDelay = 1;
		}

		public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection, ref float randomOffset){
			multiplier = 12f;
			randomOffset = 2f;
		}
	}
}