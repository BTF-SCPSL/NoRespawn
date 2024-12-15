using Exiled.API.Features;
using System;

namespace NoRespawn
{
    public class Plugin : Plugin<Config>
    {
        public static Plugin Instance { get; private set; }

        public override string Name => "NoRespawn";
        public override string Author => "Narin & reword by RomzyyTV";
        public override Version Version => new Version(1, 3, 0);
        public override Version RequiredExiledVersion => new Version(9, 0, 0);

        public override void OnEnabled()
        {
            Instance = this;

            RespawnControl.NoRespawn = true;

            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Instance = null;

            RespawnControl.NoRespawn = false;

            base.OnDisabled();
        }
    }
}
