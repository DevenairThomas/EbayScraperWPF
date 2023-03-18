using EbayScraperWPF.CommandEvents;
using System.Collections.Generic;
using System.Windows.Input;

namespace EbayScraperWPF.ViewModel
{
    public class FindItemsViewModel : ViewModelBase
    {
        private List<FindEbayItemData> findEbayItemDataList;
        private FindEbayItemData privateFindEbayItemData;
        public ViewModelBase CurrentViewModel { get; }
        
        public FindItemsViewModel()
        {
            //All of the Commands attached to the set CheckBox Params to alter the value to false
            //The value needs to be a string because when its sent to the bot for processing 
            //The value inputted into the bot will be a string and I want to create the least amount of friction possible before
            //The bot scrapes the data from the Ebay page
            chkOfferOnly = new RelayCommand(() => setCheckboxParams(OfferOnly));
            chkBuyNowOnly = new RelayCommand(() => setCheckboxParams(BuyItNowOnly));
            chkAuctiopnOnly = new RelayCommand(() => setCheckboxParams(AuctionOnly));
            chkLotsOnly = new RelayCommand(() => setCheckboxParams(LotsOnly));
            chkGetItFastOnly = new RelayCommand(() => setCheckboxParams(GetItFastOnly));
            chkTopRatesdSellerOnly = new RelayCommand(() => setCheckboxParams(TopRatedSellerOnly));
            chkReturnsAcceptedOnly = new RelayCommand(() => setCheckboxParams(ReturnsAcceptedOnly));
            chkFreeShippingOnly = new RelayCommand(() => setCheckboxParams(FreeShippingOnly));
            chkOneDayShippingOnly = new RelayCommand(() => setCheckboxParams(ExpeditedShippingType));

            //Save button Command Here

        }
        public ICommand btnSaveItemCommand { get; set; }
        public ICommand chkOfferOnly { get;  set; }
        public ICommand chkBuyNowOnly { get;  set; }
        public ICommand chkAuctiopnOnly { get; set; }
        public ICommand chkLotsOnly { get;  set; }
        public ICommand chkGetItFastOnly { get; set; }
        public ICommand chkTopRatesdSellerOnly  { get; set; }
        public ICommand chkReturnsAcceptedOnly {  get;  set; }
        public ICommand chkFreeShippingOnly {  get;  set; }
        public ICommand chkOneDayShippingOnly { get; set; }

        public void setCheckboxParams(object dataParameters)
        {
            if (dataParameters == "" || dataParameters == "False")
            {
                dataParameters = "TRUE";
            }
            else
            {
                dataParameters = "FALSE";
            }
        }

        public List<FindEbayItemData> FindEbayItemData
        {
            get { return findEbayItemDataList; }
            set { findEbayItemDataList = value; OnPropertyChanged(); }
        }
        public FindEbayItemData publicFindEbayItemData
        {
            get { return privateFindEbayItemData; }
            set { privateFindEbayItemData = value; OnPropertyChanged(); }
        }

