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
    public class StudentRepository
    {
        public static Student GetStudent(int id)
        {
            using (StudentContext context = new StudentContext())
            {
                //Maybe throw exception if not found
                return StudentMapper.Map(context.Students.Find(id));
            }
        }
        public static void AddEmployee(Student student)
        {
            using (StudentContext context = new StudentContext())
            {
                context.Students.Add(StudentMapper.Map(student));
                context.SaveChanges();
            }
        }

        public static void EditEmployee(Student student)
        {
            using (StudentContext context = new StudentContext())
            {
                //Virker ikke:
                //Model.Employee dataemp = EmployeeMapper.Map(employee);
                //Virker:
                Model.Student dataemp = context.Students.Find(student.StudentID);
                StudentMapper.Update(student, dataemp);
                //Virker måske:
                //Model.Employee dataemp = EmployeeMapper.Map(employee);
                //context.Entry(dataemp).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public static List<Student> GetStudents()
        {
            using (StudentContext context = new StudentContext())
            {
                return StudentMapper.Map(context.Students.ToList());
            }
        }

        public static void DeleteEmployee(int id)
        {
            using (StudentContext context = new StudentContext())
            {
                DataLayer.Model.Student s = context.Students.Find(id);
                context.Students.Remove(s);
                context.SaveChanges();
            }
        }
    }
}
