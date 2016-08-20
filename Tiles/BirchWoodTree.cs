using Microsoft.Xna.Framework.Graphics;
using Terraria.ModLoader;

namespace TheEdge.Tiles
{
	public class BirchWoodTree : ModTree
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
			return mod.GetGoreSlot("Gores/BirchWoodTreeFX");
		}

		public override int DropWood()
		{
			return mod.ItemType("BirchWoodTimber");
		}

		public override Texture2D GetTexture()
		{
			return mod.GetTexture("Tiles/BirchWoodTree");
		}

		public override Texture2D GetTopTextures()
		{
			return mod.GetTexture("Tiles/BirchWoodTree_Tops");
		}

		public override Texture2D GetBranchTextures()
		{
			return mod.GetTexture("Tiles/BirchWoodTree_Branches");
		}
	}
}