        public string ItemName
        {
            get { return privateFindEbayItemData.ItemName; }
            set { privateFindEbayItemData.ItemName = value; OnPropertyChanged(); }
        }
        public string ItemKeywords
        {
            get { return privateFindEbayItemData.ItemKeywords; }
            set { privateFindEbayItemData.ItemKeywords = value; OnPropertyChanged(); }
        }
        public string MaxBids
        {
            get { return privateFindEbayItemData.MaxBids; }
            set { privateFindEbayItemData.MaxBids = value; OnPropertyChanged(); }
        }
        public string MinBids
        {
            get { return privateFindEbayItemData.MinBids; }
            set { privateFindEbayItemData.MinBids = value; OnPropertyChanged(); }
        }
        public string MaxPrice
        {
            get { return privateFindEbayItemData.MaxPrice; }
            set { privateFindEbayItemData.MaxPrice = value; OnPropertyChanged(); }
        }
        public string MinPrice
        {
            get { return privateFindEbayItemData.MinPrice; }
            set { privateFindEbayItemData.MinPrice = value; OnPropertyChanged(); }
        }
        public string Condition
        {
            get { return privateFindEbayItemData.Condition; }
            set { privateFindEbayItemData.Condition = value; OnPropertyChanged(); }
        }
        public string OfferOnly
        {
            get { return privateFindEbayItemData.OfferOnly; }
            set { privateFindEbayItemData.OfferOnly = value; OnPropertyChanged(); }
        }
        public string FeedbackMin
        {
            get { return privateFindEbayItemData.FeedbackMin; }
            set { privateFindEbayItemData.FeedbackMin = value; OnPropertyChanged(); }
        }
        public string FeedbackMax
        {
            get { return privateFindEbayItemData.FeedbackMax; }
            set { privateFindEbayItemData.FeedbackMax = value; OnPropertyChanged(); }
        }
        public string LotsOnly
        {
            get { return privateFindEbayItemData.LotsOnly; }
            set { privateFindEbayItemData.LotsOnly = value; OnPropertyChanged(); }
        }
        public string BestOfferOnly
        {
            get { return privateFindEbayItemData.BestOfferOnly; }
            set { privateFindEbayItemData.BestOfferOnly = value; OnPropertyChanged(); }
        }
        public string AuctionOnly
        {
            get { return privateFindEbayItemData.AuctionOnly; }
            set { privateFindEbayItemData.AuctionOnly = value; OnPropertyChanged(); }
        }
        public string BuyItNowOnly
        {
            get { return privateFindEbayItemData.BuyItNowOnly; }
            set { privateFindEbayItemData.BuyItNowOnly = value; OnPropertyChanged(); }
        }
        public string PaymentMethod
        {
            get { return privateFindEbayItemData.PaymentMethod; }
            set { privateFindEbayItemData.PaymentMethod = value; OnPropertyChanged(); }
        }
        public string MinQuantity
        {
            get { return privateFindEbayItemData.MinQuantity; }
            set { privateFindEbayItemData.MinQuantity = value; OnPropertyChanged(); }
        }
        public string MaxQuantity
        {
            get { return privateFindEbayItemData.MaxQuantity; }
            set { privateFindEbayItemData.MaxQuantity = value; OnPropertyChanged(); }
        }
        public string ListingType
        {
            get { return privateFindEbayItemData.ListingType; }
            set { privateFindEbayItemData.ListingType = value; OnPropertyChanged(); }
        }
        public string Currency
        {
            get { return privateFindEbayItemData.Currency; }
            set { privateFindEbayItemData.Currency = value; OnPropertyChanged(); }
        }
        public string ReturnsAcceptedOnly
        {
            get { return privateFindEbayItemData.ReturnsAcceptedOnly; }
            set { privateFindEbayItemData.ReturnsAcceptedOnly = value; OnPropertyChanged(); }
        }
        public string FreeShippingOnly
        {
            get { return privateFindEbayItemData.FreeShippingOnly; }
            set { privateFindEbayItemData.FreeShippingOnly = value; OnPropertyChanged(); }
        }
        public string ExpeditedShippingType
        {
            get { return privateFindEbayItemData.ExpeditedShippingType; }
            set { privateFindEbayItemData.ExpeditedShippingType = value; OnPropertyChanged(); }
        }
        public string EndTimeTo
        {
            get { return privateFindEbayItemData.EndTimeTo; }
            set { privateFindEbayItemData.EndTimeTo = value; OnPropertyChanged(); }
        }
        public string EndTimeFrom
        {
            get { return privateFindEbayItemData.EndTimeFrom; }
            set { privateFindEbayItemData.EndTimeFrom = value; OnPropertyChanged(); }
        }
        public string TopRatedSellerOnly
        {
            get { return privateFindEbayItemData.TopRatedSellerOnly; }
            set { privateFindEbayItemData.TopRatedSellerOnly = value; OnPropertyChanged(); }
        }
        public string MaxHandlingTime
        {
            get { return privateFindEbayItemData.MaxHandlingTime; }
            set { privateFindEbayItemData.MaxHandlingTime = value; OnPropertyChanged(); }
        }
        public string AvailableTo
        {
            get { return privateFindEbayItemData.AvailableTo; }
            set { privateFindEbayItemData.AvailableTo = value; OnPropertyChanged(); }
        }
        public string GetItFastOnly
        {
            get { return privateFindEbayItemData.GetItFastOnly; }
            set { privateFindEbayItemData.GetItFastOnly = value; OnPropertyChanged(); }
        }
        public string Seller
        {
            get { return privateFindEbayItemData.Seller; }
            set { privateFindEbayItemData.Seller = value; OnPropertyChanged(); }
        }
        public string ModTimeFrom
        {
            get { return privateFindEbayItemData.ModTimeFrom; }
            set { privateFindEbayItemData.ModTimeFrom = value; OnPropertyChanged(); }
        }
        public string LocatedIn
        {
            get { return privateFindEbayItemData.LocatedIn; }
            set { privateFindEbayItemData.LocatedIn = value; OnPropertyChanged(); }
        }
        public string ListedIn
        {
            get { return privateFindEbayItemData.ListedIn; }
            set { privateFindEbayItemData.ListedIn = value; OnPropertyChanged(); }
        }
        public string MaxDistance
        {
            get { return privateFindEbayItemData.MaxDistance; }
            set { privateFindEbayItemData.MaxDistance = value; OnPropertyChanged(); }
        }
        public string LocalPickupOnly
        {
            get { return privateFindEbayItemData.LocalPickupOnly; }
            set { privateFindEbayItemData.LocalPickupOnly = value; OnPropertyChanged(); }
        }
        public string LocalSearchOnly
        {
            get { return privateFindEbayItemData.LocalSearchOnly; }
            set { privateFindEbayItemData.LocalSearchOnly = value; OnPropertyChanged(); }
        }
        public string SellerBusinessType
        {
            get { return privateFindEbayItemData.SellerBusinessType; }
            set { privateFindEbayItemData.SellerBusinessType = value; OnPropertyChanged(); }
        }
        public string HideDuplicateItems
        {
            get { return privateFindEbayItemData.HideDuplicateItems; }
            set { privateFindEbayItemData.HideDuplicateItems = value; OnPropertyChanged(); }
        }
        public string ValueBoxInventory
        {
            get { return privateFindEbayItemData.ValueBoxInventory; }
            set { privateFindEbayItemData.ValueBoxInventory = value; OnPropertyChanged(); }
        }
        public string ExcludeAutoPay
        {
            get { return privateFindEbayItemData.ExcludeAutoPay; }
            set { privateFindEbayItemData.ExcludeAutoPay = value; OnPropertyChanged(); }
        }
        public string ExcludeCategory
        {
            get { return privateFindEbayItemData.ExcludeCategory; }
            set { privateFindEbayItemData.ExcludeCategory = value; OnPropertyChanged(); }
        }
        public string ExcludeSeller
        {
            get { return privateFindEbayItemData.ExcludeSeller; }
            set { privateFindEbayItemData.ExcludeSeller = value; OnPropertyChanged(); }
        }
        public string CharityOnly
        {
            get { return privateFindEbayItemData.CharityOnly; }
            set { privateFindEbayItemData.CharityOnly = value; OnPropertyChanged(); }
        }
    }
}
