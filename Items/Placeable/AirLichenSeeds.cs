using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheEdge.Items.Placeable
{
	public class AirLichenSeeds : ModItem
	{
		public override void SetDefaults()
		{
			item.autoReuse = true;
			item.name = "Air Lichen Seeds";
			item.useTurn = true;
			item.useStyle = 1;
			item.useAnimation = 15;
			item.useTime = 10;
			item.maxStack = 99;
			item.consumable = true;
			item.placeStyle = 0;
			item.width = 12;
			item.height = 14;
			item.value = 80;
			item.createTile = mod.TileType("AirLichen");
		}

		
	}
}