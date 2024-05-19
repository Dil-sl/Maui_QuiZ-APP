using Quiz_App_UI.Model;
using Quiz_App_UI.Repository;

namespace Quiz_App_UI;

public partial class LoginPage : ContentPage
{
	readonly IUserRepository userServer = new UserService();
	public LoginPage()
	{
		InitializeComponent();
	}

    private async void btnLogin_Clicked(object sender, EventArgs e)
	{
		try
		{
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                await Shell.Current.DisplayAlert("Error", "All Fields Required", "Ok");
                return;
            }
            User user = await userServer.Login(email, password);
            if (user == null)
            {
                await DisplayAlert("Error", "Creditional Are Incorrect", "Ok");
                return;
            }
            await Navigation.PushAsync(new MainPage());
            await DisplayAlert("Login", "Succesfully Logged In", "Ok");
        }
		catch (Exception ex)
		{ 
            await DisplayAlert("Login", ex.Message, "Ok");
        }
    }
}