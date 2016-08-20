using Microsoft.Xna.Framework.Graphics;
using Terraria.ModLoader;

namespace TheEdge.Tiles
{
	public class BlackOakTree : ModTree
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
			return mod.GetGoreSlot("Gores/BlackOakTreeFX");
		}

		public override int DropWood()
		{
			return mod.ItemType("BlackOakTimber");
		}

		public override Texture2D GetTexture()
		{
			return mod.GetTexture("Tiles/BlackOakTree");
		}

		public override Texture2D GetTopTextures()
		{
			return mod.GetTexture("Tiles/BlackOakTree_Tops");
		}

		public override Texture2D GetBranchTextures()
		{
			return mod.GetTexture("Tiles/BlackOakTree_Branches");
		}
	}
}