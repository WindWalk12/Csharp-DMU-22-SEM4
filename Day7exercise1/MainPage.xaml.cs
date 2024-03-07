namespace Day7exercise1
{
    public partial class MainPage : ContentPage
    {
        car car = new car("Mercedes", 1000, true);
        public MainPage()
        {
            InitializeComponent();
            lblModel.BindingContext = car;
            lblHorsePower.BindingContext = car;
            chkElectric.BindingContext = car;
        }
        private void btnShow_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Car", car.Model + " " + car.HorsePower + " " + car.ElectricPower, "Ok");
        }
    }

}
