using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Enums;
using Exiled.API.Features.Items;
using Exiled.Events.EventArgs.Scp1344;

namespace SCP1344Nerf
{
    public class EventHandlers
    {
        private static Config Config => Plugin.Instance.Config;
        private readonly Plugin Plugin;

        public void OnWearingGlasses(ChangedStatusEventArgs ev)
        {
            if (ev.Scp1344Status == InventorySystem.Items.Usables.Scp1344.Scp1344Status.Active)
            {
                ev.Player.EnableEffect(EffectType.FogControl, (byte)Config.FogControlValue);
            }
        }
    }
}
