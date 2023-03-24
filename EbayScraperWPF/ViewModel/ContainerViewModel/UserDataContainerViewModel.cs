using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbayScraperWPF.ViewModel.ContainerViewModel
{
    public class UserDataContainerViewModel : ViewModelBase
    {
        private UserData? userData;

        public UserDataContainerViewModel()
        {
            userData = new UserData();

        }
        public UserData UserData
        {
            get { return userData; }
            set { userData = value; OnPropertyChanged(); }
        }

        public string FirstName
        {
            get { if(!string.IsNullOrWhiteSpace(userData.FirstName)) { return userData.FirstName; } else return ""; }
            set { userData.FirstName = value; OnPropertyChanged(); }
        }
        public string LastName
        {
            get { if (!string.IsNullOrWhiteSpace(userData.LastName)) { return userData.LastName; } else return ""; }
            set { userData.LastName = value; OnPropertyChanged(); }
        }
        public string Email
        {
            get { if (!string.IsNullOrWhiteSpace(userData.Email)) { return userData.Email; } else return ""; }
            set { userData.Email = value; OnPropertyChanged(); }
        }
        public string Telephone
        {
            get { if (!string.IsNullOrWhiteSpace(userData.Telephone)) { return userData.Telephone; } else return ""; }
            set { userData.Telephone = value; OnPropertyChanged(); }
        }
        public string AddressLine1
        {
            get { if (!string.IsNullOrWhiteSpace(userData.AddressLine1)) { return userData.AddressLine1; } else return ""; }
            set { userData.AddressLine1 = value; OnPropertyChanged(); }
        }
        public string AddressLine2
        {
            get { if (!string.IsNullOrWhiteSpace(userData.AddressLine2)) { return userData.AddressLine2; } else return ""; }
            set { userData.AddressLine2 = value; OnPropertyChanged(); }
        }
        public string Country
        {
            get { if (!string.IsNullOrWhiteSpace(userData.Country)) { return userData.Country; } else return ""; }
            set { userData.Country = value; OnPropertyChanged(); }
        }
        public string State
        {
            get { if (!string.IsNullOrWhiteSpace(userData.State)) { return userData.State; } else return ""; }
            set { userData.State = value; OnPropertyChanged(); }
        }
        public string City
        {
            get { if (!string.IsNullOrWhiteSpace(userData.City)) { return userData.City; } else return ""; }
            set { userData.City = value; OnPropertyChanged(); }
        }
        public string County
        {
            get { if (!string.IsNullOrWhiteSpace(userData.County)) { return userData.County; } else return ""; }
            set { userData.County = value; OnPropertyChanged(); }
        }
        public string PostalCode
        {
            get { if (!string.IsNullOrWhiteSpace(userData.PostalCode)) { return userData.PostalCode; } else return ""; }
            set { userData.PostalCode = value; OnPropertyChanged(); }
        }
        public string UserApiCode
        {
            get { if (!string.IsNullOrWhiteSpace(userData.UserApiCode)) { return userData.UserApiCode; } else return ""; }
            set { userData.UserApiCode = value; OnPropertyChanged(); }
        }

    }
}
