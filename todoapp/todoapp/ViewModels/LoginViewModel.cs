using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace todoapp.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public event EventHandler LoginSucceeded;
        public event EventHandler LoginFailed;

        public Command Signup_buttonClicked { get; set; }
        public Command Login_buttonClicked { get; set; }

        public string username = null, password = null;
        public string username_entry = null, password_entry= null;

        public LoginViewModel()
        {
            Signup_buttonClicked = new Command(ExecuteSignup_buttonClicked);
            Login_buttonClicked = new Command(ExecuteLogin_buttonClicked);
        }

        private async void ExecuteSignup_buttonClicked()
        {
            //var signuppage = new SignUpPage();
            //signuppage.SignUpSubmitted += HandleSignUpSubmitted;
            //signuppage.SignUpCancelled += HandleSignUpCancelled;
            //Navigation.PushAsync(signuppage);
            await PushAsync<SignUpViewModel>();
        }

        private async void ExecuteLogin_buttonClicked()
        {
            if (username == username_entry && password == password_entry)
            {
                OnLoginSucceeded();
            }
            else
            {
                await DisplayAlert("Error!", "Wrong username, try: " + username + " & " + password, "I'm a hacker");
                OnLoginFailed();
            }
        }

        private async void HandleSignUpSubmitted(object sender, EventArgs e)
        {
            SignUpViewModel signupvm = (SignUpViewModel)sender;
            username = signupvm.name;
            password = signupvm.password;
            await Application.Current.MainPage.Navigation.PopAsync();
        }

        private async void HandleSignUpCancelled(object sender, EventArgs e)
        {
            await Application.Current.MainPage.Navigation.PopAsync();
        }


        private void OnLoginSucceeded()
        {
            LoginSucceeded?.Invoke(this, EventArgs.Empty);
        }

        private void OnLoginFailed()
        {
            LoginFailed?.Invoke(this, EventArgs.Empty);
        }

    }
}
