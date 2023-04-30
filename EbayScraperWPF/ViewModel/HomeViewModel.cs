using EbayScraperWPF.CommandEvents;
using Microsoft.VisualBasic;
using Npgsql;
using System.Windows;
using System.Windows.Input;

namespace EbayScraperWPF.ViewModel
{
    public class HomeViewModel : ViewModelBase
    {
        public ViewModelBase CurrentViewModel { get; }
        private UserData _UserData;

        private string _UserEmail;
        private string _UserPassword;
        private string _ConnectionString;
        private bool _LoginSuccess;

        public enum PasswordStates
        {
            None,
            USER_CHECK_SUCCESS,
            USER_CHECK_FAIL
        }

        public HomeViewModel()
        {
            _UserData = new UserData();
            UserLogonAttempt = new RelayCommand(() => LOGIN());
        }
        public ICommand UserLogonAttempt { get; set;}
        public UserData UserData
        {
            get { return _UserData; }
            set { _UserData = value; }
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
        public bool LoginSuccess
        {
            get { return _LoginSuccess; }
            set { _LoginSuccess = value; }
        }
        private void LOGIN()
        {
            string ConnectionString = _ConnectionString;
            string EnteredUserEmail = UserEmail;
            string EnteredUserPassword = UserPassword;
            bool EMAIL_CHECK = false;
            bool PASSWORD_CHECK = false;
            string? dUserEmail = "";
            string? dPassword = "";
            PasswordStates LOGIN_STATES = PasswordStates.None;
            //@"Server=localhost;Port=5432;User Id=postgres;Password=123;Database=RecipeProj;");
            NpgsqlConnection conn = new NpgsqlConnection(ConnectionString);
            conn.Open();

            string sql = "SELECT * FROM users";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dUserEmail = dr[0].ToString();
                if (dUserEmail == null) { EMAIL_CHECK = false; }
                else if (dUserEmail == EnteredUserEmail)
                {
                    EMAIL_CHECK = true;
                    dPassword = dr[1].ToString();
                    break;
                }
            }
            conn.Close();
            if(EMAIL_CHECK == true) 
            { 
                LOGIN_STATES = CheckLogin(EnteredUserEmail, dUserEmail, EnteredUserPassword, dPassword);
                PASSWORD_CHECK = true;
            }
            switch (LOGIN_STATES)
            {
                case PasswordStates.None:
                    {
                        UserEmail = "";
                        UserPassword = "";
                        UserData = new UserData();
                        break;
                    }
                case PasswordStates.USER_CHECK_SUCCESS:
                    {
                        //TODO retrieve information from USER_TABLE
                        //POPULATE USER data into application
                        //Initiate Database Retrieval
                        break;
                    }
                case PasswordStates.USER_CHECK_FAIL:
                    {
                        UserEmail = "";
                        UserPassword = "";
                        UserData = new UserData();
                        break;
                    }
               default:
                    break;
            }
            if(EMAIL_CHECK == true && PASSWORD_CHECK == true) { LoginSuccess = true; }
            else { LoginSuccess = false; }
            return;
        }

        public PasswordStates CheckLogin(string enteredUserName, string storedUserName, string enteredUserPassword, string storedUserPassword)
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
                if (enteredUserPassword == storedUserPassword)
                {
                    passwordStates = PasswordStates.USER_CHECK_FAIL;
                    return passwordStates;
                }
                return PasswordStates.USER_CHECK_FAIL;
            }
            else
            {
                passwordStates = PasswordStates.USER_CHECK_FAIL;
            }
            return passwordStates;
        }
    }
}
