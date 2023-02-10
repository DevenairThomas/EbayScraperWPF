using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace EbayScraperWPF
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class AddItemWindow : Window
    {
        public AddItemWindow()
        {
            InitializeComponent();
            initMutex();
        }
        
        public EventHandler SaveItem;

        public string itemName;
        public string itemKeywords;
        public double itemMaxPrice;
        public double itemLowPrice;
        public bool itemAuction = false;
        public bool itemBuyNow = false;
        public bool itemOffer = false;
        public bool saveItemToMain = false;
        Mutex mutexItem;

        public EbayItem item = new EbayItem();
        private void btnSaveItem_Click(object sender, RoutedEventArgs e)
        {
            PushItemToMain();
            //Close();
        }
        public void PushItemToMain()
        {
            itemMaxPrice = Convert.ToDouble(textMaxPrice.Text);
            itemLowPrice = Convert.ToDouble(textLowPrice.Text);

            SaveItem += (s, args) =>
            {
                if (itemName != "" || itemKeywords != "" || itemMaxPrice > 0 || itemLowPrice > 0)
                {
                    item.Name = itemName;
                    item.Keywords = itemKeywords;
                    item.MaxPrice = itemMaxPrice;
                    item.LowPrice = itemLowPrice;
                    item.Offer = itemOffer;
                    item.Auction = itemAuction;
                    item.BuyNow = itemBuyNow;
                    saveItemToMain = true;
                }
                else { return; }
            };
            onSaveItem();
        }
        public void returnItem()
        {
            EbayItem retVal = new EbayItem();
            var window = Application.Current.MainWindow;
            mutexItem.WaitOne();
            retVal = item;
            mutexItem.ReleaseMutex();
            (window as MainWindow)?.addSavedItem(retVal);
        }
        public void onSaveItem()
        {
            SaveItem?.Invoke(this, new EventArgs());
        }
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void textLowPrice_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void textMaxPrice_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void textItemName_TextChanged(object sender, TextChangedEventArgs e)
        {
            itemName = textItemName.Text;
        }

        private void textItemKeywords_TextChanged(object sender, TextChangedEventArgs e)
        {
            itemKeywords = textItemKeywords.Text;
        }

        private void checkboxAuction_Checked(object sender, RoutedEventArgs e)
        {
            itemAuction = !itemAuction;
        }

        private void checkboxBuyNow_Checked(object sender, RoutedEventArgs e)
        {
            itemBuyNow = !itemBuyNow;
        }

        private void checkboxOffer_Checked(object sender, RoutedEventArgs e)
        {
            itemOffer = !itemOffer;
        }
        private void initMutex()
        {
            mutexItem = new Mutex();
        }
    }
}
