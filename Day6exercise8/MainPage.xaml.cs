namespace Day6exercise8
{
    public partial class MainPage : ContentPage
    {
        List<string> chkList = new List<string>();
        public MainPage()
        {
            InitializeComponent();
        }

        private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            var chkbtn = (CheckBox)sender;
            var lbl = (Label)chkbtn.BindingContext;
            if (chkbtn.IsChecked && !chkList.Contains(lbl.Text))
            {
                chkList.Add(lbl.Text);
            }
            else
            {
                chkList.Remove(lbl.Text);
            }
            lblChk.Text = string.Join(", ", chkList);
        }

        private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            var rbtn = (RadioButton)sender;
            lblRbtn.Text = rbtn.Content.ToString() + " checked";
        }
    }

}
