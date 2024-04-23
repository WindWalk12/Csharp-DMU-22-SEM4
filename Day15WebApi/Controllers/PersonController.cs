using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day15WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private static List<Person> persons = new List<Person>();

        [HttpGet]
        [Route("GetPersons")]
        public List<Person> GetPersons()
        {
            return persons;
        }

        [HttpGet]
        [Route("GetPersonById/{id}")]
        public Person GetPersonById(int id)
        {
            return persons.Find(p => p.Id == id);
        }

        [HttpPost]
        [Route("AddPerson")]
        public Person AddPerson(Person p)
        {
            persons.Add(p);
            return p;
        }

        public static void CreateList()
        {
            persons.Add(new Person(1, "Hans", 40));
            persons.Add(new Person(2, "Marie", 28));
            persons.Add(new Person(3, "Mans", 50));
        }
    }
}
