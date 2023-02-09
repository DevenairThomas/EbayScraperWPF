using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        }
        public string itemName;
        public string itemKeywords;
        public double itemMaxPrice;
        public double itemLowPrice;
        public bool itemAuction;
        public bool itemBuyNow;
        public bool itemOffer;

        static EbayItem ebayitem;
        private void btnSaveItem_Click(object sender, RoutedEventArgs e)
        {
            Close();
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

        }

        private void textItemKeywords_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void checkboxAuction_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void checkboxBuyNow_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void checkboxOffer_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
