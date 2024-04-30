using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Model;

namespace DataLayer.Mappers
{
    internal class TeamMapper
    {
        public static DTO.Model.Team Map(Team team)
        {
            return new DTO.Model.Team(team.TeamID, team.Name, team.Description);
        }
        public static Team Map(DTO.Model.Team team)
        {
            return new Team(team.TeamID, team.Name, team.Description);
        }

        public static List<DTO.Model.Team> Map(List<Team> teams)
        {
            List<DTO.Model.Team> retur = new List<DTO.Model.Team>();
            foreach (Team team in teams)
            {
                retur.Add(TeamMapper.Map(team));
            }
            return retur;
        }
    }
}
