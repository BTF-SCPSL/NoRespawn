using Exiled.API.Interfaces;
using System.ComponentModel;

namespace NoRespawn
{
    public class Config : IConfig
    {
        [Description("Plugin enabled (bool)?")]
        public bool IsEnabled { get; set; } = true;
        [Description("Debug mode.")]
        public bool Debug { get; set; } = false;
    }
}