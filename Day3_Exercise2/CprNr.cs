using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_exercise2
{
    internal class CprNr
    {
        private string birthDate, sequenceNumber;
        public CprNr(string bDate, string sNumber)
        {
            this.birthDate = bDate;
            this.sequenceNumber = sNumber;
        }

        public override string ToString()
        {
            return this.birthDate + "-" + this.sequenceNumber;
        }
    }
}
