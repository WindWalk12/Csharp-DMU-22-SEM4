namespace Day7exercise2
{
    public partial class MainPage : ContentPage
    {
        notifyCar car = new notifyCar("Mercedes", 1000, true);
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

        private void BtnChange_Clicked(object sender, EventArgs e)
        {
            car.Model = "Honda";
            car.HorsePower = 150;
        }
    }

}
