using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Model
{
    public class TeamDetail
    {
        public int TeamID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Student> Students { get; set; }

        public TeamDetail()
        {

        }

        public TeamDetail(int teamId, string name, string description, List<Student> students)
        {
            TeamID = teamId;
            Name = name;
            Description = description;
            Students = students;
        }

        public TeamDetail(string name, string description, List<Student> students)
        {
            Name = name;
            Description = description;
            Students = students;
        }
    }
}
