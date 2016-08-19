using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;


namespace TheEdge.NPCs
{
    public class Banderbear : ModNPC
    {

        int dropChance;
        public override void SetDefaults()
        {
            npc.name = "Banderbear";
            npc.displayName = "Banderbear";
            npc.width = 56;
            npc.height = 98;
            npc.damage = 5;
            npc.defense = 32;
            npc.lifeMax = 1000;
            npc.soundHit = 1;
            npc.soundKilled = 13;
            npc.value = 400000f;
            npc.knockBackResist = 0.9f;
            npc.aiStyle = 3;
            Main.npcFrameCount[npc.type] = 7;
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
                npc.position.X += 1;
            }

            if (npc.direction == -1)
            {
                npc.position.X += -1;
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



                
                
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("BeardTuft"), (rand1.Next(1, 3)));
               
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Mossfur"), (rand2.Next(12, 48)));

                if (rand.Next(0, 50) == 1)

                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("BanderbearTooth"), (rand3.Next(1, 2)));



            }

        }

        public override void HitEffect(int hitDirection, double damage)
        {

            npc.Transform(mod.NPCType("EnragedBanderbear"));

        }

    }
    }
