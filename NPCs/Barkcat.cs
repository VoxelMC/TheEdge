using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;


//By Al0n37
namespace TheEdge.NPCs
{
    public class Barkcat : ModNPC
    {
        public override void SetDefaults()
        {
            npc.name = "Barkcat";
            npc.displayName = "Barkcat";
            npc.width = 50;
            npc.height = 40;
            npc.damage = 12;
            npc.defense = 15;
            npc.lifeMax = 30;
            npc.soundHit = 1;
            npc.soundKilled = 13;
            npc.value = 5000;
            npc.knockBackResist = 0.3f;
            Main.npcFrameCount[npc.type] = 4;
            npc.aiStyle = 3;
            aiType = NPCID.BoneLee;
        }

        public bool preAI()
        {          
            return true;
        }

        public override void AI()
        {
             npc.TargetClosest(true);

            if (npc.direction == 1)
            { npc.position.X += 0; }

            if (npc.direction == -1)
            { npc.position.X += 0; }

            
        }

        public override float CanSpawn(NPCSpawnInfo spawnInfo)
        {
            return spawnInfo.spawnTileY < Main.rockLayer && Main.dayTime ? 0.3f : 0f; //spown at day
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

                if (rand.Next(0, 15) == 1)
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("EnchantedBark"), (rand1.Next(0, 30)));

                if (rand1.Next(0, 8) == 1)
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Moss"), (rand1.Next(0, 40)));

            }

        }
    }
}