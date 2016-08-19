using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace TheEdge.Tiles
{
    public class AncientMossStoneTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMerge[mod.TileType("DarkGrassTile")][Type] = true;
            Main.tileMerge[mod.TileType("DarkSoilTile")][Type] = true;
            drop = mod.ItemType("AncientMossStone"); 
            //put your CustomBlock name
        }

        

    }
}