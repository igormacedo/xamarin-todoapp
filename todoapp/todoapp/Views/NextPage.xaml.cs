using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using todoapp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace todoapp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NextPage : ContentPage
    {
        public NextPage()
        {
            InitializeComponent();
            BindingContext = new NextViewModel();
        }
    }
}