using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using InventorySystem.Items.Usables.Scp1344;
using HarmonyLib;
using Mirror;
using CustomPlayerEffects;
using Exiled.API.Features.Items;
using InventorySystem.Items;
using Exiled.API.Features;

namespace SCP1344Nerf
{
    [HarmonyPatch(typeof(Scp1344Item), nameof(Scp1344Item.ServerUpdateActive))]
    public static class Patch_ServerUpdateActive
    {
        private static Config Config => Plugin.Instance.Config;
        static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
        {
            foreach (var instruction in instructions)
            {
                if (instruction.opcode == OpCodes.Ldc_I4_S && (sbyte)instruction.operand == 15)
                {
                    instruction.operand = Config.NewBlindnessCap;
                }
                yield return instruction;
            }
        }
    }

    [HarmonyPatch(typeof(CustomPlayerEffects.Scp1344), nameof(CustomPlayerEffects.Scp1344.Enabled))]
    public static class Patch_Scp1344_Enabled
    {
        static bool Prefix(CustomPlayerEffects.Scp1344 __instance)
        {
            if (!Plugin.Instance.Config.EnableScp1344EffectPatch)
            {
                Log.Debug("SCP-1344 effect patch is disabled.");
                return true; // Lässt das Original weiterlaufen
            }

            if (NetworkServer.active)
            {
                Player player = Player.Get(__instance.Hub);
                Log.Debug($"ReferenceHub found: {__instance.Hub} - belongs to {player.CustomName}");

                
                foreach (Item item in player.Items)
                {
                    if (item is Exiled.API.Features.Items.Scp1344 scp)
                    {
                        if (scp.IsWorn)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            return false; //Default behaviour if no SCP1344Item was found in player inventory.
        }
    }
}
