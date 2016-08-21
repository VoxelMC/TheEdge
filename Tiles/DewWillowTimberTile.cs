using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace TheEdge.Tiles
{
    public class DewWillowTimberTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            drop = mod.ItemType("DewWillowTimber");
            
        }

        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
        {
            r = 0f;
            g = 0f;
            b = 3.0f;
        }


    }
}