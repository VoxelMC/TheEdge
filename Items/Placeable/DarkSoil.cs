using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheEdge.Items.Placeable
{
    public class DarkSoil : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Dark Soil";
            item.width = 12;
            item.height = 12;
            item.maxStack = 999;
            AddTooltip("Very furtile, only found in the Deepwoods");
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("DarkSoilTile"); //put your CustomBlock Tile name
        }
        
    }
}
