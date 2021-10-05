namespace CloneDroneClient
{
    [HarmonyPatch(typeof(UpgradeManager), "GetAvailableSkillPoints")]
    internal class UpgradePoints
    {
        private static void PreFix(UpgradeManager __instance)
        {
            return 1000;
        }
    }
}