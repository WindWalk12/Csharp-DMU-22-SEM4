using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_exercise2
{
    internal class Værkfører: Mekaniker
    {
        private int yearRaise, supplement;

        public Værkfører(CprNr cpr, string navn, string adresse,string medarbejderNr , int yearDone, int hourSalary, int yearRaise, int supplement): base(cpr ,navn, adresse,medarbejderNr , yearDone, hourSalary)
        {
            this.yearRaise = yearRaise;
            this.supplement = supplement;
        }

        public int YearRaise { get => yearRaise; set => yearRaise = value; }
        public int Supplement { get => supplement; set => supplement = value; }

        public override double CalcWeekSalary()
        {
            return base.HoursPrWeek * HourSalary + supplement;
        }
    }
}
