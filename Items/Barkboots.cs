using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheEdge.Items
{
    public class Barkboots : ModItem
    {


        public override void SetDefaults()
        {
            item.name = "Barkboots";
            item.width = 20;
            item.height = 20;
            item.toolTip = "Bark + Boots = Barkboots, but hey you probably already new that";
            item.value = Item.buyPrice(0, 10, 0, 0);
            item.rare = 4;
            item.accessory = true;
        }

        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Shoes);
            return true;
        }

        public override void AddRecipes()  //How to craft this item
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient("EnchantedBark", 13);
            recipe.AddIngredient("Moss", 9);
            recipe.AddIngredient("WigWigFur", 9);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            float regenAmount = Math.Abs(player.velocity.X) * 2;
            player.moveSpeed += 2.15f;
            player.lifeRegen += (int)regenAmount;
            Lighting.AddLight(player.position, 1f, 2.7f, 1f);
        }
    }
}