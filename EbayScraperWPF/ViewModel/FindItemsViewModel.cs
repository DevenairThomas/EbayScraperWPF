using EbayScraperWPF.CommandEvents;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System;
using EbayScraperWPF.ViewModel.ContainerViewModel;
using EbayScraperWPF.ContainerViews;
using System.Windows;

namespace EbayScraperWPF.ViewModel
{
    /// <summary>
    /// Class <c>FindItemsViewModel</c> View Model that references the View and is bound to the XAML
    /// </summary>
    public class FindItemsViewModel : ViewModelBase
    {
        private FindItemContainerViewModel _findItemContainerViewModel = new FindItemContainerViewModel();
        //List bound to the List View for Saved Items
        private ObservableCollection<FindEbayItemData>? findEbayItemDataList;
        //Object bound to Selected Item from the Saved Item List View
        private FindEbayItemData? selectedFindEbayItemData;

        //Selected item Index
        private int selectedItemIndex;
        //boolean for the Selected Item
        private bool b_SelectedItem;

        //Returns this as Current View Model
        public ViewModelBase CurrentViewModel { get; }

        //Obvious Constuctor is Obvious
        public FindItemsViewModel()
        {
            findEbayItemDataList = new ObservableCollection<FindEbayItemData>();
            selectedFindEbayItemData = new FindEbayItemData();

            //Save Item button Command
            SaveItemCommand = new RelayCommand(() => SaveCurrentItem_AddToList());
            DeleteSelectedItemCommand = new RelayCommand(() => DeleteSelectedItem());
            //show Selected Item button Command
            ShowSelectedItemCommand = new RelayCommand(() => OnSelectedItem_From_FindItemListView());

        }

        public FindItemContainerViewModel _FindItemContainerViewModel { get { return _findItemContainerViewModel; } }
        /// <summary>
        /// Methods <c>ICommand Methods</c> Bounded Methods to the FindItems View
        /// </summary>

        //Buttons
        public ICommand SaveItemCommand { get; set; }
        public ICommand DeleteSelectedItemCommand { get; set; }
        //Selected Item
        public ICommand ShowSelectedItemCommand { get; set; }

        /// <summary>
        /// Method <c>SelectedFindEbayItemData</c> accessor for Selected Item Data
        /// </summary>
        //Still needs work... Only activates once on Selected Item data
        //Does not show the Item data on the Form when selected
        public FindEbayItemData SelectedFindEbayItemData
        {
            get
            {
                return selectedFindEbayItemData;
            }

            set
            {
                if (selectedFindEbayItemData != value)
                {
                    selectedFindEbayItemData = value;
                    OnSelectedItem_From_FindItemListView();
                }
                if (findEbayItemDataList.Count > 1)
                {
                    b_SelectedItem = true;
                }
                
                OnPropertyChanged();
            }
        }
        //Method to set the Selected Item to the Public Ebay Item... Also doesnt work
        public void OnSelectedItem_From_FindItemListView()
        {
            if (SelectedItemIndex < 0)
            {
                return;
            }
            showSelectedFindEbayDataItem(selectedFindEbayItemData);
        }
        //Bounded to the Save button, Saves Item to the List View
        public void SaveCurrentItem_AddToList()
        {
            if (b_SelectedItem == true)
            {
                findEbayItemDataList[SelectedItemIndex] = _FindItemContainerViewModel.FindEbayItemData;
            }
            else
            {
                var tempItem = _FindItemContainerViewModel.FindEbayItemData;
                findEbayItemDataList.Add(tempItem);
            }
            b_SelectedItem = false;
            _FindItemContainerViewModel.FindEbayItemData = new FindEbayItemData();
        }
        public void DeleteSelectedItem()
        {
            if (b_SelectedItem == true)
            {
                findEbayItemDataList.RemoveAt(SelectedItemIndex);
            }
            else
                return;
        }
        /// <summary>
        /// Method <c>FindEbayItemDataList</c> accessor for Find Ebay Item Data List
        /// </summary>
        public ObservableCollection<FindEbayItemData> FindEbayItemDataList
        {
            get => findEbayItemDataList;
            set
            {
                if (findEbayItemDataList != value)
                {
                    findEbayItemDataList = value;
                    OnPropertyChanged();
                }
            }
        }

