using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using todoapp.Views;
using Xamarin.Forms;

namespace todoapp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var loginPage = new LoginPage();
            //loginPage.BindingContext.LoginSucceeded += HandleLoginSucceeded;
            //loginPage.BindingContext.LoginFailed += HandleLoginFailed;
            //MainPage = new NavigationPage(new LoginPage());
            MainPage = new NavigationPage(loginPage);
        }

        private void HandleLoginSucceeded(object sender, EventArgs e)
        {
            LoginPage lp = (LoginPage) sender;
            MainPage = new NavigationPage(new MainPage());
        }

        private void HandleLoginFailed(object sender, EventArgs e)
        {
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
