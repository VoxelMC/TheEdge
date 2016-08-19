using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheEdge.Items.Placeable
{
    public class MireSludge : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Mire Sludge";
            item.width = 12;
            item.height = 12;
            item.maxStack = 999;
            AddTooltip("Dont be fooled.... Its a building material");
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("MireSludgeTile"); //put your CustomBlock Tile name
        }
        
    }
}
