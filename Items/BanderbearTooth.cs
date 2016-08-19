using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheEdge.Items
{
    public class BanderbearTooth : ModItem
    {       

        public override void SetDefaults()
        {
            item.name = "Banderbear Tooth";
            item.width = 12;
            item.height = 18;
            AddTooltip("Scary sharp and really long");
            item.maxStack = 999;
            item.value = Item.buyPrice(0, 20, 0, 0);
            item.rare = 7;
        }

        
        
    }
}