using System.Collections.ObjectModel;

namespace Day7exercise4
{
    public partial class MainPage : ContentPage
    {
        //List<notifyCar> cars = new List<notifyCar>();
        ObservableCollection<notifyCar> cars = new ObservableCollection<notifyCar>();
        notifyCar car = new notifyCar("Mercedes", 1000, true);
        notifyCar car2 = new notifyCar("Lambo", 1500, false);
        notifyCar car3 = new notifyCar("Audi", 300, false);
        public MainPage()
        {
            InitializeComponent();
            cars.Add(car);
            cars.Add(car2);
            cars.Add(car3);
            carsView.ItemsSource = cars;
            
        }
        private void btnShow_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Car", car.Model + " " + car.HorsePower + " " + car.ElectricPower, "Ok");
        }

        private void btnAddCar_Clicked(object sender, EventArgs e)
        {
            cars.Add(new notifyCar("BMW", 90, true));
        }
    }
}
