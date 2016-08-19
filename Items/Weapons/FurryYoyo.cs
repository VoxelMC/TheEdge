using Terraria;
using System;
using Terraria.ID;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace TheEdge.Items.Weapons
{
    public class FurryYoyo : ModItem
    {

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.WoodYoyo);
            item.name = "Furry Yoyo";
            item.damage = 42;
            item.value = Item.buyPrice(0, 13, 0, 0);
            item.rare = 4;
            item.knockBack = 1;
            item.channel = true;
            item.useStyle = 5;
            item.useAnimation = 25;
            item.useTime = 25;
            item.shoot = mod.ProjectileType("FurryYoyoPro");           
        }

        public override void AddRecipes()
        {                                                   //How to craft this item
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "WigWigFur", 42);
            recipe.AddIngredient(null, "WigWigTooth", 42);
            recipe.AddIngredient(null, "WigWigInnards", 1);//exeample of how to craft with a modded item
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}