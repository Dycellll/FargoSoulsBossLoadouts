using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;

namespace FargoSoulsBossLoadouts
{
	public class FargoSoulsBossLoadouts : Mod
	{
        public override void Load()
        {
            ModLoader.TryGetMod("BossLoadouts", out var mainMod);
            if (mainMod == null) return;

            BossLoadouts.BossLoadouts.BossProviders.Add(new Content.FargoBossProvider());
            BossLoadouts.BossLoadouts.BuffProviders.Add(new Content.FargoBuffProvider());
        }
    }
}
