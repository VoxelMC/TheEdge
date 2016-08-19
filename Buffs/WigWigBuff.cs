using System;
using Terraria;
using Terraria.ModLoader;

namespace TheEdge.Buffs
{
    public class WigWigBuff : ModBuff
    {
        public override void SetDefaults()
        {
            Main.buffName[Type] = "WigWig Minion";
            Main.buffTip[Type] = "How pretty... Hehe";
            Main.buffNoSave[Type] = true;
            Main.buffNoTimeDisplay[Type] = true;

        }

        public override void Update(Player player, ref int buffIndex)
        {
            MyPlayer modPlayer = (MyPlayer)player.GetModPlayer(mod, "MyPlayer");
            if (player.ownedProjectileCounts[mod.ProjectileType("WigWigMinion")] > 0)
            {
                modPlayer.WigWigMinion = true;
            }
            if (!modPlayer.WigWigMinion)
            {
                player.DelBuff(buffIndex);
                buffIndex--;
            }
            else
            {
                player.buffTime[buffIndex] = 18000;
            }
        }
    }
}