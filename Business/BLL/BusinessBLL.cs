using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Model;
using DataLayer.Repositories;

namespace Business.BLL
{
    public class BusinessBLL
    {
        public Student GetStudent(int id)
        {
            //if (id < 0) throw new IndexOutOfRangeException();
            return StudentRepository.GetStudent(id);
        }
        public void AddEmployee(Student student)
        {
            //valider employee
            StudentRepository.AddStudent(student);
        }
        public void EditEmployee(Student student)
        {
            StudentRepository.EditStudent(student);
        }

        public List<Student> GetStudents()
        {
            return StudentRepository.GetStudents();
        }

        public void DeleteEmployee(int id)
        {
            StudentRepository.DeleteStudent(id);
        }

        public Team GetTeam(int id)
        {
            return TeamRepository.GetTeam(id);
        }

        public void AddTeam(Team team)
        {
            TeamRepository.AddTeam(team);
        }

        public List<Team> GetTeams()
        {
            return TeamRepository.GetTeams();
        }

        public TeamDetail GetTeamDetail(int id)
        {
            return TeamRepository.GetTeamDetail(id);
        }

        public void AddStudentToTeam(int StudentID, int TeamID)
        {
            StudentRepository.AddStudentToTeam(StudentID, TeamID);
        }
    }
}
