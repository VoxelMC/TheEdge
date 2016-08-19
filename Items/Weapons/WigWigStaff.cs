using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheEdge.Items.Weapons
{
    public class WigWigStaff : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "WigWig Staff";
            item.damage = 30;
            item.summon = true;
            item.mana = 10;
            item.width = 34;
            item.height = 34;
            item.toolTip = "Summons a little WigWig to devour your enemies.";
            item.useTime = 26;
            item.useAnimation = 26;
            item.useStyle = 1;
            item.noMelee = true;
            item.knockBack = 3;
            item.value = Item.buyPrice(1, 50, 0, 0);
            item.rare = 8;
            item.useSound = 44;
            item.shoot = mod.ProjectileType("WigWigMinion");
            item.shootSpeed = 7f;
            item.buffTime = 3600;
            item.buffType = mod.BuffType("WigWigBuff");
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient("WigWigInnards", 1);
            recipe.AddIngredient("WigWigFur", 85);
            recipe.AddIngredient("WigWigTooth", 46);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}