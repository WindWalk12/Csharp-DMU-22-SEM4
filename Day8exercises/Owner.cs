using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8exercises
{
    internal class Owner
    {
        public int OwnerId { get; set; }
        public string Name { get; set; }
        public List<Car> Cars { get; set; }

        public Owner() { }

        public Owner(string Name)
        {
            this.Name = Name;
        }
    }
}
