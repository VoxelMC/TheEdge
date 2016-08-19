using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheEdge.Items.Placeable
{
    public class BloodoakSaplingItem : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Bloodoak Sapling";
            item.width = 12;
            item.height = 12;
            item.maxStack = 999;
            AddTooltip("You do not cut down Bloodoaks, You hunt them.");
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("BloodoakSapling"); 
        }
        
    }
}
