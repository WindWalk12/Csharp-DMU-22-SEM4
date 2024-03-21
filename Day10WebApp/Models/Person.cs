using System.Linq.Expressions;

namespace Day10WebApp.Models
{
    public class Person
    {
        private string firstname;
        private string lastname;
        private string address;
        private string zip;
        private string city;
        private List<string> phoneNumbers = new List<string>();
        private DateTime birthday;
        private int age;

        public Person(string firstnavn, string lastnavn, string address, string zip, string city, List<string> phoneNumbers)
        {
            this.firstname = firstnavn;
            this.lastname = lastnavn;
            this.address = address;
            this.zip = zip;
            this.city = city;
            this.phoneNumbers = phoneNumbers;
        }

        public string Firstname { get { return firstname; } set { firstname = value; } }
        public string Lastname { get { return lastname; } set { lastname = value; } }
        public string Address { get { return address; } set { address = value; } }
        public string Zip { get { return zip; } set { zip = value; } }
        public string City { get { return city; } set { city = value; } }
        public List<string> PhoneNumbers { get {  return phoneNumbers; } set { phoneNumbers = value; } }
        public DateTime Birthday
        {
            get { return birthday; }
            set
            {
                int age = DateTime.Now.Year - value.Year;
                if (age < 0 || age > 120)
                {
                    throw new Exception("Age not accepted");
                }
                else
                {
                    birthday = value;
                }
            }
        }
        public int Age { get 
            {
                DateTime now = DateTime.Now;
                int age;
                age = now.Year - birthday.Year;
                if (now.Month < birthday.Month || (now.Month == birthday.Month && now.Day < birthday.Day))
                {
                    age--;
                }
                return age;
            }
            set { age = value; } }
    }
}
