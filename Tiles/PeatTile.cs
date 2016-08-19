using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace TheEdge.Tiles
{
    public class PeatTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMerge[mod.TileType("DarkGrassTile")][Type] = true;
            Main.tileMerge[mod.TileType("DarkSoilTile")][Type] = true;
            drop = mod.ItemType("Peat");   //put your CustomBlock name
        }

        

    }
}