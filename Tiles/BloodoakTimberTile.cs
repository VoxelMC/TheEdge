using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace TheEdge.Tiles
{
    public class BloodoakTimberTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            drop = mod.ItemType("BloodoakTimber");
            
        }

        
    }
}