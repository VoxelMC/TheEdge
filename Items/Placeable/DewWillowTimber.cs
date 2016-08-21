using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheEdge.Items.Placeable
{
    public class DewWillowTimber : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Dew-Willow Timber";
            item.width = 12;
            item.height = 12;
            item.maxStack = 999;
            AddTooltip("It glows!!");
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("DewWillowTimberTile"); //put your CustomBlock Tile name
        }
        
    }
}
