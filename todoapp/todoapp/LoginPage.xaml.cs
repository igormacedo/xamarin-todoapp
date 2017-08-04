using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace todoapp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{

        public event EventHandler LoginSucceeded;
        public event EventHandler LoginFailed;
        public string username = null, password = null;

        public LoginPage ()
		{
			InitializeComponent ();
		}

        private void login_button_Clicked(object sender, EventArgs e)
        {
            if(username == username_entry.Text && password == password_entry.Text)
            {
                OnLoginSucceeded();
            }
            else
            {
                DisplayAlert("Error!", "Wrong username, try: " + username + " & " + password, "I'm a hacker");
                OnLoginFailed();
            }
        }

        private void signup_button_Clicked(object sender, EventArgs e)
        {
            var signuppage = new SignUpPage();
            signuppage.SignUpSubmitted += HandleSignUpSubmitted;
            signuppage.SignUpCancelled += HandleSignUpCancelled;
            Navigation.PushAsync(signuppage);
        }

        private async void HandleSignUpSubmitted(object sender, EventArgs e)
        {
            SignUpPage signuppage = (SignUpPage) sender;
            username = signuppage.name;
            password = signuppage.password;
            await Navigation.PopAsync();
        }

        private async void HandleSignUpCancelled(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private void OnLoginSucceeded()
        {
            if (LoginSucceeded != null)
            {
                LoginSucceeded(this, EventArgs.Empty);
            }
        }

        private void OnLoginFailed()
        {
            if (LoginFailed != null)
            {
                LoginFailed(this, EventArgs.Empty);
            }
        }
    }
}