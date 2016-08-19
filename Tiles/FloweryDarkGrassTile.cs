using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using System;

namespace TheEdge.Tiles
{
    public class FloweryDarkGrassTile : ModTile
    {
        Random rand = new Random();
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMerge[mod.TileType("AncientMossStoneTile")][Type] = true;
            Main.tileMerge[mod.TileType("FloweryDarkGrassTile")][Type] = true;
            Main.tileMerge[mod.TileType("CorruptDarkGrassTile")][Type] = true;
            Main.tileMerge[mod.TileType("FleshDarkGrassTile")][Type] = true;
            Main.tileMerge[mod.TileType("FrozenDarkSoilTile")][Type] = true;
            Main.tileMerge[mod.TileType("PeatTile")][Type] = true;
            Main.tileMerge[mod.TileType("SandSoilTile")][Type] = true;
            Main.tileMerge[mod.TileType("FloweryDarkGrassTile")][Type] = true;
            Main.tileMerge[mod.TileType("CorruptDarkGrassTile")][Type] = true;
            Main.tileMerge[mod.TileType("FleshDarkGrassTile")][Type] = true;
            Main.tileMerge[mod.TileType("AncientMossStoneTile")][Type] = true;
            Main.tileMerge[mod.TileType("FrozenDarkSoilTile")][Type] = true;
            Main.tileMerge[mod.TileType("PeatTile")][Type] = true;
            Main.tileMerge[mod.TileType("SandSoilTile")][Type] = true;
            Main.tileMerge[mod.TileType("BloodStainedDarkSoilTile")][Type] = true;
            Main.tileMerge[mod.TileType("AncientMossyStoneTile")][Type] = true;
            Main.tileMerge[mod.TileType("BirchyStainedDarkSoilTile")][Type] = true;
            Main.tileMerge[mod.TileType("BlackSeededDaekSoilTile")][Type] = true;
            Main.tileMerge[mod.TileType("BrushSoilTile")][Type] = true;
            Main.tileMerge[mod.TileType("BulbulSoilTile")][Type] = true;
            Main.tileMerge[mod.TileType("CopperSoilTile")][Type] = true;
            Main.tileMerge[mod.TileType("DampSoilTile")][Type] = true;
            Main.tileMerge[mod.TileType("DarkRedSoilTile")][Type] = true;
            Main.tileMerge[mod.TileType("DarkWoodedSoilTile")][Type] = true;
            Main.tileMerge[mod.TileType("DeadSoilTile")][Type] = true;
            Main.tileMerge[mod.TileType("DewySoilTile")][Type] = true;
            Main.tileMerge[mod.TileType("DewyDropSoilTile")][Type] = true;
            Main.tileMerge[mod.TileType("EmptySoilTile")][Type] = true;
            Main.tileMerge[mod.TileType("ForestSoilTile")][Type] = true;
            Main.tileMerge[mod.TileType("GladeSoilTile")][Type] = true;
            Main.tileMerge[mod.TileType("GravelySoilTile")][Type] = true;
            Main.tileMerge[mod.TileType("GreenSoilTileGreenBirchSoilTile")][Type] = true;
            Main.tileMerge[mod.TileType("IcySoilTile")][Type] = true;
            Main.tileMerge[mod.TileType("LakeSoilTile")][Type] = true;
            Main.tileMerge[mod.TileType("LeadSoilTile")][Type] = true;
            Main.tileMerge[mod.TileType("LightSoilTile")][Type] = true;
            Main.tileMerge[mod.TileType("LiverSoilTile")][Type] = true;
            Main.tileMerge[mod.TileType("LufSoilTile")][Type] = true;
            Main.tileMerge[mod.TileType("LullatiowSoilTile")][Type] = true;
            Main.tileMerge[mod.TileType("MilkSoilTile")][Type] = true;
            Main.tileMerge[mod.TileType("MuddySoilTile")][Type] = true;
            Main.tileMerge[mod.TileType("MulchSoilTile")][Type] = true;
            Main.tileMerge[mod.TileType("OakSoilTile")][Type] = true;
            Main.tileMerge[mod.TileType("OpirSoilTile")][Type] = true;
            Main.tileMerge[mod.TileType("OtioSoilTile")][Type] = true;
            Main.tileMerge[mod.TileType("PineSoilTile")][Type] = true;
            Main.tileMerge[mod.TileType("RedSoilTile")][Type] = true;
            Main.tileMerge[mod.TileType("RosySoilTile")][Type] = true;
            Main.tileMerge[mod.TileType("ScentedSoilTile")][Type] = true;
            Main.tileMerge[mod.TileType("SedgeSoilTile")][Type] = true;
            Main.tileMerge[mod.TileType("ShankSoilTile")][Type] = true;
            Main.tileMerge[mod.TileType("SilverFlackSoilTile")][Type] = true;
            Main.tileMerge[mod.TileType("SilverSoilTile")][Type] = true;
            Main.tileMerge[mod.TileType("SilverySoilTile")][Type] = true;
            Main.tileMerge[mod.TileType("SleepingSoilTile")][Type] = true;
            Main.tileMerge[mod.TileType("SnagSoilTile")][Type] = true;
            Main.tileMerge[mod.TileType("StinkySoilTile")][Type] = true;
            Main.tileMerge[mod.TileType("SumpSoilTile")][Type] = true;
            Main.tileMerge[mod.TileType("SwampSoilTile")][Type] = true;
            Main.tileMerge[mod.TileType("SweetilSoilTile")][Type] = true;
            Main.tileMerge[mod.TileType("SweetSoilTile")][Type] = true;
            Main.tileMerge[mod.TileType("TenebrousSoilTile")][Type] = true;
            Main.tileMerge[mod.TileType("TenelobousSoilTile")][Type] = true;
            Main.tileMerge[mod.TileType("TengolouaSoilTile")][Type] = true;
            Main.tileMerge[mod.TileType("ThornySoilTile")][Type] = true;
            Main.tileMerge[mod.TileType("TopiurSoilTile")][Type] = true;
            Main.tileMerge[mod.TileType("WaterySoilTile")][Type] = true;
            Main.tileMerge[mod.TileType("WeepungrSoilTile")][Type] = true;
            Main.tileMerge[mod.TileType("WillowedSoilTile")][Type] = true;
            Main.tileMerge[mod.TileType("YellowSoilTile")][Type] = true;
            drop = mod.ItemType("DarkSoil");
            SetModTree(new IronWoodTree());
            Main.tileMerge[mod.TileType("DarkSoilTile")][Type] = true;
        }

