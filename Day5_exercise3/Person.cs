using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using System.Xml.Linq;

namespace Day5_exercise3
{
    internal class Person
    {
        private string name;
        private int age;
        private int weight;
        private int score;
        private bool accepted;

        public Person(string data)
        {
            // Name, Age, Weight, Score
            var L = data.Split(';');
            this.name = L[0];
            this.age = int.Parse(L[1]);
            this.weight = int.Parse(L[2]);
            this.score = int.Parse(L[3]);
            this.accepted = false;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public int Weight { get => weight; set => weight = value; }
        public int Score { get => score; set => score = value; }
        public bool Accepted { get => accepted; set => accepted = value; }

        public static List<Person> ReadCSVFile(string filename)
        {
            List<Person> list = new List<Person>();
            using (var file = new StreamReader(filename))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    var p = new Person(line);
                    list.Add(p);
                    //Console.WriteLine(p);
                }
            }
            return list;
        }

        public override string ToString()
        {
            return "Name: " + this.name + " Age: " + this.age + " Weight: " + this.weight + " Score: " + this.score;
        }
    } 
}
