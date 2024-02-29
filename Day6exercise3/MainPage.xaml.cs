namespace Day6exercise3
{
    public partial class MainPage : ContentPage
    {
        private int noClicked = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        private void btn1_Clicked(object sender, EventArgs e)
        {
            noClicked++;
            btn1.Text = "Help " + noClicked.ToString();
        }
    }

}
