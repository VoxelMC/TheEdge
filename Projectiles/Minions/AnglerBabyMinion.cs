using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheEdge.Projectiles.Minions
{
    public class AnglerBabyMinion : AnglerBabyINFO
    {
        public override void SetDefaults()
        {
            projectile.netImportant = true;
            projectile.name = "AnglerBaby";
            projectile.width = 61;
            projectile.height = 41;
            Main.projFrames[projectile.type] = 15;
            projectile.friendly = true;
            Main.projPet[projectile.type] = true;
            projectile.minion = true;
            projectile.netImportant = true;
            projectile.minionSlots = 1;
            projectile.penetrate = -1;
            projectile.timeLeft = 18000;
            projectile.tileCollide = true;
            projectile.ignoreWater = true;
            ProjectileID.Sets.MinionSacrificable[projectile.type] = true;
            ProjectileID.Sets.Homing[projectile.type] = true;
            inertia = 30f;
            ProjectileID.Sets.LightPet[projectile.type] = true;
            Main.projPet[projectile.type] = true;
            projectile.magic = true;
            projectile.aiStyle = 66;
            aiType = 533;
            projectile.damage = 30;
        }

        public override bool MinionContactDamage()
        {
            return true;
        }

        public override void CheckActive()
        {
            Player player = Main.player[projectile.owner];
            MyPlayer modPlayer = (MyPlayer)player.GetModPlayer(mod, "MyPlayer");
            if (player.dead)
            {
                modPlayer.AnglerBabyMinion = false;
            }
            if (modPlayer.AnglerBabyMinion)
            {
                projectile.timeLeft = 2;
            }
        }

        public override void CreateDust()
        {
            Lighting.AddLight((int)(projectile.Center.X / 16f), (int)(projectile.Center.Y / 16f), 0.6f, 0.9f, 0.3f);
        }

        public override void SelectFrame()
        {
            projectile.frameCounter++;
            if (projectile.frameCounter >= 8)
            {
                projectile.frameCounter = 0;
                projectile.frame = (projectile.frame + 1) % 3;
            }
        }
    }
}