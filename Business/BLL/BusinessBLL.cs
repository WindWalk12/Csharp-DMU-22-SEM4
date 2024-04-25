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
        public Student getStudent(int id)
        {
            //if (id < 0) throw new IndexOutOfRangeException();
            return StudentRepository.getStudent(id);
        }
        public void AddEmployee(Student student)
        {
            //valider employee
            StudentRepository.AddEmployee(student);
        }
        public void EditEmployee(Student student)
        {
            StudentRepository.EditEmployee(student);
        }

        public List<Student> getStudents()
        {
            return StudentRepository.GetStudents();
        }
    }
}
