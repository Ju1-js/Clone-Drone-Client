using BepInEx;
using UnityEngine;
using HarmonyLib;

namespace CloneDroneClient
{
    [BepInPlugin(com.github.Ju1-js.CloneDroneClient, Clone Drone Client, "1.0.0")]
    public class CloneDroneClient : BaseUnityPlugin
    {
        private void Awake()
        {
            // Plugin startup logic
            Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");

        }
    }
}
