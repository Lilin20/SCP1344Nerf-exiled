using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using InventorySystem.Items.Usables.Scp1344;
using HarmonyLib;

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
}
