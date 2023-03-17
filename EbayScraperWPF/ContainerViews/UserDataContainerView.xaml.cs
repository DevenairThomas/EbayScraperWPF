using System;
using System.Windows;
using System.Windows.Controls;
using EbayScraperWPF.ViewModel;

namespace EbayScraperWPF.ContainerViews
{
    /// <summary>
    /// Interaction logic for UserDataContainerView.xaml
    /// </summary>
    public partial class UserDataContainerView : UserControl
    {
        private UserData userData = new UserData();
        public UserDataContainerView()
        {
            InitializeComponent();
        }

        public UserData UserData 
        { 
            get { return userData; }
            set { userData = value; }
        }

        private UserViewModel _UserData = new UserViewModel();
        private void txtUserFirstName_TextChanged(object sender, TextChangedEventArgs e)
        {
            userData.FirstName = txtUserFirstName.Text;
        }

        private void txtUserEmail_TextChanged(object sender, TextChangedEventArgs e)
        {
            userData.Email = txtUserEmail.Text;
        }

        private void txtUserLastName_TextChanged(object sender, TextChangedEventArgs e)
        {
            userData.LastName = txtUserLastName.Text;
        }

        private void txtUserCity_TextChanged(object sender, TextChangedEventArgs e)
        {
            userData.City = txtUserCity.Text;
        }

        private void txtUserState_TextChanged(object sender, TextChangedEventArgs e)
        {
            userData.State = txtUserState.Text;
        }

        private void txtUserCountry_TextChanged(object sender, TextChangedEventArgs e)
        {
            userData.Country = txtUserCountry.Text;
        }

        private void txtUserAddressLine2_TextChanged(object sender, TextChangedEventArgs e)
        {
            userData.AddressLine2 = txtUserAddressLine2.Text;
        }

        private void txtUserAddressLine1_TextChanged(object sender, TextChangedEventArgs e)
        {
            userData.AddressLine1 = txtUserAddressLine1.Text;
        }

        private void txtUserTelephone_TextChanged(object sender, TextChangedEventArgs e)
        {
            userData.Telephone = txtUserTelephone.Text;
        }

        private void txtUserCounty_TextChanged(object sender, TextChangedEventArgs e)
        {
            userData.County = txtUserCounty.Text;
        }

        private void txtUserPostalCode_TextChanged(object sender, TextChangedEventArgs e)
        {
            userData.PostalCode = txtUserPostalCode.Text;
        }

        private void btnSaveUserData_Click(object sender, RoutedEventArgs e)
        {
            _UserData.setUserData(userData);
        }
    }
}
