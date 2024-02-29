namespace ConsoleApp1
{
    internal class Person(string firstName, string lastName)
    {
        private string firstName = firstName;
        private string lastName = lastName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; } 
            set {  lastName = value; }
        }

        public override string ToString() 
        {
            return firstName + " " + lastName;
        }
    }
}
