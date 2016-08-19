using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheEdge.Items
{
    public class WigWigFur : ModItem
    {

        public override void SetDefaults()
        {
            item.name = "WigWig Fur";
            item.width = 34;
            item.height = 22;
            AddTooltip("So soft and... Orange");
            item.maxStack = 999;
            item.value = Item.buyPrice(0, 0, 20, 0);
            item.rare = 2;
        }



    }
}