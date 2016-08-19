using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheEdge.Items
{
    public class AnglerLureShard : ModItem
    {       

        public override void SetDefaults()
        {
            item.name = "Angler Lure Shard";
            item.width = 24;
            item.height = 18;
            AddTooltip("soooo... Shiny");
            item.maxStack = 999;
            item.value = Item.buyPrice(0, 50, 0, 0);
            item.rare = 8;
        }

        
        
    }
}