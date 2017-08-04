using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace todoapp.ViewModels
{
    public class AdicionarViewModel : BaseViewModel
    {
        public Command DoneCommand { get; set; }

        public AdicionarViewModel()
        {
            DoneCommand = new Command(ExecuteDoneCommand);
        }

        private async void ExecuteDoneCommand()
        {
            await PushAsync<NextViewModel>();
        }
    }
}
