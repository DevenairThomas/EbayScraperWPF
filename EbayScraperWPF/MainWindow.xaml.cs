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

namespace EbayScraperWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public EventHandler SelectItem;

        //AddItemWindow addItemWindow = new AddItemWindow();
        static List<EbayItem> EbayItemList = new List<EbayItem>();
        static int count = 0, MAX_NUM_ITEMS = 10;
        EbayItem SelectedItem = new EbayItem();


        private void onSelectItem()
        {
            SelectItem?.Invoke(this, new EventArgs());
        }
        public void ShowSelectedItemContent()
        {
            string? itemName = listboxAllItems.SelectedItem.ToString();

            SelectItem += (s,args) =>
            {
                getSelectedItem(itemName);
            };
        }
        public void addSavedItem(EbayItem ebayItem)
        {
            EbayItemList.Add(ebayItem);
            listboxAllItems.Items.Add(ebayItem.Name);
        }
        private void btnAddItem_Click(object sender, RoutedEventArgs e)
        {
            AddItemWindow addItemWindow = new AddItemWindow();
            EbayItem tempItem = new EbayItem();
            addItemWindow.Show();

            addItemWindow.SaveItem += (s, args) =>
            {
                if (addItemWindow.saveItemToMain) 
                {
                    addItemWindow.returnItem();
                    addItemWindow.Close();

                }
            };
            addItemWindow.onSaveItem();
        }
        private void setSelectedItemToView(EbayItem selectedItem)
        {
            //TODO set the selectedItem Content to the Form Fields
        }

        private void getSelectedItem (string selectedItem)
        {
            foreach(EbayItem item in EbayItemList)
            {
                if (selectedItem.Equals(item.Name))
                {
                    SelectedItem = item;
                }
            }
        }
        private void btShowItem_Click(object sender, RoutedEventArgs e)
        {
            foreach(EbayItem ebayItem in EbayItemList)
            {
                System.Diagnostics.Debug.WriteLine(ebayItem.Name);
            }
        }
    }
}
