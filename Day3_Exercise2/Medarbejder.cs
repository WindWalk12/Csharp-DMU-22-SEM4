using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_exercise2
{
    internal abstract class Medarbejder
    {
        private string navn, adresse, medarbejderNr;
        private const int _hoursPrWeek = 37;
        private CprNr cpr;

        public Medarbejder(CprNr cpr, string navn, string adresse, string medarbejderNr)
        {
            this.cpr = cpr;
            this.navn = navn;
            this.adresse = adresse;
            this.medarbejderNr = medarbejderNr;
        }

        public string Navn { get => navn; set => navn = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public int HoursPrWeek { get => _hoursPrWeek;}
        public CprNr Cpr { get => cpr; }
        abstract public double CalcWeekSalary();

        public override string ToString()
        {
            return this.navn + " " + this.cpr + " " + this.adresse + " " + this.medarbejderNr;
        }
    }
}
