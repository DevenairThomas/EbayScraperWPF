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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EbayScraperWPF.ContainerViews
{
    /// <summary>
    /// Interaction logic for FindItemContainerAdvancedDetailView.xaml
    /// </summary>
    public partial class FindItemContainerAdvancedDetailView : UserControl
    {
        private FindEbayItemData ebayFindItemData;
        private bool advancedItemUsed;

        public FindItemContainerAdvancedDetailView()
        {
            InitializeComponent();
        }

        public FindEbayItemData EbayFindItemData
        {
            get
            {
                return ebayFindItemData;
            }
        }
        public bool AdvancedItemUsed
        {
            get
            {
                return advancedItemUsed;
            }
            set
            {
                advancedItemUsed = value;
            }
        }


        private void txtSeller_TextChanged(object sender, TextChangedEventArgs e)
        {
            ebayFindItemData.Seller = txtSeller.Text;
            AdvancedItemUsed = true;
        }

        private void txtExcludeSeller_TextChanged(object sender, TextChangedEventArgs e)
        {
            ebayFindItemData.ExcludeSeller = txtExcludeSeller.Text;
            AdvancedItemUsed = true;
        }

        private void cmbBoxSellerBusinessType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            AdvancedItemUsed = true;
            ebayFindItemData.SellerBusinessType = txtSeller.SelectedText;
        }

        private void chkHideDuplicateItems_Checked(object sender, RoutedEventArgs e)
        {
            if(chkHideDuplicateItems.IsChecked == true)
            {
                ebayFindItemData.HideDuplicateItems = "TRUE";
                AdvancedItemUsed = true;
            }
            else
            {
                ebayFindItemData.HideDuplicateItems = "FALSE"; 
                AdvancedItemUsed = true;
            }
        }

        private void txtExcludeAutoPay_Checked(object sender, RoutedEventArgs e)
        {
            if (txtExcludeAutoPay.IsChecked == true)
            {
                AdvancedItemUsed = true;
                ebayFindItemData.ExcludeAutoPay = "TRUE";
            }
            else
            {
                ebayFindItemData.ExcludeAutoPay = "FALSE";
                AdvancedItemUsed = true;
            }
        }

        private void chkValueBoxInventory_Checked(object sender, RoutedEventArgs e)
        {
            if (chkValueBoxInventory.IsChecked == true)
            {
                ebayFindItemData.ValueBoxInventory = "TRUE";
                AdvancedItemUsed = true;
            }
            else
            {
                ebayFindItemData.ValueBoxInventory = "FALSE";
                AdvancedItemUsed = true;
            }
        }

        private void chkCharityOnly_Checked(object sender, RoutedEventArgs e)
        {
            if (chkCharityOnly.IsChecked == true)
            {
                ebayFindItemData.CharityOnly = "TRUE";
                AdvancedItemUsed = true;
            }
            else
            {
                ebayFindItemData.CharityOnly = "FALSE";
                AdvancedItemUsed = true;
            }
        }

        private void txtExcludeCategory_TextChanged(object sender, TextChangedEventArgs e)
        {
            AdvancedItemUsed = true;
            ebayFindItemData.ExcludeCategory = txtExcludeCategory.Text;
        }
    }
}
