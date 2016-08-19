using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheEdge.Items.Placeable
{
    public class IronwoodTimber : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Ironwood Timber";
            item.width = 12;
            item.height = 12;
            item.maxStack = 999;
            AddTooltip("Very stable timber, does not respond to heat");
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("IronwoodTimberTile"); //put your CustomBlock Tile name
        }
        
    }
}
