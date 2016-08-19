using System.IO;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.World.Generation;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Generation;
using System;

namespace TheEdge
{
    
    public class TheEdgeWorld : ModWorld
    {
        

        Random rand = new Random();
        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)           
        {
            
            
            

            int genIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Final Cleanup"));
            tasks.Insert(genIndex + 1, new PassLegacy("Growing the Deepwoods", delegate (GenerationProgress progress)
               
            {
                
                int xAxis = Main.maxTilesX / 2;// biome start
                int yAxis = 0; //top start

                for (int x = 0; x < Main.maxTilesX / 2; x++) // biome start
                {
                    yAxis = 0;
                    int fade = 0;
                    if (x < 20)
                    {
                        fade = 20 - x;
                    }
                    if (x > Main.maxTilesX / 2 - 20)
                    {
                        fade = x - (Main.maxTilesX / 2 - 20);
                    }
                    for (int y = 0; y < Main.maxTilesY / 3 + Main.rand.Next(50) - 25; y++) // how far down
                    {
                        if (Main.rand.NextFloat() < fade / 20f)
                        {
                            yAxis++;
                            continue;
                        }



                        


                        if (Main.tile[xAxis, yAxis] != null)
                        {
                            if (Main.tile[xAxis, yAxis].active()) 
                            {
                                int[] TileArray = { 0, 59 }; 



                                for (int BiomeDirtReplace = 0; BiomeDirtReplace < TileArray.Length; BiomeDirtReplace++)
                                {
                                    if (Main.tile[xAxis, yAxis].type == (ushort)TileArray[BiomeDirtReplace])
                                    {
                                        {

                                            Main.tile[xAxis, yAxis].type = (ushort)mod.TileType("DarkSoilTile"); // replace dirt

                                        }
                                    }
                                }

                                int[] CheckAirArray = { 0, 0, 1, 1, 1, -1, -1, -1 };
                                int[] CheckAirArray1 = { 1, -1, 0, -1, 1, 1, 0, -1 };
                                for (int AirCounter = 0; AirCounter < CheckAirArray.Length; AirCounter++)
                                {

                                    int[] TileGrassArray24 = { 40, 53, 147, 1, 112, 234, 116 };
                                    for (int BiomeGrassReplacer24 = 0; BiomeGrassReplacer24 < TileGrassArray24.Length; BiomeGrassReplacer24++)
                                    {


                                        if (!Main.tile[xAxis + CheckAirArray[AirCounter], yAxis + CheckAirArray1[AirCounter]].active())
                                        {
                                            if (Main.tile[xAxis, yAxis].type == (ushort)TileGrassArray24[BiomeGrassReplacer24])

                                            {

                                                Main.tile[xAxis, yAxis].type = (ushort)mod.TileType("DarkGrassTile"); // gives sand and snow grass

                                            }
                                        }

                                    }
                                }

                                int[] SandTileArray = { 53, 112, 234, 116 };
                                for (int BiomeDirtReplace1 = 0; BiomeDirtReplace1 < SandTileArray.Length; BiomeDirtReplace1++)
                                {
                                    if (Main.tile[xAxis, yAxis].type == (ushort)SandTileArray[BiomeDirtReplace1])
                                    {
                                        {

                                            Main.tile[xAxis, yAxis].type = (ushort)mod.TileType("SandSoilTile"); // replace sand

                                        }
                                    }
                                }

                                
                               
                                    if (Main.tile[xAxis, yAxis].type == 147)
                                    {
                                        {

                                            Main.tile[xAxis, yAxis].type = (ushort)mod.TileType("FrozenDarkSoilTile"); // replace snow

                                        }
                                    }
                                


                                int[] TileArray1 = { 2, 23, 60, 199 };
                                for (int BiomeGrassReplace = 0; BiomeGrassReplace < TileArray1.Length; BiomeGrassReplace++)

                                {

                                    if (Main.tile[xAxis, yAxis].type == (ushort)TileArray1[BiomeGrassReplace])

                                    {
                                        if (Main.tile[xAxis, yAxis - 1].active() == false) // if tile above is empty
                                        {
                                            if (yAxis < Main.worldSurface) //if above world surface
                                            {
                                                if (xAxis % 4 == 0) // every 4 blocks
                                                {
                                                    string[] SoilTileArray = { "BloodStainedDarkSoilTile", "BirchyStainedDarkSoilTile", "BlackSeededDarkSoilTile", "BrushSoilTile", "BulbulSoilTile", "CopperSoilTile", "DampSoilTile", "DarkRedSoilTile", "DarkWoodedSoilTile", "DeadSoilTile", "DewySoilTile", "DewyDropSoilTile", "EmptySoilTile", "ForestSoilTile", "GladeSoilTile", "GravelySoilTile", "GreenSoilTile", "GreenBirchSoilTile", "IcySoilTile", "LakeSoilTile", "LeadSoilTile", "LightSoilTile", "LiverSoilTile", "LufSoilTile", "LullatiowSoilTile", "MilkSoilTile", "MuddySoilTile", "MulchTile", "OakSoilTile", "OpirSoilTile", "OtioSoilTile", "PineSoilTile", "RedSoilTile", "RosySoilTile", "ScentedSoilTile", "SedgeSoilTile", "ShankSoilTile", "SilverFlackSoilTile", "SilverSoilTile", "SilverySoilTile", "SleepingSoilTile", "SnagSoilTile", "StinkySoilTile", "SumpSoilTile", "SwampSoilTile", "SweetilSoilTile", "SweetSoilTile", "TenebrousSoilTile", "TenelobousSoilTile", "TengolouaSoilTile", "ThornySoilTile", "TopiurSoilTile", "WaterySoilTile", "WeepungrSoilTile", "WillowedSoilTile", "YellowSoilTile" };

                                                    {
                                                        Main.tile[xAxis, yAxis].type = (ushort)mod.TileType(SoilTileArray[Main.rand.Next(SoilTileArray.Length)]); // every 4 tiles on surface replace with random soiltype

                                                    }
                                                }
                                                else
                                                {
                                                    if (Main.tile[xAxis, yAxis].type == 2)
                                                    {
                                                        Main.tile[xAxis, yAxis].type = (ushort)mod.TileType("DarkGrassTile");
                                                    }
                                                    if (Main.tile[xAxis, yAxis].type == 23)
                                                    {
                                                        Main.tile[xAxis, yAxis].type = (ushort)mod.TileType("CorruptDarkGrassTile");
                                                    }
                                                    if (Main.tile[xAxis, yAxis].type == 60)
                                                    {
                                                        Main.tile[xAxis, yAxis].type = (ushort)mod.TileType("FloweryDarkGrassTile");
                                                    }
                                                    if (Main.tile[xAxis, yAxis].type == 199)
                                                    {
                                                        Main.tile[xAxis, yAxis].type = (ushort)mod.TileType("FleshDarkGrassTile"); // grass replacement
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if (Main.tile[xAxis, yAxis].type == 2)
                                                {
                                                    Main.tile[xAxis, yAxis].type = (ushort)mod.TileType("DarkGrassTile");
                                                }
                                                if (Main.tile[xAxis, yAxis].type == 23)
                                                {
                                                    Main.tile[xAxis, yAxis].type = (ushort)mod.TileType("CorruptDarkGrassTile");
                                                }
                                                if (Main.tile[xAxis, yAxis].type == 60)
                                                {
                                                    Main.tile[xAxis, yAxis].type = (ushort)mod.TileType("FloweryDarkGrassTile");
                                                }
                                                if (Main.tile[xAxis, yAxis].type == 199)
                                                {
                                                    Main.tile[xAxis, yAxis].type = (ushort)mod.TileType("FleshDarkGrassTile"); // grass replacement
                                                }
                                            }

                                        }

                                        else if (Main.rand.Next(4) == 3)
                                        {
                                            string[] SoilTileArray1 = { "BloodStainedDarkSoilTile", "BirchyStainedDarkSoilTile", "BlackSeededDarkSoilTile", "BrushSoilTile", "BulbulSoilTile", "CopperSoilTile", "DampSoilTile", "DarkRedSoilTile", "DarkWoodedSoilTile", "DeadSoilTile", "DewySoilTile", "DewyDropSoilTile", "EmptySoilTile", "ForestSoilTile", "GladeSoilTile", "GravelySoilTile", "GreenSoilTile", "GreenBirchSoilTile", "IcySoilTile", "LakeSoilTile", "LeadSoilTile", "LightSoilTile", "LiverSoilTile", "LufSoilTile", "LullatiowSoilTile", "MilkSoilTile", "MuddySoilTile", "MulchTile", "OakSoilTile", "OpirSoilTile", "OtioSoilTile", "PineSoilTile", "RedSoilTile", "RosySoilTile", "ScentedSoilTile", "SedgeSoilTile", "ShankSoilTile", "SilverFlackSoilTile", "SilverSoilTile", "SilverySoilTile", "SleepingSoilTile", "SnagSoilTile", "StinkySoilTile", "SumpSoilTile", "SwampSoilTile", "SweetilSoilTile", "SweetSoilTile", "TenebrousSoilTile", "TenelobousSoilTile", "TengolouaSoilTile", "ThornySoilTile", "TopiurSoilTile", "WaterySoilTile", "WeepungrSoilTile", "WillowedSoilTile", "YellowSoilTile" };

                                            {
                                                Main.tile[xAxis, yAxis].type = (ushort)mod.TileType(SoilTileArray1[Main.rand.Next(SoilTileArray1.Length)]); // randomized soil type placement
                                            }
                                        }

                                        else

                                        {
                                            if (Main.tile[xAxis, yAxis].type == 2)
                                            {
                                                Main.tile[xAxis, yAxis].type = (ushort)mod.TileType("DarkGrassTile");
                                            }
                                            if (Main.tile[xAxis, yAxis].type == 23)
                                            {
                                                Main.tile[xAxis, yAxis].type = (ushort)mod.TileType("CorruptDarkGrassTile");
                                            }
                                            if (Main.tile[xAxis, yAxis].type == 60)
                                            {
                                                Main.tile[xAxis, yAxis].type = (ushort)mod.TileType("FloweryDarkGrassTile");
                                            }
                                            if (Main.tile[xAxis, yAxis].type == 199)
                                            {
                                                Main.tile[xAxis, yAxis].type = (ushort)mod.TileType("FleshDarkGrassTile"); // grass replacement
                                            }
                                        }
                                    } // finished grass replacement

                                } // end of grass replacement loop




                                string[] SoilTileArray2 = { "BloodStainedDarkSoilTile", "BirchyStainedDarkSoilTile", "BlackSeededDarkSoilTile", "BrushSoilTile", "BulbulSoilTile", "CopperSoilTile", "DampSoilTile", "DarkRedSoilTile", "DarkWoodedSoilTile", "DeadSoilTile", "DewySoilTile", "DewyDropSoilTile", "EmptySoilTile", "ForestSoilTile", "GladeSoilTile", "GravelySoilTile", "GreenSoilTile", "GreenBirchSoilTile", "IcySoilTile", "LakeSoilTile", "LeadSoilTile", "LightSoilTile", "LiverSoilTile", "LufSoilTile", "LullatiowSoilTile", "MilkSoilTile", "MuddySoilTile", "MulchTile", "OakSoilTile", "OpirSoilTile", "OtioSoilTile", "PineSoilTile", "RedSoilTile", "RosySoilTile", "ScentedSoilTile", "SedgeSoilTile", "ShankSoilTile", "SilverFlackSoilTile", "SilverSoilTile", "SilverySoilTile", "SleepingSoilTile", "SnagSoilTile", "StinkySoilTile", "SumpSoilTile", "SwampSoilTile", "SweetilSoilTile", "SweetSoilTile", "TenebrousSoilTile", "TenelobousSoilTile", "TengolouaSoilTile", "ThornySoilTile", "TopiurSoilTile", "WaterySoilTile", "WeepungrSoilTile", "WillowedSoilTile", "YellowSoilTile" };
                                for (int Trees = 0; Trees < SoilTileArray2.Length; Trees++)
                                {
                                    if (Main.tile[xAxis, yAxis].type == (ushort)mod.TileType(SoilTileArray2[Trees]))
                                    {

                                        WorldGen.PlaceTile(xAxis, yAxis - 1, mod.TileType("BloodoakSapling")); //doesnt matter which sapling



                                    }

                                } // sapling placement






                                
                                int[] ClayTileArray = { 40, 161, 163, 164, 200 };
                                for (int BiomeDirtReplace2 = 0; BiomeDirtReplace2 < ClayTileArray.Length; BiomeDirtReplace2++)
                                {
                                    if (Main.tile[xAxis, yAxis].type == (ushort)ClayTileArray[BiomeDirtReplace2])
                                    {
                                        {

                                            Main.tile[xAxis, yAxis].type = (ushort)mod.TileType("PeatTile"); // replace clay and ice

                                        }
                                    }
                                }


                                if (Main.tile[xAxis, yAxis].type == 1) //stone replacement

                                {

                                    Main.tile[xAxis, yAxis].type = (ushort)mod.TileType("AncientMossStoneTile");

                                }

                                if (Main.tile[xAxis, yAxis].type == 80) //Cactus replacement

                                {

                                    Main.tile[xAxis, yAxis].active(false);

                                }






                            }
                            

                            
                        } 
                        yAxis++; 
                    } // end of y axis run 
                    xAxis++;
                } // end of x axis run
                
                
            }));

            

        }

    }

}


