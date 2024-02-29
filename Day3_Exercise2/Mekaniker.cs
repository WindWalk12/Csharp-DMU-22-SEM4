using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_exercise2
{
    internal class Mekaniker: Medarbejder
    {
        private int yearDone, hourSalary;
        public Mekaniker(CprNr cpr, string navn, string adresse, string medarbejderNr, int yearDone, int hourSalary) : base(cpr, navn, adresse, medarbejderNr)
        {
            this.yearDone = yearDone;
            this.hourSalary = hourSalary;
        }

        public int YearDone { get => yearDone; set => yearDone = value; }
        public int HourSalary { get => hourSalary; set => hourSalary = value; }

        public override double CalcWeekSalary()
        {
            return base.HoursPrWeek * hourSalary;
        }
    }
}
