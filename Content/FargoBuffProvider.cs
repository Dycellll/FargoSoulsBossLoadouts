using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BossLoadouts.Content.UI.PermanentBuffsEditorUI;
using Terraria;
using FargowiltasSouls.Content.Items.Consumables;
using Terraria.ModLoader;
using FargowiltasSouls;

namespace FargoSoulsBossLoadouts.Content
{
    public class FargoBuffProvider : IPermanentBuffProvider
    {
        public IEnumerable<PermanentBuffEntry> GetBuffEntries()
        {
            Player player = Main.LocalPlayer;
            var modPlayer = player?.FargoSouls();

            if (modPlayer == null)
            {
                return new List<PermanentBuffEntry>()
                {
                    new PermanentBuffEntry()
                    {
                        Name = "Rabies Vaccine",
                        SortIndex = 2,
                        IsUnlocked = () => false,
                        SetUnlocked = val => { }
                    },
                    new PermanentBuffEntry()
                    {
                        Name = "Deer Sinew",
                        SortIndex = 10,
                        IsUnlocked = () => false,
                        SetUnlocked = val => { }
                    },
                    new PermanentBuffEntry()
                    {
                        Name = "Mutant's Pact",
                        SortIndex = 85,
                        IsUnlocked = () => false,
                        SetUnlocked = val => { }
                    },
                };
            }

            return new List<PermanentBuffEntry>()
            {
                new PermanentBuffEntry()
                {
                    Name = "Rabies Vaccine",
                    SortIndex = 2,
                    IsUnlocked = () => modPlayer.RabiesVaccine,
                    SetUnlocked = val =>
                    {
                        modPlayer.RabiesVaccine = val;
                    }
                },
                new PermanentBuffEntry()
                {
                    Name = "Deer Sinew",
                    SortIndex = 10,
                    IsUnlocked = () => modPlayer.DeerSinew,
                    SetUnlocked = val =>
                    {
                        modPlayer.DeerSinew = val;
                    }
                },
                new PermanentBuffEntry()
                {
                    Name = "Mutant's Pact",
                    SortIndex = 85,
                    IsUnlocked = () => modPlayer.MutantsPactSlot,
                    SetUnlocked = val =>
                    {
                        modPlayer.MutantsPactSlot = val;
                    }
                },
            };
        }
    }
}