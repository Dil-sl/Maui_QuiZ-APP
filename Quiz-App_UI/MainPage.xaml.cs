namespace Quiz_App_UI
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void Logout_Btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }
    }
}