        public override int SaplingGrowthType(ref int style)
        {
            style = 0;
            return mod.TileType("IronWoodSapling");
        }

        public override void RandomUpdate(int i, int j)
        {
            if (rand.Next(0, 10) == 3)
            {
                if (Main.tile[i + 1, j].type == (ushort)mod.TileType("FloweryDarkGrassTile"))
                {
                    bool TileOnRight = true;
                }
                else
                {
                    bool TileOnRight = false;
                }

                if (Main.tile[i - 1, j].type == (ushort)mod.TileType("FloweryDarkGrassTile"))
                {
                    bool TileOnLeft = true;
                }
                else
                {
                    bool TileOnLeft = false;
                }

                if (Main.tile[i, j - 1].type == (ushort)mod.TileType("FloweryDarkGrassTile"))
                {
                    bool TileOnTop = true;
                }
                else
                {
                    bool TileOnTop = false;
                }

                if (Main.tile[i, j + 1].type == (ushort)mod.TileType("FloweryDarkGrassTile"))
                {
                    bool TileOnBottom = true;
                }
                else
                {
                    bool TileOnBottom = false;
                }

                if (Main.tile[i + 1, j + 1].type == (ushort)mod.TileType("FloweryDarkGrassTile"))
                {
                    bool TileOnBottomRight = true;
                }
                else
                {
                    bool TileOnBottomRight = false;
                }

                if (Main.tile[i + 1, j].type == (ushort)mod.TileType("DarkSoilTile"))
                {
                    Main.tile[i + 1, j].type = (ushort)mod.TileType("FloweryDarkGrassTile");
                }
                if (Main.tile[i - 1, j].type == (ushort)mod.TileType("DarkSoilTile"))
                {
                    Main.tile[i - 1, j].type = (ushort)mod.TileType("FloweryDarkGrassTile");
                }
                if (Main.tile[i, j + 1].type == (ushort)mod.TileType("DarkSoilTile"))
                {
                    Main.tile[i, j + 1].type = (ushort)mod.TileType("FloweryDarkGrassTile");
                }
                if (Main.tile[i, j - 1].type == (ushort)mod.TileType("DarkSoilTile"))
                {
                    Main.tile[i, j - 1].type = (ushort)mod.TileType("FloweryDarkGrassTile");
                }
                if (Main.tile[i + 1, j + 1].type == (ushort)mod.TileType("DarkSoilTile"))
                {
                    Main.tile[i + 1, j + 1].type = (ushort)mod.TileType("FloweryDarkGrassTile");
                }
                if (Main.tile[i + 1, j - 1].type == (ushort)mod.TileType("DarkSoilTile"))
                {
                    Main.tile[i + 1, j - 1].type = (ushort)mod.TileType("FloweryDarkGrassTile");
                }
                if (Main.tile[i - 1, j + 1].type == (ushort)mod.TileType("DarkSoilTile"))
                {
                    Main.tile[i - 1, j + 1].type = (ushort)mod.TileType("FloweryDarkGrassTile");
                }
                if (Main.tile[i - 1, j - 1].type == (ushort)mod.TileType("DarkSoilTile1"))
                {
                    Main.tile[i - 1, j - 1].type = (ushort)mod.TileType("FloweryDarkGrassTile");
                }
            }
        }
    }
}