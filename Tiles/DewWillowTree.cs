using Microsoft.Xna.Framework.Graphics;
using Terraria.ModLoader;

namespace TheEdge.Tiles
{
	public class DewWillowTree : ModTree
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
            
            return mod.GetGoreSlot("Gores/DewWillowTreeFX");
		}

		public override int DropWood()
		{
			return mod.ItemType("DewWillowTimber");
		}

		public override Texture2D GetTexture()
		{
			return mod.GetTexture("Tiles/DewWillowTree");
		}

		public override Texture2D GetTopTextures()
		{
			return mod.GetTexture("Tiles/DewWillowTree_Tops");
		}

		public override Texture2D GetBranchTextures()
		{
			return mod.GetTexture("Tiles/DewWillowTree_Branches");
		}
	}
}