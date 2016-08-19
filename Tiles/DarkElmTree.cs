using Microsoft.Xna.Framework.Graphics;
using Terraria.ModLoader;

namespace TheEdge.Tiles
{
	public class DarkElmTree : ModTree
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
            
            return mod.GetGoreSlot("Gores/DarkElmTreeFX");
		}

		public override int DropWood()
		{
			return mod.ItemType("DarkElmTimber");
		}

		public override Texture2D GetTexture()
		{
			return mod.GetTexture("Tiles/DarkElmTree");
		}

		public override Texture2D GetTopTextures()
		{
			return mod.GetTexture("Tiles/DarkElmTree_Tops");
		}

		public override Texture2D GetBranchTextures()
		{
			return mod.GetTexture("Tiles/DarkElmTree_Branches");
		}
	}
}