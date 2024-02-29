using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_exercise6
{
    internal static class MyExtensions
    {
        public static void SetAccepted(this List<Person> lst, Predicate<Person> pred)
        {
            lst.FindAll(p => pred(p)).ForEach(p => p.Accepted = true);
        }
    }
}