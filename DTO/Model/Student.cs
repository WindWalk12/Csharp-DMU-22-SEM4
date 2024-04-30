using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Enum;

namespace DTO.Model
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public StudentTypes StudentType { get; set; }
        public int TeamID { get; set; }

        public Student() { }

        public Student(int studentID, string name, DateTime startDate, StudentTypes studentType, int teamID)
        {
            StudentID = studentID;
            Name = name;
            StartDate = startDate;
            StudentType = studentType;
            TeamID = teamID;
        }

        public Student(string name, DateTime startDate, StudentTypes studentType, int teamID)
        {
            Name = name;
            StartDate = startDate;
            StudentType = studentType;
            TeamID = teamID;
        }
    }
}
