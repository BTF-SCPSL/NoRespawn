using PlayerRoles;
using System;
using Exiled.API.Features;
using Exiled.Events.EventArgs.Server;

namespace NoRespawn
{
    public class EventHandlers
    {
        public void OnRespawningTeam(RespawningTeamEventArgs ev)
        {
            ev.IsAllowed = false;

            var teamFaction = GetFaction(ev.NextKnownTeam);

            if (teamFaction == Faction.FoundationStaff)
            {
                Log.Debug("Nine-Tailed Fox attempted to respawn but was prevented.");
            }
            else if (teamFaction == Faction.FoundationEnemy)
            {
                Log.Debug("Chaos Insurgency attempted to respawn but was prevented.");
            }
            else
            {
                Log.Debug($"An unknown team attempted to respawn: {ev.NextKnownTeam}.");
            }

            Cassie.Clear();
        }

        public void OnRespawnedTeam(RespawnedTeamEventArgs ev)
        {
            Cassie.Clear();
        }

        private Faction GetFaction(Faction nextKnownTeam)
        {
            throw new NotImplementedException();
        }
    }
}