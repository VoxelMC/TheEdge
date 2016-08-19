using Terraria;
using System;
using Terraria.ID;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace TheEdge.Items.Weapons
{
    public class PancakeYoyo : ModItem
    {

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.WoodYoyo);
            item.name = "Pancake Yoyo";
            item.damage = 2;
            item.value = Item.buyPrice(0, 0, 0, 2);
            item.rare = 1;
            item.toolTip = "Requested by a bozo";
            item.knockBack = 1;
            item.channel = true;
            item.useStyle = 5;
            item.useAnimation = 25;
            item.useTime = 25;
            item.shoot = mod.ProjectileType("PancakeYoyoPro");           
        }

        public override void AddRecipes()

        {                                                   //How to craft this item
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(null, "DemonHeart", 42);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }
}