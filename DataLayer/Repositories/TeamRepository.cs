using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Model;
using DataLayer.Context;
using DataLayer.Mappers;

namespace DataLayer.Repositories
{
    public class TeamRepository
    {
        public static Team GetTeam(int id)
        {
            using (StudentContext context = new StudentContext())
            {
                //Maybe throw exception if not found
                return TeamMapper.Map(context.Teams.Find(id));
            }
        }

        public static void AddTeam(Team team)
        {
            using (StudentContext context = new StudentContext())
            {
                context.Teams.Add(TeamMapper.Map(team));
                context.SaveChanges();
            }
        }
        public static List<Team> GetTeams()
        {
            using (StudentContext context = new StudentContext())
            {
                return TeamMapper.Map(context.Teams.ToList());
            }
        }
    }
}
