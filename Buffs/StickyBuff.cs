using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheEdge.Buffs
{
    public class StickyBuff : ModBuff
    {
        public override void SetDefaults()
        {
            Main.buffName[this.Type] = "Sticky";
            Main.buffTip[this.Type] = "Your covered in maple syrup.";
        }
        public override void Update(NPC npc, ref int buffIndex)
        {
            npc.velocity *= 0.2f;
            npc.buffTime[buffIndex] = 18000;
        }





        public override void Update(Player player, ref int buffIndex)
        {                                             //this buff will increase melee damage and life regen


            {
                player.velocity *= 0.2f;
                player.buffTime[buffIndex] = 18000;
            }

        }
    }
}