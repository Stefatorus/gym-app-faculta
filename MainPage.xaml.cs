namespace GymMobile
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            CounterBtn.Text = $"Ai ars {Math.Round(count * 0.0023, 3)} calorii cu degetul";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
