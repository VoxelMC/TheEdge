using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;

//By Al0n37
namespace TheEdge.NPCs
{
    public class AnglerLure : ModNPC
    {

        int direct = 0;

        

        public override void SetDefaults()
        {
            npc.name = "Ripe Oakapple";
            npc.displayName = "Ripe Oakapple";
            npc.width = 81;
            npc.height = 68;
            npc.damage = 0;
            npc.defense = 0;
            npc.lifeMax = 5;
            npc.soundHit = 1;
            npc.soundKilled = 13;
            npc.value = 70f;
            npc.knockBackResist = 1f;
            Main.npcFrameCount[npc.type] = 1;
        }

        

        public bool preAI()
        {          
            return true;
        }

        public override void AI()
        {

            if (npc.direction == 1)
            { npc.position.X += 0; }

            if (npc.direction == -1)
            { npc.position.X += 0; }

            
        }

        

        public override float CanSpawn(NPCSpawnInfo spawnInfo)
        {
            return spawnInfo.spawnTileY < Main.rockLayer && Main.dayTime ? 0.05f : 0f; //spown at day
        }
        public override void FindFrame(int frameHeight)
        {
            Random rand = new Random();

            if (direct == 0)
            if (rand.Next(0, 2) == 0)
                direct += -1;
            else direct += 1;

            npc.spriteDirection = direct;
            npc.frame.Y = 0;
        }

        public override void HitEffect(int hitDirection, double damage)
        {
            
            npc.Transform(mod.NPCType("Angler"));
            
        }

        public override void NPCLoot()  //Npc drop
        {
            {
                
            }

        }
    }
}