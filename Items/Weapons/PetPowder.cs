using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheEdge.Items.Weapons
{
    public class PetPowder : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Pet Powder";
            item.damage = 1;
            item.melee = true;
            item.width = 22;
            item.height = 26;
            item.toolTip = "Gurantees a pet or town NPC drop from any of The Edge Enemies.";
            item.useTime = 1;
            item.useAnimation = 21;
            item.useStyle = 1;
            item.knockBack = 3;
            item.value = Item.buyPrice(1, 50, 0, 0);
            item.rare = 8;
            item.useSound = 44;
            item.consumable = true;

        }

        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
            if (target.name == "Angler")
            {
                Item.NewItem((int)target.position.X, (int)target.position.Y, target.width, target.height, mod.ItemType("AnglerStaff"), 1);
            }
            if (target.name == "WigWig")
            {
                Item.NewItem((int)target.position.X, (int)target.position.Y, target.width, target.height, mod.ItemType("WigWigStaff"), 1);
            }
        }
        public override bool ConsumeItem(Player player)
        {
            
            return true;
        }
    }
}