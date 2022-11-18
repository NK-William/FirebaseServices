using FirebaseServices.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirebaseServices.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public DelegateCommand PushNotifCommand { get; set; }
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
            PushNotifCommand = new DelegateCommand(OnPushNotifCommand);
        }

        private void OnPushNotifCommand()
        {
            NavigationService.NavigateAsync(nameof(PushNotificationPage));
        }
    }
}
