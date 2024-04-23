namespace Day15WebApi
{
    public class Person
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Person (int id, string name, int age)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
        }
    }
}
