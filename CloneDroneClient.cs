using BepInEx;
using UnityEngine;
using HarmonyLib;

namespace CloneDroneClient
{
    [BepInPlugin(github.com/Ju1-js/Infinite-Upgrade-Points, Infinate Upgrade Points, "1.0.0")]
    public class InfiniteUpgradePoints : BaseUnityPlugin
    {
        private void Awake()
        {
            // Plugin startup logic
            Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");

        }
    }
}
