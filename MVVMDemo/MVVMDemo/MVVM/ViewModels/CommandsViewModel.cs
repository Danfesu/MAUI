using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMDemo.MVVM.ViewModels
{
    public class CommandsViewModel
    {
        public ICommand ClickCommand;
        public ICommand SearchCommand;

        public CommandsViewModel()
        {
            ClickCommand = new Command(Alert);
            SearchCommand = new Command((s) => Search(s));
        }

        private void Search(object s)
        {
            var data = s;
        }

        private void Alert()
        {
            App.Current.MainPage.DisplayAlert("Title", "Message", "Ok");
        }
    }
}
