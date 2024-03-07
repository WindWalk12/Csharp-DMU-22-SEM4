using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7exercise2
{
    internal class notifyCar : INotifyPropertyChanged
    {
        private string model;
        private int horsePower;
        private bool electricPower;

        public notifyCar(string model, int horsePower, bool electricPower)
        {
            this.model = model;
            this.horsePower = horsePower;
            this.electricPower = electricPower;
        }

        public string Model { get => model;
            set
            {
                model = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(Model)));
            }
        }
        public int HorsePower { get => horsePower;
            set
            {
                horsePower = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(HorsePower)));
            }
        }
        public bool ElectricPower { get => electricPower; set => electricPower = value; }

        public event PropertyChangedEventHandler? PropertyChanged = delegate{};
    }
}
