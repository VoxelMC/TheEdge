using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheEdge.Projectiles.Minions
{
    public abstract class AnglerBabyINFO : Minion
    {
        protected float idleAccel = 0.05f;
        protected float spacingMult = 1f;
        protected float viewDist = 300f;       //minion view Distance
        protected float chaseDist = 200f;       //how far the minion can go
        protected float chaseAccel = 6f;
        protected float inertia = 40f;

        public virtual void CreateDust()
        {

        }

        public virtual void SelectFrame()
        {

        }

        public override void Behavior()
        {
            
        }

        public override void TileCollideStyle(ref int width, ref int height, ref bool fallThrough)
        {
            fallThrough = true;
        }
    }
}