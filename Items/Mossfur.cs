using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheEdge.Items
{
    public class Mossfur : ModItem
    {       

        public override void SetDefaults()
        {
            item.name = "Mossfur";
            item.width = 26;
            item.height = 32;
            AddTooltip("YOU KILLED A BANDERBEAR?!?!?!?!?!... sad");
            item.maxStack = 999;
            item.value = Item.buyPrice(0, 0, 50, 0);
            item.rare = 3;
        }

        
        
    }
}