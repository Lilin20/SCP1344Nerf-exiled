using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Features;
using HarmonyLib;

namespace SCP1344Nerf
{
    public class Plugin : Plugin<Config>
    {
        public static Plugin Instance;

        public override string Name => "Lilin's SCP-1344 Nerf";
        public override string Author => "Lilin";
        public override Version Version => new Version(1, 0, 0);

        private EventHandlers _eventHandler;
        public Harmony harmony = new Harmony("lilin.scp1344patches");

        public override void OnEnabled()
        {
            Instance = this;
            _eventHandler = new EventHandlers();

            if (Config.UseFogControl)
            {
                Log.Debug("Registering event...");
                Exiled.Events.Handlers.Scp1344.ChangedStatus += _eventHandler.OnWearingGlasses;
            }

            if (Config.UseNewBlindnessCap)
            {
                Log.Debug("Patching the glasses...");
                harmony.PatchAll();
            }

            
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            if (Config.UseFogControl)
            {
                Exiled.Events.Handlers.Scp1344.ChangedStatus -= _eventHandler.OnWearingGlasses;
            }

            if (Config.UseNewBlindnessCap)
            {
                harmony.UnpatchAll();
            }

            _eventHandler = null;
            Instance = null;
            base.OnDisabled();
        }
    }
}
