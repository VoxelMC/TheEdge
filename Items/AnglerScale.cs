using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheEdge.Items
{
    public class AnglerScale : ModItem
    {       

        public override void SetDefaults()
        {
            item.name = "Angler Scale";
            item.width = 36;
            item.height = 28;
            AddTooltip("eww Slimy");
            item.maxStack = 999;
            item.value = Item.buyPrice(0, 1, 0, 0);
            item.rare = 4;
        }

        
        
    }
}