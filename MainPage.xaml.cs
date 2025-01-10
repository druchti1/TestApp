namespace TestApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Card1Clicked(object sender, EventArgs e)
        {
            Card1.IsVisible = false;
            Card1.IsEnabled = false;
            Card2.IsVisible = true;
            Card2.IsEnabled = true;
            Card2.Source = "c10c.png";
        }

        private void Card2Clicked(object sender, EventArgs e)
        {
            Card2.IsVisible = false;
            Card2.IsEnabled = false;
            Card1.IsVisible = true;
            Card1.IsEnabled = true;
            Card1.Source = "c10c.png";
        }
    }
}
