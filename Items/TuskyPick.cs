using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheEdge.Items
{
    public class TuskyPick : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Tusky Pick";
            item.damage = 11;
            item.melee = true;
            item.width = 34;
            item.height = 34;
            item.toolTip = "Made from the sacred Tusk of a Banderbear.";
            item.useTime = 21;
            item.useAnimation = 20;
            item.pick = 125;    //pickaxe power
            item.useStyle = 1;
            item.knockBack = 4;
            item.value = Item.buyPrice(0, 20, 0, 0); ;
            item.rare = 5;
            item.useSound = 1;
            item.autoReuse = true;
            item.useTurn = true;
        }
        public override void AddRecipes()  //How to craft this item
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Wood, 2);
            recipe.AddIngredient("Mossfur", 10);
            recipe.AddIngredient("BanderbearTooth", 2);
            recipe.AddIngredient("EnchantedBark", 5);//you need 10 Wood
            recipe.AddTile(TileID.Anvils);   //at work bench
            recipe.SetResult(this);  
            recipe.AddRecipe();
        }
    }
}