using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheEdge.Items.Placeable
{
    public class BloodStainedDarkSoil : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Blood Stained Dark Soil";
            item.width = 12;
            item.height = 12;
            item.maxStack = 999;
            AddTooltip("Only found around the base of Bloodoaks");
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("BloodStainedDarkSoilTile"); //put your CustomBlock Tile name
        }
        
    }
}
