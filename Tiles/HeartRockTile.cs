using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace TheEdge.Tiles
{
    public class HeartRockTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            drop = mod.ItemType("HeartRock");   
            Main.tileLighted[Type] = true;
            AddMapEntry(new Color(200, 200, 200));
            SetModTree(new IronWoodTree());
        }

        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
        {
            r = 3.0f;
            g = 1.0f;
            b = 1.0f;
        }

        

    }
}