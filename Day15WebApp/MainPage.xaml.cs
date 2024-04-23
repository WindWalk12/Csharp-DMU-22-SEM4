using System.Net.Http.Json;

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
            client.DefaultRequestHeaders.Add("Accept", "*/*");
            Tronalddump td = await client.GetFromJsonAsync<Tronalddump>("https://www.tronalddump.io/random/quote");
            TronaldDumpLbl.Text = td.Value.ToString();
        }
    }
}
