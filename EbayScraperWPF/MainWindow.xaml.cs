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
        public EventHandler SaveItemToForm;
        static List<EbayItem> EbayItemList = new List<EbayItem>();
        static List<string> CommandList = new List<string>();
        static int count = 0, MAX_NUM_ITEMS = 10;

        DataCommunicator COMMUNICATION = new DataCommunicator();

        private void onSaveItemToForm()
        {
            SaveItemToForm?.Invoke(this, new EventArgs());
        }

        private void sendMessageRecieveData()
        {
            foreach(string command in CommandList)
            {
                COMMUNICATION.PIPE_IN_QUEUE(command);
            }
        }
        
        public void addSavedItem(EbayItem ebayItem)
        {
            EbayItemList.Add(ebayItem);
            listboxAllItems.Items.Add(ebayItem.Name);
            onSaveItemToForm();
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

        private void btShowItem_Click(object sender, RoutedEventArgs e)
        {
            foreach(EbayItem ebayItem in EbayItemList)
            {
                System.Diagnostics.Debug.WriteLine(ebayItem.Name);
            }
        }
    }
}
