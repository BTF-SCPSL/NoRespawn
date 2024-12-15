using PlayerRoles;
using Exiled.API.Features;
using Exiled.Events.EventArgs.Map;
using Exiled.Events.EventArgs.Server;
namespace NoRespawn;
public class EventHandlers
{
    public void OnRespawningTeam(RespawningTeamEventArgs ev)
    {
        ev.IsAllowed = false;
        
        var teamFaction = ev.NextKnownTeam;

        if (teamFaction == Faction.FoundationStaff)
        {
            Log.Info("Nine-Tailed Fox attempted to respawn but was prevented.");
        }
        else if (teamFaction == Faction.FoundationEnemy)
        {
            Log.Info("Chaos Insurgency attempted to respawn but was prevented.");
        }
        else
        {
            Log.Info($"An unknown team attempted to respawn: {ev.NextKnownTeam}.");
        }

        Cassie.Clear();
    }

    public void SpawningTeamVehicle(SpawningTeamVehicleEventArgs ev)
    {
        ev.IsAllowed = false;
    }

    public void AnnouncingNtfEntrance(AnnouncingNtfEntranceEventArgs ev)
    {
        ev.IsAllowed = false;
    }
    
    public void AnnouncingChaosEntrance(AnnouncingChaosEntranceEventArgs ev)
    {
        ev.IsAllowed = false;
    }
}