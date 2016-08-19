using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheEdge.Items.Placeable
{
    public class FrozenDarkSoil : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Frozen Dark Soil";
            item.width = 16;
            item.height = 16;
            item.maxStack = 999;
            AddTooltip("Its pretty cold");
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("FrozenDarkSoilTile"); //put your CustomBlock Tile name
        }
        
    }
}
