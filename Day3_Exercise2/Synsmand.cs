using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_exercise2
{
    internal class Synsmand: Mekaniker
    {
        private int synPrWeek;

        public Synsmand(CprNr cpr, string navn, string adresse,string medarbejderNr , int yearDone, int hourSalary, int synPrWeek): base(cpr ,navn, adresse,medarbejderNr , yearDone, hourSalary)
        {
            this.synPrWeek = synPrWeek;
        }

        public override double CalcWeekSalary()
        {
            return synPrWeek * 290;
        }
    }
}
