
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheEdge.Projectiles
{
    public class PancakeYoyoPro : ModProjectile
    {

        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.CrimsonYoyo);
            projectile.name = "Pancake Yoyo";
            projectile.penetrate = -1;  
            projectile.width = 16;
            projectile.height = 16;
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            mod.BuffType("WigWigBuff");
        }
    }
}