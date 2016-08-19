using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheEdge.Items.Placeable
{
    public class IronWoodSaplingItem : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Ironwood Sapling";
            item.width = 12;
            item.height = 12;
            item.maxStack = 999;
            AddTooltip("A seed for the strongest of trees.");
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("IronWoodSapling"); 
        }
        
    }
}
