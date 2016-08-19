using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheEdge.Items
{
    public class WigWigInnards : ModItem
    {

        public override void SetDefaults()
        {
            item.name = "WigWig Innards";
            item.width = 11;
            item.height = 14;
            AddTooltip("ewww, so Gross.");
            item.maxStack = 999;
            item.value = Item.buyPrice(0, 50, 0, 0);
            item.rare = 6;
        }



    }
}