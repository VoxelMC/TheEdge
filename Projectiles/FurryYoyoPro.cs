using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheEdge.Projectiles
{
    public class FurryYoyoPro : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.CrimsonYoyo);
            projectile.name = "Furry Yoyo";
            projectile.penetrate = 5;  
            projectile.width = 16;
            projectile.height = 16;
        }

    }
}