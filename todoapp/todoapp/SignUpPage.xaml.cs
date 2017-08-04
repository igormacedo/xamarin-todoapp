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
	public partial class SignUpPage : ContentPage
	{
        public event EventHandler SignUpSubmitted;
        public event EventHandler SignUpCancelled;
        public string name, phone, email, password;

        public SignUpPage ()
		{
			InitializeComponent ();
		}

        private void submit_buttom_Clicked(object sender, EventArgs e)
        {
            name = name_entry.Text;
            phone = phone_entry.Text;
            email = email_entry.Text;
            password = password_entry.Text;
            DisplayAlert("Warning!", "You are being watched " + name, "I don't mind the Big Brother");
            OnSignUpSubmitted();
        }

        private void cancel_buttom_Clicked(object sender, EventArgs e)
        {
            onSignUpCancelled();
        }

        private void OnSignUpSubmitted()
        {
            if (SignUpSubmitted!= null)
            {
                SignUpSubmitted(this, EventArgs.Empty);
            }
        }

        private void onSignUpCancelled()
        {
            if (SignUpCancelled != null)
            {
                SignUpCancelled(this, EventArgs.Empty);
            }
        }
    }
}