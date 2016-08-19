using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheEdge.Items.Placeable
{
    public class DarkElmTimber : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Dark Elm Timber";
            item.width = 12;
            item.height = 12;
            item.maxStack = 999;
            AddTooltip("Dropped from a Dark Elm Tree");
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("DarkElmTimberTile"); //put your CustomBlock Tile name
        }
        
    }
}
