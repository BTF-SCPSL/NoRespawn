using Exiled.API.Features;
using System;

namespace NoRespawn;
public class Plugin : Plugin<Config>
{
    public override string Name => "NoRespawn";
    public override string Author => "Narin & reword by RomzyyTV";
    public override Version Version => new Version(1, 1, 0);
    public override Version RequiredExiledVersion => new Version(9, 0, 0);

    private static EventHandlers handlers;

    public override void OnEnabled()
    {
        handlers = new EventHandlers();
        Exiled.Events.Handlers.Server.RespawningTeam += handlers.OnRespawningTeam;
        Exiled.Events.Handlers.Map.SpawningTeamVehicle += handlers.SpawningTeamVehicle;
        Exiled.Events.Handlers.Map.AnnouncingNtfEntrance += handlers.AnnouncingNtfEntrance;
        Exiled.Events.Handlers.Map.AnnouncingChaosEntrance += handlers.AnnouncingChaosEntrance;
        base.OnEnabled();
    }

    public override void OnDisabled()
    {
        Exiled.Events.Handlers.Server.RespawningTeam -= handlers.OnRespawningTeam;
        Exiled.Events.Handlers.Map.SpawningTeamVehicle -= handlers.SpawningTeamVehicle;
        Exiled.Events.Handlers.Map.AnnouncingNtfEntrance -= handlers.AnnouncingNtfEntrance;
        Exiled.Events.Handlers.Map.AnnouncingChaosEntrance -= handlers.AnnouncingChaosEntrance;
        handlers = null;
        base.OnDisabled();
    }
}
