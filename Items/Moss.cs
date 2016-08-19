using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheEdge.Items
{
    public class Moss : ModItem
    {       

        public override void SetDefaults()
        {
            item.name = "Moss";
            item.width = 11;
            item.height = 10;
            AddTooltip("It's actually quite soft.");
            item.maxStack = 999;
            item.value = Item.buyPrice(0, 0, 50, 0);
            item.rare = 3;
        }

        
        
    }
}