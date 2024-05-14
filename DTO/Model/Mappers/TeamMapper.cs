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

        //public static DTO.Model.TeamDetail MapDetail(Team team)
        //{
        //    return new DTO.Model.TeamDetail(team.TeamID, team.Name, team.Description, StudentMapper.Map(team.Students));
        //}

        public static DTO.Model.TeamDetail MapDetail(Team team)
        {
            DTO.Model.TeamDetail teamDetail = new DTO.Model.TeamDetail();
            teamDetail.TeamID = team.TeamID;
            teamDetail.Name = team.Name;
            teamDetail.Description = team.Description;
            teamDetail.Students = StudentMapper.Map(team.Students);
            return teamDetail;
        }
    }
}
