namespace Day6exercise5
{
    public partial class MainPage : ContentPage
    {
        string lbl1Text, lbl2Text;

        public MainPage()
        {
            InitializeComponent();
        }
        private void btn1_Clicked(object sender, EventArgs e)
        {
            lbl1Text = lbl1.Text;
            lbl1.Text = lbl12.Text;
            lbl12.Text = lbl1Text;
        }

        private void btn2_Clicked(object sender, EventArgs e)
        {
            lbl2Text = lbl2.Text;
            lbl2.Text = lbl22.Text;
            lbl22.Text = lbl2Text;
        }
    }

}
