using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;


namespace TheEdge.NPCs
{
    public class WigWigOpen : ModNPC
    {

        int dropChance;
        int spawnRush;
        public override void SetDefaults()
        {
            npc.name = "WigWigOpen";
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

        }

        


        public bool preAI()
        {
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

       

    }
}
