using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheEdge.Items.Placeable
{
    public class BloodoakTimber : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Bloodoak Timber";
            item.width = 12;
            item.height = 12;
            item.maxStack = 999;
            AddTooltip("Extremely bouyant, prime material for skyships");
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("BloodoakTimberTile"); //put your CustomBlock Tile name
        }
        
    }
}
