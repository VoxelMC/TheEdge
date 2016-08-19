using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;


//By Al0n37
namespace TheEdge.NPCs
{
    public class BarkDemon : ModNPC
    {
        public override void SetDefaults()
        {
            npc.name = "BarkDemon";
            npc.displayName = "Bark Demon";
            npc.width = 28;
            npc.height = 48;
            npc.damage = 40;
            npc.defense = 20;
            npc.lifeMax = 50;
            npc.soundHit = 1;
            npc.soundKilled = 13;
            npc.value = 3000;
            npc.knockBackResist = 0.5f;
            Main.npcFrameCount[npc.type] = 8;
            npc.aiStyle = 3;
            aiType = NPCID.Zombie;
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
            return spawnInfo.spawnTileY < Main.rockLayer && Main.dayTime ? 0.1f : 0f; //spown at day
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
                





                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("EnchantedBark"), (rand1.Next(2, 12)));

                if (rand.Next(0, 50) == 1)

                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DemonHeart"), 1);
            }

        }
    }
}