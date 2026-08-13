using System;
using BepInEx;
using HarmonyLib;

namespace ADOFAI_AutoPlayMod
{
    [BepInPlugin("com.linyouyu.adofai.autoplay", "AutoPlay Mod", "1.0.0")]
    public class AutoPlayPlugin : BaseUnityPlugin
    {
        private void Awake()
        {
            Harmony.CreateAndPatchAll(typeof(AutoPlayPlugin));
            Logger.LogInfo("全自动外挂加载成功，准备起飞！");
        }
        
        [HarmonyPatch(typeof(scrController), "Awake")]
        [HarmonyPostfix] 
        static void Postfix()
        {
            RDC.auto = true;
        }
    }
}