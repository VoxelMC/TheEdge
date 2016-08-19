using Microsoft.Xna.Framework.Graphics;
using Terraria.ModLoader;

namespace TheEdge.Tiles
{
	public class BrushWoodTree : ModTree
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
            
            return mod.GetGoreSlot("Gores/BrushWoodTreeFX");
		}

		public override int DropWood()
		{
			return mod.ItemType("BrushWoodTimber");
		}

		public override Texture2D GetTexture()
		{
			return mod.GetTexture("Tiles/BrushWoodTree");
		}

		public override Texture2D GetTopTextures()
		{
			return mod.GetTexture("Tiles/BrushWoodTree_Tops");
		}

		public override Texture2D GetBranchTextures()
		{
			return mod.GetTexture("Tiles/BrushWoodTree_Branches");
		}
	}
}