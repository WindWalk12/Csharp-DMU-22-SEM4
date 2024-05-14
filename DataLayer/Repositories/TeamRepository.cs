using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Model;
using DataLayer.Context;
using DataLayer.Mappers;
using System.ComponentModel.Design;
using Microsoft.EntityFrameworkCore;

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

        public static TeamDetail GetTeamDetail(int id)
        {
            using (StudentContext context = new StudentContext())
            {
                IQueryable<Model.Team> team = context.Teams.Where(t => t.TeamID == id).Include(t => t.Students);
                if (team.Count() == 1)
                {
                    return TeamMapper.MapDetail(team.First());
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
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

        public static void AddStudentToTeam(int teamID, int studentID)
        {
            using (StudentContext context = new StudentContext())
            {
                Model.Student s = context.Students.Where(s => s.StudentID == studentID).FirstOrDefault();
                s.StudentID = teamID;
                context.SaveChanges();
            }
        }
    }
}
