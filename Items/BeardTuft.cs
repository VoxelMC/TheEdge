using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheEdge.Items
{
    public class BeardTuft : ModItem
    {

        public override void SetDefaults()
        {
            item.name = "Beard Tuft";
            item.width = 14;
            item.height = 16;
            AddTooltip("Its really soft");
            item.maxStack = 999;
            item.value = Item.buyPrice(0, 1, 0, 0);
            item.rare = 2;
        }



    }
}