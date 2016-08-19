using Microsoft.Xna.Framework.Graphics;
using Terraria.ModLoader;

namespace TheEdge.Tiles
{
	public class BloodoakTree : ModTree
	{
        private Mod mod
		{
			get
			{
				return ModLoader.GetMod("TheEdge");
			}
		}

		public override int CreateDust()
		{
			return mod.DustType("Sparkle");
		}

		public override int GrowthFXGore()
		{
            
            return mod.GetGoreSlot("Gores/BloodoakTreeFX");
		}

		public override int DropWood()
		{
			return mod.ItemType("BloodoakTimber");
		}

		public override Texture2D GetTexture()
		{
			return mod.GetTexture("Tiles/BloodoakTree");
		}

		public override Texture2D GetTopTextures()
		{
			return mod.GetTexture("Tiles/BloodoakTree_Tops");
		}

		public override Texture2D GetBranchTextures()
		{
			return mod.GetTexture("Tiles/BloodoakTree_Branches");
		}
	}
}