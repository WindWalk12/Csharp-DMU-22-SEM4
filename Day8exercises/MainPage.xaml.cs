using System.Collections.ObjectModel;

namespace Day8exercises
{
    public partial class MainPage : ContentPage
    {   
        private CarContext context = new CarContext();
        ObservableCollection<Car> cars = new ObservableCollection<Car>();
        ObservableCollection<Owner> owners = new ObservableCollection<Owner>();
        public MainPage()
        {
            InitializeComponent();
            bool created = context.Database.EnsureCreated();
            cars = new ObservableCollection<Car>(context.Cars);
            carsView.ItemsSource = cars;
            owners = new ObservableCollection<Owner>(context.Owners);
            OwnerView.ItemsSource = owners;
        }

        private void ButtonAddCar_Clicked(object sender, EventArgs e)
        {
            Car car = new Car("Ferrari", 1000, 25, -1);
            car.Owner = (Owner)OwnerView.SelectedItem;
            context.Cars.Add(car);
            context.SaveChanges();
            cars = new ObservableCollection<Car>(context.Cars);
            carsView.ItemsSource = cars;
        }

        private void ButtonOwner_Clicked(object sender, EventArgs e)
        {
            Owner owner = new Owner("Oliver");
            context.Owners.Add(owner);
            context.SaveChanges();
            owners = new ObservableCollection<Owner>(context.Owners);
            OwnerView.ItemsSource = owners;
        }
    }

}
