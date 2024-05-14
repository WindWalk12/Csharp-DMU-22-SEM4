using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Business.BLL;
using DTO.Model;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Students : ControllerBase
    {
        [HttpGet]
        [Route("ShowStudents")]
        public List<Student> ShowStudents()
        {
            BusinessBLL businessBLL = new BusinessBLL();
            return businessBLL.GetStudents();
        }

        [HttpGet]
        [Route("GetStudentById/{id}")]
        public Student GetStudentById(int id)
        {
            BusinessBLL businessBLL = new BusinessBLL();
            return businessBLL.GetStudent(id);
        }
    }
}
