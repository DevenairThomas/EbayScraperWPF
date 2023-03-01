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
    public partial class MainView : Window
    {
        /// <summary>
        /// Interaction logic for MainWindow.xaml
        /// </summary>
            public MainView()
            {
                InitializeComponent();
                ScraperViewModel HomePage = new ScraperViewModel();
                ScraperViewModel UserPage = new ScraperViewModel();
                ScraperViewModel FindItemPage = new ScraperViewModel();
                ScraperViewModel ItemAnalyticsPage = new ScraperViewModel();
            }
            public EventHandler SelectItem;

            //AddItemWindow addItemWindow = new AddItemWindow();
            public EventHandler SaveItemToForm;
            static List<EbayItem> EbayItemList = new List<EbayItem>();
            static List<string> CommandList = new List<string>();
            static int count = 0, MAX_NUM_ITEMS = 10;
            EbayItem SelectedItem = new EbayItem();


            //private void onSelectItem()
            DataCommunicator COMMUNICATION = new DataCommunicator();

            private void onSaveItemToForm()
            {
                SelectItem?.Invoke(this, new EventArgs());
            }
            public void ShowSelectedItemContent()
            {
                string? itemName = listboxAllItems.SelectedItem.ToString();

                SelectItem += (s, args) =>
                {
                    getSelectedItem(itemName);
                };
            }

            private void sendMessageRecieveData()
            {
                foreach (string command in CommandList)
                {
                    COMMUNICATION.PIPE_IN_QUEUE(command);
                }
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

            private void getSelectedItem(string selectedItem)
            {
                foreach (EbayItem item in EbayItemList)
                {
                    if (selectedItem.Equals(item.Name))
                    {
                        SelectedItem = item;
                    }
                }
            }

            private void btShowItem_Click(object sender, RoutedEventArgs e)
            {
                foreach (EbayItem ebayItem in EbayItemList)
                {
                    System.Diagnostics.Debug.WriteLine(ebayItem.Name);
                }
            }
        }
    }
}
