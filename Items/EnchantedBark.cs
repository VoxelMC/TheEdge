using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheEdge.Items
{
    public class EnchantedBark : ModItem
    {       

        public override void SetDefaults()
        {
            item.name = "Enchanted Bark";
            item.width = 32;
            item.height = 26;
            AddTooltip("Shiny, but otherwise its just... brown.");
            item.maxStack = 999;
            item.value = Item.buyPrice(0, 1, 0, 0);
            item.rare = 3;
        }

        
        
    }
}