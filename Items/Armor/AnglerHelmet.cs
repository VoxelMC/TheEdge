using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheEdge.Items.Armor
{
    public class AnglerHelmet : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Head);
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Angler Helmet";
            item.width = 18;
            item.height = 18;
            item.toolTip = "Great power lies in weird places";
            item.toolTip2 = "Creepy";
            item.value = Item.buyPrice(0, 80, 0, 0);
            item.rare = 8;
            item.defense = 14;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("AnglerBreastplate") && legs.type == mod.ItemType("AnglerLeggings");  //put your Breastplate name and Leggings name
        }
        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "The powers of Angler-kind"; // the armor set bonus
            player.maxMinions = 12;
            player.minionDamage *= 0.2f;
            Lighting.AddLight(player.position, 3.0f, 2.7f, 1f);
            player.AddBuff(BuffID.Spelunker, 2);
            player.AddBuff(BuffID.Gills, 2);
        }
        public override void UpdateEquip(Player player)
        {
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