using System;
using Terraria;
using Terraria.ModLoader;

namespace TheEdge.Buffs
{
    public class BarkDemonBuff : ModBuff
    {
        public override void SetDefaults()
        {
            Main.buffName[Type] = "Bark Demon Minion";
            Main.buffTip[Type] = "Why did you summon such a foul creature?";
            Main.buffNoSave[Type] = true;
            Main.buffNoTimeDisplay[Type] = true;

        }

        public override void Update(Player player, ref int buffIndex)
        {
            MyPlayer modPlayer = (MyPlayer)player.GetModPlayer(mod, "MyPlayer");
            if (player.ownedProjectileCounts[mod.ProjectileType("BarkDemonMinion")] > 0)
            {
                modPlayer.BarkDemonMinion = true;
            }
            if (!modPlayer.BarkDemonMinion)
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