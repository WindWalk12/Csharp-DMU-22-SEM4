using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7exercise1
{
    internal class car
    {
        private string model;
        private int horsePower;
        private bool electricPower;

        public car(string model, int horsePower, bool electricPower)
        {
            this.model = model;
            this.horsePower = horsePower;
            this.electricPower = electricPower;
        }

        public string Model { get => model; set => model = value; }
        public int HorsePower { get => horsePower; set => horsePower = value; }
        public bool ElectricPower { get => electricPower; set => electricPower = value; }
    }
}
