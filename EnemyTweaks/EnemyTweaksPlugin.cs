using BepInEx;
using R2API.Utils;

namespace EnemyTweaks
{
    [BepInDependency("com.bepis.r2api", BepInDependency.DependencyFlags.HardDependency)]
    [NetworkCompatibility(CompatibilityLevel.EveryoneMustHaveMod, VersionStrictness.EveryoneNeedSameModVersion)]
    [BepInPlugin(MODUID, "EnemyTweaks", "0.0.1")]

    public class EnemyTweaksPlugin : BaseUnityPlugin
    {
        public const string MODUID = "com.rob.EnemyTweaks";

        private void Awake()
        {
            ItemDisplays.PopulateDisplays();

            Monsters.Jellyfish.Init();
            Monsters.ClayTemplar.Init();
            Monsters.Grovetender.Init();
        }
    }
}
