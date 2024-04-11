namespace Day12WebApp.Models
{
    public class Person
    {
        public string fornavn { get; set; }
        public string efternavn { get; set; }
        public int alder { get; set; }

        public Person(string fornavn, string efternavn, int alder)
        {
            this.fornavn = fornavn;
            this.efternavn = efternavn;
            this.alder = alder;
        }

        public Person() { }
    }
}
