using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EbayScraperWPF.ViewModel
{
    public class HomeViewModel : ViewModelBase
    {
        public ViewModelBase CurrentViewModel { get; }
        private UserData _UserData;

        private string _UserEmail;
        private string _UserPassword;

        public enum PasswordStates
        {
            None,
            EMAIL_CHECK_SUCCESS,
            PASSWORD_CHECK_SUCCESS,
            USER_CHECK_SUCCESS,
            EMAIL_CHECK_FAIL,
            USER_CHECK_FAIL,
            PASSWORD_CHECK_FAIL
        }
        
        public HomeViewModel()
        {
           _UserData = new UserData();
        }
        public UserData UserData 
        { 
            get { return _UserData; } 
        }
        public string UserEmail
        {
            get { return _UserEmail; }
            set
            {
                _UserEmail = value;
                OnPropertyChanged();
            }
        }
        public string UserPassword
        {
            get { return _UserPassword; }
            set
            {
                _UserPassword = value;
                OnPropertyChanged();
            }
        }

        public PasswordStates CheckLogin(string enteredUserName,string storedUserName, string enteredUserPassword, string storedUserPassword)
        {
            PasswordStates passwordStates = PasswordStates.None;
            //No User password entered
            if (string.IsNullOrEmpty(enteredUserPassword)) 
            {
                MessageBox.Show("message", nameof(enteredUserPassword));
                passwordStates = PasswordStates.USER_CHECK_FAIL;
                return passwordStates;
            }
            //No User Name entered
            else if (string.IsNullOrEmpty(enteredUserName))
            {
                MessageBox.Show("message", nameof(enteredUserName));
                passwordStates = PasswordStates.USER_CHECK_FAIL;
                return passwordStates;
            }
            //User Name Entered Success
            else if (enteredUserName == storedUserName)
            {
                //User Password Entered Success
                passwordStates = PasswordStates.EMAIL_CHECK_SUCCESS;
                if(enteredUserPassword == storedUserPassword)
                {
                    passwordStates = PasswordStates.PASSWORD_CHECK_SUCCESS;
                    return passwordStates;
                }
                return PasswordStates.PASSWORD_CHECK_FAIL;
            }
            else
            {
                MessageBox.Show("message", nameof(enteredUserPassword));
                passwordStates = PasswordStates.EMAIL_CHECK_FAIL;
            }
            return passwordStates;
        }
        
    }
}
