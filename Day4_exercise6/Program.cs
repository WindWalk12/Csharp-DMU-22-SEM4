
using Day4_exercise6;

Person p1 = new Person("Hanne", 35, 60);
Person p2 = new Person("John", 40, 70);
Person p3 = new Person("Emily", 25, 55);
Person p4 = new Person("Michael", 50, 80);
Person p5 = new Person("Sarah", 30, 65);
Person p6 = new Person("David", 45, 75);
Person p7 = new Person("Anna", 28, 58);
Person p8 = new Person("Robert", 55, 85);
Person p9 = new Person("Jessica", 33, 63);
Person p10 = new Person("Daniel", 48, 78);

List<Person> persons = new List<Person>();

persons.Add(p1);
persons.Add(p2);
persons.Add(p3);
persons.Add(p4);
persons.Add(p5);
persons.Add(p6);
persons.Add(p7);
persons.Add(p8);
persons.Add(p9);
persons.Add(p10);

persons.Sort(new Person.ByAgeSorter());

foreach (Person person in persons)
{
    Console.WriteLine(person.ToString());
}