using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Model;

namespace DataLayer.Mappers
{
    internal class StudentMapper
    {
        public static DTO.Model.Student  Map(Student student)
        {
            return new DTO.Model.Student(student.StudentID, student.Name, student.StartDate, student.StudentType, student.TeamID);
        }
        public static Student Map(DTO.Model.Student student)
        {
            return new Student(student.StudentID, student.Name, student.StartDate, student.StudentType, student.TeamID);
        }

        public static void Update(DTO.Model.Student student, Student dataemp)
        {
            dataemp.Name = student.Name;
        }

        public static List<DTO.Model.Student> Map(List<Student> students)
        {
            List<DTO.Model.Student> retur = new List<DTO.Model.Student>();
            foreach (Student student in students)
            {
                retur.Add(StudentMapper.Map(student));
            }
            return retur;
        }
    }
}
