using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheEdge.Items.Placeable
{
    public class AncientMossStone : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Ancient Moss Stone";
            item.width = 16;
            item.height = 16;
            item.maxStack = 999;
            AddTooltip("Very strong and slippery");
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("AncientMossStoneTile"); //put your CustomBlock Tile name
        }
        
    }
}
