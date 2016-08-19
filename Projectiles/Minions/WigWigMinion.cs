using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheEdge.Projectiles.Minions
{
    public class WigWigMinion : WigWigINFO
    {
        public override void SetDefaults()
        {
            projectile.netImportant = true;
            projectile.name = "WigWig";
            projectile.width = 30;
            projectile.height = 20;
            Main.projFrames[projectile.type] = 6;
            projectile.friendly = true;
            Main.projPet[projectile.type] = true;
            projectile.minion = true;
            projectile.netImportant = true;
            projectile.minionSlots = 1;
            projectile.penetrate = -1;
            projectile.timeLeft = 18000;
            projectile.tileCollide = true;
            projectile.ignoreWater = false;
            ProjectileID.Sets.MinionSacrificable[projectile.type] = true;
            ProjectileID.Sets.Homing[projectile.type] = true;
            inertia = 30f;
            ProjectileID.Sets.LightPet[projectile.type] = true;
            Main.projPet[projectile.type] = true;
            projectile.magic = true;
            projectile.aiStyle = 26;
            aiType = 266;
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
                modPlayer.WigWigMinion = false;
            }
            if (modPlayer.WigWigMinion)
            {
                projectile.timeLeft = 2;
            }
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