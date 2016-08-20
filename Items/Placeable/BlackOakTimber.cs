using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheEdge.Items.Placeable
{
    public class BlackOakTimber : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Black Oak Timber";
            item.width = 12;
            item.height = 12;
            item.maxStack = 999;
            AddTooltip("A timber found from cutting down Black Oak Trees");
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("BlackOakTimberTile"); //put your CustomBlock Tile name
        }
        
    }
}
