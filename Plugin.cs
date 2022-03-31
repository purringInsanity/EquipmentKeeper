using BepInEx;
using BepInEx.IL2CPP;
using HarmonyLib;

namespace EquipmentKeeper
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class Plugin : BasePlugin
    {
        public override void Load()
        {
            var harmony = new Harmony(PluginInfo.PLUGIN_GUID);
            harmony.PatchAll();
            Log.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");
        }
    }
}

[HarmonyPatch(typeof(PlayerController))]
    internal class PlayerControllerPatch
    {
        [HarmonyPatch("ReduceDurabilityOfHeldEquipment")]
        [HarmonyPrefix]
        static void ReduceDurabilityOfHeldEquipmentPatch(ref bool __runOriginal)
        {
            __runOriginal = false;
            return;
        }

        [HarmonyPatch("ReduceDurabilityOfAllEquipment")]
        [HarmonyPrefix]
        static void ReduceDurabilityOfAllEquipmentPatch(ref bool __runOriginal)
        {
            __runOriginal = false;
            return;
        }

        [HarmonyPatch("ReduceDurabilityOfEquipment")]
        [HarmonyPrefix]
        static void ReduceDurabilityOfEquipmentPatch(ref bool __runOriginal)
        {
            __runOriginal = false;
            return;
        }

        [HarmonyPatch("ReducePercentageDurabilityOfEquipment")]
        [HarmonyPrefix]
        static void ReducePercentageDurabilityOfEquipmentPatch(ref bool __runOriginal)
        {
            __runOriginal = false;
            return;
        }

        [HarmonyPatch("ReducePercentageDurabilityOfAllEquipment")]
        [HarmonyPrefix]
        static void ReducePercentageDurabilityOfAllEquipmentPatch(ref bool __runOriginal)
        {
            __runOriginal = false;
            return;
        }
    }
