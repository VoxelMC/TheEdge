using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheEdge.Items
{
    public class DemonHeart : ModItem
    {

        public override void SetDefaults()
        {
            item.name = "Demon Heart";
            item.width = 18;
            item.height = 18;
            AddTooltip("It still has veins attached.");
            item.maxStack = 999;
            item.value = Item.buyPrice(0, 35, 0, 0);
            item.rare = 6;
        }



    }
}