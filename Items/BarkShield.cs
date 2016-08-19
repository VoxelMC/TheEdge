using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheEdge.Items
{
    public class BarkShield : ModItem
    {


        public override void SetDefaults()
        {
            item.name = "Bark Shield";
            item.width = 62;
            item.height = 60;
            item.toolTip = "Tada you have a glowey greeny thingy";
            item.value = Item.buyPrice(0, 15, 0, 0);
            item.rare = 4;
            item.accessory = true;
        }

        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Shield);
            return true;
        }

        public override void AddRecipes()  //How to craft this item
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient("EnchantedBark", 21);
            recipe.AddIngredient("Moss", 20);
            recipe.AddIngredient("WigWigFur", 2);
            recipe.AddIngredient(ItemID.Wood, 30);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            Lighting.AddLight(player.position, 1f, 2.7f, 1f);
            player.noKnockback = true;
        }
    }
}