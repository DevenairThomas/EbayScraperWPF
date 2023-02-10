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

        //AddItemWindow addItemWindow = new AddItemWindow();
        static List<EbayItem> EbayItemList = new List<EbayItem>();
        int count = 0;


        public void addSavedItem(EbayItem ebayItem)
        {
            EbayItemList.Add(ebayItem);
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
