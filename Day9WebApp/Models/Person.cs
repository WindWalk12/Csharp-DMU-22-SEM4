namespace Day9WebApp.Models
{
    public class Person
    {
        public string Name;
        public int Age;
        public DateTime Birthday;

        public Person(string name, int age, DateTime birthday)
        {
            Name = name;
            Age = age;
            Birthday = birthday;
        }
    }
}
