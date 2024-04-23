using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Text.Json.Serialization;

namespace Day15WebApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void GetPersons_Clicked(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            List<Person> persons =  await client.GetFromJsonAsync<List<Person>>("http://localhost:5229/api/person/getpersons");
            PersonsView.ItemsSource = persons;
        }

        private async void GetPersonById_Clicked(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            Person p = await client.GetFromJsonAsync<Person>("http://localhost:5229/api/person/getpersonbyid/2");
            List<Person> persons = new List<Person>();
            persons.Add(p);
            PersonsView.ItemsSource = persons;
        }

        private async void AddPerson_Clicked(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            Person p = new Person(10, "Test", 99);
            await client.PostAsJsonAsync<Person>("http://localhost:5229/api/person/addperson", p);
        }

        private async void GetTrumpQuote_Clicked(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            Tronalddump td = await client.GetFromJsonAsync<Tronalddump>("http://www.tronalddump.io/random/quote");
            string s = td.value;
            List<string> strings = new List<string>();
            strings.Add(s);
            PersonsView.ItemsSource = strings;
        }
    }

}
