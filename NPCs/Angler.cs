using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;


namespace TheEdge.NPCs
{
    public class Angler : ModNPC
    {

        int dropChance;
        public override void SetDefaults()
        {
            npc.name = "Angler";
            npc.displayName = "Angler";
            npc.width = 160;
            npc.height = 95;
            npc.damage = 60;
            npc.defense = 25;
            npc.lifeMax = 1543;
            npc.soundHit = 1;
            npc.soundKilled = 13;
            npc.value = 40000f;
            npc.knockBackResist = 0.8f;
            npc.aiStyle = 3;
            Main.npcFrameCount[npc.type] = 8;
            aiType = NPCID.Zombie;  //npc behavior

        }

        


        public bool preAI()
        {
            return true;
        }


        public override void AI()
        {
            npc.TargetClosest(true);


            
            if (npc.direction == 1)
            {
                npc.position.X += 4;
            }

            if (npc.direction == -1)
            {
                npc.position.X += -4;
            }
        }
        
        public override void FindFrame(int frameHeight)
        {

            npc.spriteDirection = npc.direction;
            
            if (npc.velocity.X > 0)
                npc.frameCounter += 1.0 + (npc.velocity.X / 2);
            else
                npc.frameCounter += 1.0;

            npc.frameCounter %= 24.0;
            npc.frame.Y = frameHeight * (int)(npc.frameCounter / 6.0);
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



                
                
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("AnglerTooth"), (rand1.Next(2, 12)));
               
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("AnglerScale"), (rand2.Next(0, 4)));

                if (rand.Next(0, 50) == 1)

                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("AnglerLureShard"), 1);

                if (rand3.Next(0, 150) == 1)

                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("AnglerHelmet"), 1);

                if (rand4.Next(0, 150) == 1)

                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("AnglerBreastplate"), 1);

                if (rand5.Next(0, 150) == 1)

                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("AnglerBoots"), 1);
                if (rand5.Next(0, 150) == 1)

                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("AnglerStaff"), 1);


            }

        }



    }
    }
