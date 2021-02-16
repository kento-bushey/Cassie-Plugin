using Exiled.API.Features;
using Exiled.API.Enums;
using System;
using Server = Exiled.Events.Handlers.Server;
using Player = Exiled.Events.Handlers.Player;
namespace CassiePlugin
{
    public class CassiePlugin : Plugin<Config>
    {
        private static readonly Lazy<CassiePlugin> LazyInstance = new Lazy<CassiePlugin> ( ()=> new CassiePlugin());
        public static CassiePlugin Instance => LazyInstance.Value;
        public override PluginPriority Priority { get; } = PluginPriority.Medium;
        private Handlers.Player player;
        private Handlers.Server server;
        private CassiePlugin()
        {

        }
        public override void OnEnabled()
        {
            
        }
        public override void OnDisabled()
        {

        }
    }

}
