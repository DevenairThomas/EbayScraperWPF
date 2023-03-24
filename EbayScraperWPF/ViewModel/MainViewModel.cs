using EbayScraperWPF.CommandEvents;
using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using EbayScraperWPF.ViewModel;

namespace EbayScraperWPF.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private ViewModelBase? selectedViewModel;

        private CheckoutViewModel? checkoutViewModel;
        private FindItemsViewModel? findItemsViewModel;
        private FindSoldItemsViewModel? findSoldItemsViewModel;
        private HomeViewModel? homeViewModel;
        private ItemAnalyticsViewModel? itemAnalyticsViewModel;
        private SoldItemAnalyticsViewModel? soldItemAnalyticsViewModel;
        private UserViewModel? userViewModel;
        public MainViewModel()
        {
            homeViewModel = new HomeViewModel();
            checkoutViewModel = new CheckoutViewModel();
            findItemsViewModel = new FindItemsViewModel();
            findSoldItemsViewModel = new FindSoldItemsViewModel();
            itemAnalyticsViewModel = new ItemAnalyticsViewModel();
            soldItemAnalyticsViewModel = new SoldItemAnalyticsViewModel();
            userViewModel = new UserViewModel();

            NavigateToHomeViewModel = new RelayCommand(() => _NavigateToHomeViewModel());
            NavigateToUserViewModel = new RelayCommand(() => _NavigateToUserViewModel());
            NavigateToFindItemViewModel = new RelayCommand(() => _NavigateToFindItemViewModel());
            NavigateToFindSoldItemViewModel = new RelayCommand(() => _NavigateToFindSoldItemViewModel());
            NavigateToItemAnalyticsViewModel = new RelayCommand(() => _NavigateToItemAnalyticsViewModel());
            NavigateToSoldItemAnalyticsViewModel = new RelayCommand(() => _NavigateToSoldItemAnalyticsViewModel());
            NavigateToCheckoutViewModel = new RelayCommand(() => _NavigateToCheckoutViewModel());

            SelectedViewModel = homeViewModel;
        }
        public ICommand NavigateToHomeViewModel { get; set; }
        public ICommand NavigateToUserViewModel { get; set; }
        public ICommand NavigateToFindItemViewModel { get; set; }
        public ICommand NavigateToFindSoldItemViewModel { get; set; }
        public ICommand NavigateToItemAnalyticsViewModel { get; set; }
        public ICommand NavigateToSoldItemAnalyticsViewModel { get; set; }
        public ICommand NavigateToCheckoutViewModel { get; set; }


        public ViewModelBase SelectedViewModel
        {
            get
            {
               return selectedViewModel;
            }
            set
            {
                selectedViewModel = value;
                OnPropertyChanged();
            }
        }

        public void _NavigateToHomeViewModel() { SelectedViewModel = homeViewModel;}
        public void _NavigateToUserViewModel() { SelectedViewModel = userViewModel;}
        public void _NavigateToFindItemViewModel() { SelectedViewModel = findItemsViewModel;}
        public void _NavigateToFindSoldItemViewModel() { SelectedViewModel = findSoldItemsViewModel;}
        public void _NavigateToItemAnalyticsViewModel() { SelectedViewModel = itemAnalyticsViewModel;}
        public void _NavigateToSoldItemAnalyticsViewModel() { SelectedViewModel = soldItemAnalyticsViewModel;}
        public void _NavigateToCheckoutViewModel() { SelectedViewModel = checkoutViewModel;}

    }
}
