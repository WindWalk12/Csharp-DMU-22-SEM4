namespace Day6exercise6
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnNord_Clicked(object sender, EventArgs e)
        {
            lbl.Text += "Nord\n";
        }

        private void btnSyd_Clicked(object sender, EventArgs e)
        {
            lbl.Text += "Syd\n";
        }

        private void btnVest_Clicked(object sender, EventArgs e)
        {
            lbl.Text += "Vest\n";
        }

        private void btnØst_Clicked(object sender, EventArgs e)
        {
            lbl.Text += "Øst\n";
        }
    }

}
