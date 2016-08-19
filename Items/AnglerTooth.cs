using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheEdge.Items
{
    public class AnglerTooth : ModItem
    {       

        public override void SetDefaults()
        {
            item.name = "Angler Tooth";
            item.width = 14;
            item.height = 22;
            AddTooltip("Dangerously sharp");
            item.maxStack = 999;
            item.value = Item.buyPrice(0, 0, 50, 0);
            item.rare = 4;
        }

        
        
    }
}