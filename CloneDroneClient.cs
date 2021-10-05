using BepInEx;
using UnityEngine;
using HarmonyLib;

namespace CloneDroneClient
{
    [BepInPlugin(com.ju1-js.clone-drone-client, "Clone Drone Client", "1.0.0")]
    
    [BepInProcess("Clone Drone in the Danger Zone.exe")]
    public class CloneDroneClient : BaseUnityPlugin
    {
        // Declare Harmony
        public Harmony Harmony {get;} = new Harmony(PluginInfo.PLUGIN_GUID);
        private void Awake()
        {
            // Plugin startup logic
            Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");
            
            try
            {
                this.Harmony.PatchAll(); // Patch runtime, change to patch later
                Debug.Log("[CDC] Loaded!")
            }
            catch (string error = System.Exception)
            {
                debug.Log("[CDC] Error Loading: " + error.toString());
            }
            
            public const string Id = PluginInfo.PLUGIN_GUID;

            public const string Version = PluginInfo.PLUGIN_VERSION;
        }
    }
}
