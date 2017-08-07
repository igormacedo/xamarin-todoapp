using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace todoapp.ViewModels
{
    public class SignUpViewModel : BaseViewModel
    {
        public event EventHandler SignUpSubmitted;
        public event EventHandler SignUpCancelled;

        public Command Submit_buttonClicked { get; set; }
        public Command Cancel_buttonClicked { get; set; }

        public string name, phone, email, password;

        public SignUpViewModel()
        {
            Submit_buttonClicked = new Command(ExecuteSubmit_buttonClickedAsync);
            Cancel_buttonClicked = new Command(ExecuteCancel_buttonClicked);
        }

        private void ExecuteCancel_buttonClicked()
        {
            OnSignUpCancelled();
        }

        private async void ExecuteSubmit_buttonClickedAsync()
        {
            //name = name_entry.Text;
            //phone = phone_entry.Text;
            //email = email_entry.Text;
            //password = password_entry.Text;
            await DisplayAlert("Warning!", "You are being watched " + name, "I don't mind the Big Brother");
            OnSignUpSubmitted();
        }

        private void OnSignUpSubmitted()
        {
            SignUpSubmitted?.Invoke(this, EventArgs.Empty);
        }

        private void OnSignUpCancelled()
        {
            SignUpCancelled?.Invoke(this, EventArgs.Empty);
        }

    }
}
