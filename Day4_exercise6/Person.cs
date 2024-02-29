using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_exercise6
{
    internal class Person
    {
        private string name;
        private int age;
        private int weight;

        public Person(string name, int age, int weight)
        {
            this.name = name;
            this.age = age;
            this.weight = weight;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public int Weight { get => weight; set => weight = value; }

        public override string ToString()
        {
            return $"Name: {name} Age: {age} Weight: {weight}";
        }

        public class ByAgeSorter : IComparer<Person>
        {
            public int Compare(Person x, Person y)
            {
                return x.Age.CompareTo(y.Age);
            }
        }

        public class ByWeightSorter : IComparer<Person>
        {
            public int Compare(Person x, Person y)
            {
                return x.Weight.CompareTo(y.Weight);
            }
        }

        public class ByNameSorter : IComparer<Person>
        {
            public int Compare(Person x, Person y)
            {
                return string.Compare(x.Name, y.Name);
            }
        }
    }
}
