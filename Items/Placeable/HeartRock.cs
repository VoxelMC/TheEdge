using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheEdge.Items.Placeable
{
    public class HeartRock : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Heartrock";
            item.width = 12;
            item.height = 12;
            item.maxStack = 999;
            AddTooltip("Found in the centre of FLight-Rocks");
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("HeartRockTile"); //put your CustomBlock Tile name
        }
        
    }
}
