using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;


namespace TheEdge.NPCs
{
    public class WigWig : ModNPC
    {

        int dropChance;
        int spawnRush;
        public override void SetDefaults()
        {
            npc.name = "WigWig";
            npc.displayName = "WigWig";
            npc.width = 58;
            npc.height = 38;
            npc.damage = 60;
            npc.defense = 2;
            npc.lifeMax = 25;
            npc.soundHit = 1;
            npc.soundKilled = 1;
            npc.value = 2500f;
            npc.knockBackResist = 0f;
            npc.aiStyle = 1;
            Main.npcFrameCount[npc.type] = 2;
            aiType = NPCID.BlueSlime;  //npc behavior
            animationType = NPCID.BlueSlime;
            spawnRush = 0;
        }






        public override bool PreAI()
        {
            Random Xpos = new Random();
            Random spawnNumber = new Random();

            if (npc.ai[2] == 0f)
            {
                spawnRush = 0;
                return true;
            }
            else if (npc.ai[2] == 1f)
            {
                spawnRush += 1;

                if (spawnRush < (Xpos.Next(8, 12)))
                {
                    NPC.NewNPC((int)npc.position.X + (Xpos.Next(-200, 200)), (int)npc.position.Y + -100, mod.NPCType("WigWigClone"), 0, 0f, 0f, 0f, 0f, 255);
                    npc.ai[2] = 1;
                }
                else
                {
                    npc.ai[2] = 0f;
                }
            }
            return true;
        }


        public override void AI()
        {
            npc.TargetClosest(true);


            if (npc.velocity.X == 0)
            if (npc.direction == 1)
            {
                npc.position.X += 0;
            }

            if (npc.direction == -1)
            {
                npc.position.X += 0;
            }
        }
        public override void FindFrame(int frameHeight)
        {

            npc.spriteDirection = npc.direction;
        }


        public override float CanSpawn(NPCSpawnInfo spawnInfo)
        {
            return spawnInfo.spawnTileY < Main.rockLayer && Main.dayTime ? 0.1f : 0f; 
        }

        public override void NPCLoot()  //Npc drop
        {
            {
                Random rand = new Random();
                Random rand1 = new Random();
                Random rand2 = new Random();
                Random rand3 = new Random();
                Random rand4 = new Random();
                Random rand5 = new Random();



                
                
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("WigWigFur"), (rand1.Next(2, 10)));
               
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("WigWigTooth"), (rand2.Next(0, 12)));

                if (rand.Next(0, 350) == 1)

                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("WigWigInnards"), 1);


            }

        }

        public override void OnHitPlayer(Player target, int damage, bool crit)
        {
            npc.Transform(mod.NPCType("WigWigOpen"));
        }


    }
    }
