namespace Day6exercise7
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void MenuFlyoutItem_Clicked(object sender, EventArgs e)
        {
            var menu = (MenuFlyoutItem)sender;
            lbl.Text = menu.Text;
        }
    }

}
