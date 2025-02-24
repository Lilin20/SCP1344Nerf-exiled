using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Interfaces;

namespace SCP1344Nerf
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;

        [Description("Sets if the player gets the FogControl effect with the given value.")]
        public bool UseFogControl { get; set; } = true;
        public int FogControlValue { get; set; } = 5;

        [Description("Enables and sets the min. cap of blindness intensity which is reached after a couple of seconds.")]
        public bool UsePatches { get; set; } = true;
        public int NewBlindnessCap {  set; get; } = 15;

        [Description("Enables the glasses when only the effect was given via RA or code (EffectType.Scp1344)")]
        public bool EnableScp1344EffectPatch { get; set; } = true;
    }
}
