using System.Reflection;
using BepInEx;
using BepInEx.Unity.IL2CPP;
using BepInEx.Logging;
using HarmonyLib;




namespace EquipmentKeeper
{
    [BepInPlugin(GUID, NAME, VERSION)]
    public class Plugin : BasePlugin
    {

        public const string GUID = "org.voidsnow.plugin.EquipmentKeeper";
        public const string NAME = "Equipment Keeper";
        public const string VERSION = "1.0.2";

        internal static new ManualLogSource Log;
        internal static Harmony harmony;
        public override void Load()
        {

            Log = base.Log;

            harmony = new Harmony(GUID);
            harmony.PatchAll();


            Log.LogInfo($"Plugin {NAME} is loaded!");
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
