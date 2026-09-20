using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BossLoadouts.Content.UI;
using FargowiltasSouls.Core.Systems;
using static FargowiltasSouls.Core.Systems.WorldSavingSystem;
using static FargowiltasSouls.Core.Systems.WorldSavingSystem.Downed;

namespace FargoSoulsBossLoadouts.Content
{
    public class FargoBossProvider : BossDownedEditorUI.IBossProvider
    {
        private static bool GetDowned(Downed flag)
        {
            int index = (int)flag;
            if (DownedBoss == null || index < 0 || index >= DownedBoss.Length)
                return false;

            return DownedBoss[index];
        }

        private static void SetDowned(Downed flag, bool val)
        {
            int index = (int)flag;
            if (DownedBoss == null || index < 0 || index >= DownedBoss.Length)
                return;

            DownedBoss[index] = val;
        }

        public IEnumerable<BossDownedEditorUI.BossEntry> GetBossEntries()
        {
            return new List<BossDownedEditorUI.BossEntry>
            {
                new() { Name = "Trojan Squirrel", SortIndex = 3, IsDowned = () =>
                            GetDowned(TrojanSquirrel), SetDowned = val =>
                            SetDowned(TrojanSquirrel, val) },
                new() { Name = "Cursed Coffin", SortIndex = 25, IsDowned = () =>
                            GetDowned(CursedCoffin), SetDowned = val =>
                            SetDowned(CursedCoffin, val) },
                new() { Name = "Deviantt", SortIndex = 115, IsDowned = () =>
                            DownedDevi, SetDowned = val =>
                            DownedDevi = val },
                new() { Name = "Banished Baron", SortIndex = 155, IsDowned = () =>
                            GetDowned(BanishedBaron), SetDowned = val =>
                            SetDowned(BanishedBaron, val) },
                new() { Name = "Lifelight", SortIndex = 205, IsDowned = () =>
                            GetDowned(Lifelight), SetDowned = val =>
                            SetDowned(Lifelight, val) },
                new() { Name = "Champion of Timber", SortIndex = 325, IsDowned = () =>
                            GetDowned(TimberChampion), SetDowned = val =>
                            SetDowned(TimberChampion, val) },
                new() { Name = "Champion of Terra", SortIndex = 326, IsDowned = () =>
                            GetDowned(TerraChampion), SetDowned = val =>
                            SetDowned(TerraChampion, val) },
                new() { Name = "Champion of Earth", SortIndex = 327, IsDowned = () =>
                            GetDowned(EarthChampion), SetDowned = val =>
                            SetDowned(EarthChampion, val) },
                new() { Name = "Champion of Nature", SortIndex = 328, IsDowned = () =>
                            GetDowned(NatureChampion), SetDowned = val =>
                            SetDowned(NatureChampion, val) },
                new() { Name = "Champion of Life", SortIndex = 329, IsDowned = () =>
                            GetDowned(LifeChampion), SetDowned = val =>
                            SetDowned(LifeChampion, val) },
                new() { Name = "Champion of Death", SortIndex = 330, IsDowned = () =>
                            GetDowned(ShadowChampion), SetDowned = val =>
                            SetDowned(ShadowChampion, val) },
                new() { Name = "Champion of Spirit", SortIndex = 331, IsDowned = () =>
                            GetDowned(SpiritChampion), SetDowned = val =>
                            SetDowned(SpiritChampion, val) },
                new() { Name = "Champion of Will", SortIndex = 332, IsDowned = () =>
                            GetDowned(WillChampion), SetDowned = val =>
                            SetDowned(WillChampion, val) },
                new() { Name = "Eridanus, Champion of Cosmos", SortIndex = 335, IsDowned = () =>
                            GetDowned(CosmosChampion), SetDowned = val =>
                            SetDowned(CosmosChampion, val) },
                new() { Name = "Abomination", SortIndex = 450, IsDowned = () =>
                            DownedAbom, SetDowned = val =>
                            DownedAbom = val },
                new() { Name = "Mutant", SortIndex = 600, IsDowned = () =>
                            DownedMutant, SetDowned = val =>
                            DownedMutant = val },
            };
        }
    }
}