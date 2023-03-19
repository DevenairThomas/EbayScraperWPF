using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EbayScraperWPF;

namespace EbayScraperWPF.ViewModel
{
    public class UserViewModel : ViewModelBase
    {
        private string firstName;
        private string lastName;
        private string email;
        private string telephone;
        private string addressLine1;
        private string addressLine2;
        private string country;
        private string state;
        private string city;
        private string county;
        private string postalCode;

        public void setUserData(UserData userData)
        {
            FirstName = userData.FirstName;
            LastName = userData.LastName;
            Email = userData.Email;
            State = userData.State;
            Telephone = userData.Telephone;
            AddressLine1 = userData.AddressLine1;
            AddressLine2 = userData.AddressLine1;
            Country = userData.Country;
            City = userData.City;
            County = userData.County;
            PostalCode = userData.PostalCode;
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; OnPropertyChanged(); }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; OnPropertyChanged(); }
        }
        public string Email
        {
            get { return email; }
            set { email = value; OnPropertyChanged(); }
        }
        public string Telephone
        {
            get { return telephone; }
            set { telephone = value; OnPropertyChanged(); }
        }
        public string AddressLine1
        {
            get { return addressLine1; }
            set { addressLine1 = value; OnPropertyChanged(); }
        }
        public string AddressLine2
        {
            get { return addressLine2; }
            set { addressLine2 = value; OnPropertyChanged(); }
        }
        public string Country
        {
            get { return country; }
            set { country = value; OnPropertyChanged(); }
        }
        public string State
        {
            get { return state; }
            set { state = value; OnPropertyChanged(); }
        }
        public string City
        {
            get { return city; }
            set { city = value; OnPropertyChanged(); }
        }
        public string County
        {
            get { return county; }
            set { county = value; OnPropertyChanged(); }
        }
        public string PostalCode
        {
            get { return postalCode; }
            set { postalCode = value; OnPropertyChanged(); }
        }
    }
}
