using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmHelpers;
using Xamarin.Forms;
using ProjectCards.Pages;
//using FormsToolkit;
//using Microsoft.Practices.ServiceLocation;
//using Plugin.Messaging;

namespace ProjectCards.ViewModels
{
    public class HomeViewModel : BaseNavigationViewModel
    {
        public Command _AddCommand;

        public Command AddCommand
        {
            get { return _AddCommand ?? (_AddCommand = new Command(async () => await OnAddCommand())); }
        }

        public async Task OnAddCommand()
        {
            await PushAsync(new CardAddPage()
            {
                BindingContext = new CardAddViewModel(),
                Title = "Add Card"
            });
        }
    }
}
