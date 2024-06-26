﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Model
{
    public class Team
    {
        public int TeamID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Team()
        {

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
