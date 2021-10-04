using BepInEx;

namespace MyFirstPlugin
{
    [BepInPlugin(github.com/Ju1-js/Infinite-Upgrade-Points, Infinate Upgrade Points, PluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        private void Awake()
        {
            // Plugin startup logic
            Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");

        }
    }
}
