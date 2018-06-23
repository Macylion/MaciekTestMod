using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace MaciekTestMod.Tiles{

	public class Blocko : ModTile{

		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileBlockLight[Type] = true;
			Main.tileLighted[Type] = true;
			dustType = mod.DustType("Sparkle");
			drop = mod.ItemType("Ore");
			AddMapEntry(new Color(255, 255, 255));
		}

		public override void NumDust(int i, int j, bool fail, ref int num){
			num = fail ? 1 : 3;
		}

		public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b){
			r = 0.5f;
			g = 0.5f;
			b = 0.5f;
		}
	}
}