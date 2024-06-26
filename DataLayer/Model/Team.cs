﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    internal class Team
    {
        public int TeamID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Student> Students { get; set; }

        public Team()
        {

        }

        public Team(int teamId, string name, string description, List<Student> students)
        {
            TeamID = teamId;
            Name = name;
            Description = description;
            Students = students;
        }

        public Team(int teamId, string name, string description)
        {
            TeamID = teamId;
            Name = name;
            Description = description;
        }

        public Team(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
