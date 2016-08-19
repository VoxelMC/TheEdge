using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheEdge.Items.Armor
{
    public class AnglerBreastplate : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Body);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Angler Breastplate";
            item.width = 18;
            item.height = 18;
            AddTooltip("This shall light the way");
            AddTooltip2("Lure your enemys to thier death");
            item.value = Item.buyPrice(1, 0, 0, 0);
            item.rare = 8;
            item.defense = 19;
        }

        public override void UpdateEquip(Player player)
        {
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient("AnglerLureShard", 1);
            recipe.AddIngredient("AnglerScale", 100);
            recipe.AddIngredient("AnglerTooth", 50);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
}