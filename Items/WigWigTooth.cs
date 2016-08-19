using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheEdge.Items
{
    public class WigWigTooth : ModItem
    {

        public override void SetDefaults()
        {
            item.name = "WigWig Tooth";
            item.width = 8;
            item.height = 20;
            AddTooltip("Thin and spiky");
            item.maxStack = 999;
            item.value = Item.buyPrice(0, 0, 5, 0);
            item.rare = 2;
        }



    }
}