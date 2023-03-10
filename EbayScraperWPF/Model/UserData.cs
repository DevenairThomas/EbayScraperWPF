using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbayScraperWPF.Models
{
    public class UserData
    {
        public string FirstName
        {
            get { return FirstName; }
            set { FirstName = value; OnPropertyChanged("FirstName"); }
        }
        public string LastName
        {
            get { return LastName; }
            set { LastName = value; OnPropertyChanged("LastName"); }
        }
        //More User Information
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
