using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8exercises
{
    internal class Car
    {
        public int CarId { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
        public int Age { get; set; }
        public int OwnerId { get; set; }
        public Owner Owner { get; set; }

        public Car() { }

        public Car(string model, int horsePower, int age, int ownerId)
        {
            this.Model = model;
            this.HorsePower = horsePower;
            this.Age = age;
            this.OwnerId = ownerId;
        }
    }
}
