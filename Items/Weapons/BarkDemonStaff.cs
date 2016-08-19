using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheEdge.Items.Weapons
{
    public class BarkDemonStaff : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Bark Demon Staff";
            item.damage = 20;
            item.summon = true;
            item.mana = 8;
            item.width = 40;
            item.height = 40;
            item.toolTip = "Summons the elusive Bark Demon to fight for you.";
            item.useTime = 26;
            item.useAnimation = 26;
            item.useStyle = 1;
            item.noMelee = true;
            item.knockBack = 3;
            item.value = Item.buyPrice(0, 75, 0, 0);
            item.rare = 7;
            item.useSound = 44;
            item.shoot = mod.ProjectileType("BarkDemonMinion");
            item.shootSpeed = 7f;
            item.buffType = mod.BuffType("BarkDemonBuff");
            item.buffTime = 3600;

        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient("DemonHeart", 1);
            recipe.AddIngredient("EnchantedBark", 48);
            
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}