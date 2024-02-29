using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_exercise2
{
    internal class PowerPlant
    {
        private Warning wa;

        public delegate void Warning();
        public event Warning EventWarnings;

        public void SetWarning(Warning wa)
        {
            this.wa = wa;
        }

        public void HeatUp()
        {
            Random rnd = new Random();
            int heat = rnd.Next(0, 101);

            if (heat > 50)
            {
                //wa.Invoke();
                EventWarnings.Invoke();
            }
        }
    }
}
