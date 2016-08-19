using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheEdge.Items.Placeable
{
    public class MireDirt : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Mire Dirt";
            item.width = 12;
            item.height = 12;
            item.maxStack = 999;
            AddTooltip("The only stable thing in the mire.");
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("MireDirtTile"); //put your CustomBlock Tile name
        }
        
    }
}
