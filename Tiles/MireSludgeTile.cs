using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace TheEdge.Tiles
{
    public class MireSludgeTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            drop = mod.ItemType("MireSludge");   //put your CustomBlock name
        }

        public override bool TileFrame(int x, int y, ref bool resetFrame, ref bool noBreak)
        {
            if (WorldGen.noTileActions)
            {
                return false;
            }
            Tile above = Main.tile[x, y - 1];
            Tile below = Main.tile[x, y + 1];

            if (below != null && !below.active() && (!above.active() || !(above.type == 21 || above.type == 323)))
            {
                Main.tile[x, y].active(false);
                if (Main.netMode == 0)
                {
                    int proj = Projectile.NewProjectile((float)(x * 16 + 8), (float)(y * 16 + 8), 0f, 0.41f, mod.ProjectileType("MireMudFall"), 10, 0f, Main.myPlayer, 1f, 0f);
                    WorldGen.SquareTileFrame(x, y, true);
                }
                else if (Main.netMode == 2)
                {
                    int proj = Projectile.NewProjectile((float)(x * 16 + 8), (float)(y * 16 + 8), 0f, 2.5f, mod.ProjectileType("MireMudFall"), 10, 0f, Main.myPlayer, 1f, 0f);
                    Main.projectile[proj].velocity.Y = 0.5f;
                    Main.projectile[proj].position.Y += 2f; ;
                    Main.projectile[proj].netUpdate = true;
                    NetMessage.SendTileSquare(-1, x, y, 1);
                    WorldGen.SquareTileFrame(x, y, true);
                }
                return true;
            }
            return true;
        }

    }
}