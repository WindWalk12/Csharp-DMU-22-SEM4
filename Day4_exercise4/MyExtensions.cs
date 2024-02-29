using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Day4_exercise4
{
    internal static class MyExtensions
    {
        public static int Power(this int p, int n)
        {
            return (int)Math.Pow(p, n);
        }
    }
}
