using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbayScraperWPF.Model
{
    public class EbayItemData
    {
        private string _ItemName;
        private FindEbayItemData _FindEbayItemData;
        private int _TimesPolled;
        private int _RecordsInDatabase;
        private UserData _UserData;
        private DateTime _DatePolled;
        private DateTime _DateCreated;
        private int _EbayItemDataID;

        public EbayItemData()
        {
            _FindEbayItemData = new FindEbayItemData();
            _UserData = new UserData();
        }

        public string ItemName
        {
            get { return _ItemName; }
            set { _ItemName = value; }
        }
        public int TimesPolled
        {
            get { return _TimesPolled; }
            set { _TimesPolled = value; }
        }
        public FindEbayItemData FindEbayItemData 
        {
            get { return _FindEbayItemData;} 
            set { _FindEbayItemData = value;}
        }
        public int RecordsInDatabase
        {
            get { return _RecordsInDatabase; }
            set { _RecordsInDatabase = value; }
        }
        public DateTime DateCreated
        {
            get { return _DateCreated; }
            set { _DateCreated = value; }
        }
        public DateTime DatePolled 
        { 
            get { return _DatePolled; }
            set { _DatePolled = value; } 
        }
        public UserData UserData 
        { 
            get { return _UserData; }
            set { _UserData = UserData; }
        }
        public int EbayItemDataID
        {
            get { return _EbayItemDataID; }
            set { _EbayItemDataID = value; }
        }

    }
}
