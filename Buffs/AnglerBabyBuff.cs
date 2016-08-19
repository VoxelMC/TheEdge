using System;
using Terraria;
using Terraria.ModLoader;

namespace TheEdge.Buffs
{
    public class AnglerBabyBuff : ModBuff
    {
        public override void SetDefaults()
        {
            Main.buffName[Type] = "Angler Baby Minion";
            Main.buffTip[Type] = "This may be a baby, but ...";
            Main.buffNoSave[Type] = true;
            Main.buffNoTimeDisplay[Type] = true;

        }

        public override void Update(Player player, ref int buffIndex)
        {
            MyPlayer modPlayer = (MyPlayer)player.GetModPlayer(mod, "MyPlayer");
            if (player.ownedProjectileCounts[mod.ProjectileType("AnglerBabyMinion")] > 0)
            {
                modPlayer.AnglerBabyMinion = true;
            }
            if (!modPlayer.AnglerBabyMinion)
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