        public int SelectedItemIndex
        {
            get => selectedItemIndex;
            set
            {
                if (selectedItemIndex == value)
                    return;

                selectedItemIndex = value;
                OnPropertyChanged();
            }
        }
        public void showSelectedFindEbayDataItem(FindEbayItemData item)
        {
            _FindItemContainerViewModel.ItemName = item.ItemName;
            _FindItemContainerViewModel.ItemKeywords = item.ItemKeywords;
            _FindItemContainerViewModel.MaxBids = item.MaxBids;
            _FindItemContainerViewModel.MinBids = item.MinBids;
            _FindItemContainerViewModel.MaxPrice = item.MaxPrice;
            _FindItemContainerViewModel.MinPrice = item.MinPrice;
            _FindItemContainerViewModel.Condition = item.Condition;
            _FindItemContainerViewModel.OfferOnly = item.OfferOnly;
            _FindItemContainerViewModel.FeedbackMin = item.FeedbackMin;
            _FindItemContainerViewModel.FeedbackMax = item.FeedbackMax;
            _FindItemContainerViewModel.LotsOnly = item.LotsOnly;
            _FindItemContainerViewModel.BestOfferOnly = item.BestOfferOnly;
            _FindItemContainerViewModel.AuctionOnly = item.AuctionOnly;
            _FindItemContainerViewModel.BuyItNowOnly = item.BuyItNowOnly;
            _FindItemContainerViewModel.PaymentMethod = item.PaymentMethod;
            _FindItemContainerViewModel.MinQuantity = item.MinQuantity;
            _FindItemContainerViewModel.MaxQuantity = item.MaxQuantity;
            _FindItemContainerViewModel.ListingType = item.ListingType;
            _FindItemContainerViewModel.Currency = item.Currency;
            _FindItemContainerViewModel.ReturnsAcceptedOnly = item.ReturnsAcceptedOnly;
            _FindItemContainerViewModel.FreeShippingOnly = item.FreeShippingOnly;
            _FindItemContainerViewModel.ExpeditedShippingType = item.ExpeditedShippingType;
            _FindItemContainerViewModel.EndTimeTo = item.EndTimeTo;
            _FindItemContainerViewModel.EndTimeFrom = item.EndTimeFrom;
            _FindItemContainerViewModel.TopRatedSellerOnly = item.TopRatedSellerOnly;
            _FindItemContainerViewModel.MaxHandlingTime = item.MaxHandlingTime;
            _FindItemContainerViewModel.AvailableTo = item.AvailableTo;
            _FindItemContainerViewModel.GetItFastOnly = item.GetItFastOnly;
            _FindItemContainerViewModel.SellerName = item.SellerName;
            _FindItemContainerViewModel.ModTimeFrom = item.ModTimeFrom;
            _FindItemContainerViewModel.LocatedIn = item.LocatedIn;
            _FindItemContainerViewModel.ListedIn = item.ListedIn;
            _FindItemContainerViewModel.MaxDistance = item.MaxDistance;
            _FindItemContainerViewModel.LocalPickupOnly = item.LocalPickupOnly;
            _FindItemContainerViewModel.LocalSearchOnly = item.LocalSearchOnly;
            _FindItemContainerViewModel.SellerBusinessType = item.SellerBusinessType;
            _FindItemContainerViewModel.HideDuplicateItems = item.HideDuplicateItems;
            _FindItemContainerViewModel.ValueBoxInventory = item.ValueBoxInventory;
            _FindItemContainerViewModel.ExcludeAutoPay = item.ExcludeAutoPay;
            _FindItemContainerViewModel.ExcludeCategory = item.ExcludeCategory;
            _FindItemContainerViewModel.ExcludeSeller = item.ExcludeSeller;
            _FindItemContainerViewModel.CharityOnly = item.CharityOnly;
        }
    }
}
