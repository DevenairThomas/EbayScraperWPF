using System;
using System.Windows.Input;
using EbayScraperWPF;
using EbayScraperWPF.ViewModel.ContainerViewModel;
using EbayScraperWPF.CommandEvents;

namespace EbayScraperWPF.ViewModel
{
    public class UserViewModel : ViewModelBase
    {
        private UserData userdata;
        private UserDataContainerViewModel userDataContainerViewModel;

        public UserViewModel()
        {
            userdata = new UserData();
            SaveUserCommand = new RelayCommand(() => SaveUser());
            userDataContainerViewModel = new UserDataContainerViewModel();
        }
        public UserDataContainerViewModel _UserDataContainerViewModel { get { return userDataContainerViewModel; } }
        public ICommand SaveUserCommand { get; set; }
        public void SaveUser()
        {
            var tempUser = userDataContainerViewModel.UserData;
            userdata = tempUser;
        }
    }
}
