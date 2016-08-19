using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheEdge.Items.Placeable
{
    public class Peat : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Peat";
            item.width = 16;
            item.height = 16;
            item.maxStack = 999;
            AddTooltip("It's decomposing plant matter.");
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("PeatTile"); //put your CustomBlock Tile name
        }
        
    }
}
