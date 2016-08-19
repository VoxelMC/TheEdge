using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheEdge.Items.Armor
{
    public class AnglerLeggings : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Legs);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Angler Leggings";
            item.width = 18;
            item.height = 18;
            AddTooltip("The powerful flippers of an Angler");
            AddTooltip2("These may hold untold secrets of illumination.");
            item.value = Item.buyPrice(0, 80, 0, 0);
            item.rare = 8;
            item.defense = 14;
        }

        public override void UpdateEquip(Player player)
        {
            player.moveSpeed += 2.3f;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient("AnglerLureShard", 1);
            recipe.AddIngredient("AnglerScale", 50);
            recipe.AddIngredient("AnglerTooth", 25);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
}