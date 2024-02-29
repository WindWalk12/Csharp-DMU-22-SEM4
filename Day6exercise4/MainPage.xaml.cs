namespace Day6exercise4
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

        private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (chk1.IsChecked)
            {
                btn1.IsVisible = true;
            }
            else
            {
                btn1.IsVisible = false;
            }
        }
    }

}
