using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using TheEdge;

namespace TheEdge
{
    public class MyPlayer : ModPlayer
    {
        private const int saveVersion = 0;

        public static bool hasProjectile;

        public override void ResetEffects()
        {
            AnglerBabyMinion = false;
            WigWigMinion = false;
            BarkDemonMinion = false;
        }

        public bool AnglerBabyMinion = false;
        public bool WigWigMinion = false;
        public bool BarkDemonMinion = false;
    }
}

