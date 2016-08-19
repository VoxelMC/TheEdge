using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheEdge.Items.Weapons
{
    public class AnglerStaff : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Angler Staff";
            item.damage = 30;
            item.summon = true;
            item.mana = 10;
            item.width = 34;
            item.height = 34;
            item.toolTip = "Summons a baby Angler to kill some stuff.";
            item.useTime = 26;
            item.useAnimation = 26;
            item.useStyle = 1;
            item.noMelee = true;
            item.knockBack = 3;
            item.value = Item.buyPrice(1, 50, 0, 0);
            item.rare = 8;
            item.useSound = 44;
            item.shoot = mod.ProjectileType("AnglerBabyMinion");
            item.shootSpeed = 7f;
            item.buffType = mod.BuffType("AnglerBabyBuff");
            item.buffTime = 3600;

        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient("AnglerLureShard", 1);
            recipe.AddIngredient("AnglerScale", 24);
            recipe.AddIngredient("AnglerTooth", 36);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}