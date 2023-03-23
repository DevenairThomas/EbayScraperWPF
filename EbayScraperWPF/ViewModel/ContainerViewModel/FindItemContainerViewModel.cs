using EbayScraperWPF.CommandEvents;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EbayScraperWPF.ViewModel.ContainerViewModel
{
    public class FindItemContainerViewModel : ViewModelBase
    {
        //Object to hold the Current Viewed Data Item
        private FindEbayItemData? privateFindEbayItemData;
        /// <summary>
        /// Methoda <c>All the FindEbayItem Properties</c> All accessors for the FindEbayItemData model
        /// </summary>
        //If Checkboxes needs to be reworked start here and inside the FindEbayItemsData class

        private bool bOfferOnly = false;
        private bool bBuyNowOnly = false;
        private bool bAuctiopnOnly = false;
        private bool bLotsOnly = false;
        private bool bGetItFastOnly = false;
        private bool bTopRatesdSellerOnly = false;
        private bool bReturnsAcceptedOnly = false;
        private bool bFreeShippingOnly = false;
        private bool bOneDayShippingOnly = false;


        public FindItemContainerViewModel()
        {
            privateFindEbayItemData = new FindEbayItemData();
            //All of the Commands attached to the set CheckBox Params to alter the value to false
            //The value needs to be a string because when its sent to the bot for processing 
            //The value inputted into the bot will be a string and I want to create the least amount of friction possible before
            //The bot scrapes the data from the Ebay page
            chkOfferOnly = new RelayCommand(() => setOfferOnly());
            chkBuyNowOnly = new RelayCommand(() => setBuyNowOnly());
            chkAuctionOnly = new RelayCommand(() => setAuctiopnOnly());
            chkLotsOnly = new RelayCommand(() => setLotsOnly());
            chkGetItFastOnly = new RelayCommand(() => setGetItFastOnly());
            chkTopRatesdSellerOnly = new RelayCommand(() => setTopRatesdSellerOnly());
            chkReturnsAcceptedOnly = new RelayCommand(() => setReturnsAcceptedOnly());
            chkFreeShippingOnly = new RelayCommand(() => setFreeShippingOnly());
            chkOneDayShippingOnly = new RelayCommand(() => setOneDayShippingOnly());
            chkHideDuplicateItems = new RelayCommand(() => setOfferOnly());
            chkExcludeAutoPay = new RelayCommand(() => setBuyNowOnly());
            chkValueBoxInventory = new RelayCommand(() => setAuctiopnOnly());
            chkCharityOnly = new RelayCommand(() => setLotsOnly());
            chkTopRatedSellerOnly = new RelayCommand(() => setGetItFastOnly());
            chkExpeditedShippingType = new RelayCommand(() => setTopRatesdSellerOnly());
        }

        //Check Boxes... dont work as intendedS
        public ICommand chkOfferOnly { get; set; }
        public ICommand chkBuyNowOnly { get; set; }
        public ICommand chkAuctionOnly { get; set; }
        public ICommand chkLotsOnly { get; set; }
        public ICommand chkGetItFastOnly { get; set; }
        public ICommand chkTopRatesdSellerOnly { get; set; }
        public ICommand chkReturnsAcceptedOnly { get; set; }
        public ICommand chkFreeShippingOnly { get; set; }
        public ICommand chkOneDayShippingOnly { get; set; }
        //
        public ICommand chkHideDuplicateItems { get; set; }
        public ICommand chkExcludeAutoPay { get; set; }
        public ICommand chkValueBoxInventory { get; set; }
        public ICommand chkCharityOnly { get; set; }
        public ICommand chkTopRatedSellerOnly { get; set; }
        public ICommand chkExpeditedShippingType { get; set; }

        //Supposed to be for setting check box parameters doesnt work is a 
        //TODO list item and probably needs to be completely reworked from  the 
        //Model itself
        public void setOfferOnly() { bOfferOnly = !bOfferOnly; }
        public void setBuyNowOnly() { bBuyNowOnly = !bBuyNowOnly; }
        public void setAuctiopnOnly() { bAuctiopnOnly = !bAuctiopnOnly; }
        public void setLotsOnly() { bLotsOnly = !bLotsOnly; }
        public void setGetItFastOnly() { bGetItFastOnly = !bGetItFastOnly; }
        public void setTopRatesdSellerOnly() { bTopRatesdSellerOnly = !bTopRatesdSellerOnly; }
        public void setReturnsAcceptedOnly() { bReturnsAcceptedOnly = !bReturnsAcceptedOnly; }
        public void setFreeShippingOnly() { bFreeShippingOnly = !bFreeShippingOnly; }
        public void setOneDayShippingOnly() { bOneDayShippingOnly = !bOneDayShippingOnly; }
        public void setHideDuplicateItems() { bOfferOnly = !bOfferOnly; }
        public void setExcludeAutoPay() { bBuyNowOnly = !bBuyNowOnly; }
        public void setValueboxInventory() { bAuctiopnOnly = !bAuctiopnOnly; }
        public void setCharityOnly() { bLotsOnly = !bLotsOnly; }
        public void setTopRatedSellerOnly() { bGetItFastOnly = !bGetItFastOnly; }
        public void setExpeditedShippingType() { bTopRatesdSellerOnly = !bTopRatesdSellerOnly; }

        public FindEbayItemData FindEbayItemData
        {
            get { return privateFindEbayItemData; }
            set { privateFindEbayItemData = value; OnPropertyChanged(); }
        }

        public string ItemName
        {
            get { if (!string.IsNullOrWhiteSpace(privateFindEbayItemData.ItemName)) { return privateFindEbayItemData.ItemName; } else return ""; }
            set { privateFindEbayItemData.ItemName = value; OnPropertyChanged(); }
        }
        public string ItemKeywords
        {
            get { if (!string.IsNullOrWhiteSpace(privateFindEbayItemData.ItemKeywords)) { return privateFindEbayItemData.ItemKeywords; } else return ""; }
            set { privateFindEbayItemData.ItemKeywords = value; OnPropertyChanged(); }
        }
        public string MaxBids
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(privateFindEbayItemData.MaxBids)) { return privateFindEbayItemData.MaxBids; } else return "";
            }
            set { privateFindEbayItemData.MaxBids = value; OnPropertyChanged(); }
        }
        public string MinBids
        {
            get { if (!string.IsNullOrWhiteSpace(privateFindEbayItemData.MinBids)) { return privateFindEbayItemData.MinBids; } else return ""; }
            set { privateFindEbayItemData.MinBids = value; OnPropertyChanged(); }
        }
        public string MaxPrice
        {
            get { if (!string.IsNullOrWhiteSpace(privateFindEbayItemData.MaxPrice)) { return privateFindEbayItemData.MaxPrice; } else return ""; }
            set { privateFindEbayItemData.MaxPrice = value; OnPropertyChanged(); }
        }
        public string MinPrice
        {
            get { if (!string.IsNullOrWhiteSpace(privateFindEbayItemData.MinPrice)) { return privateFindEbayItemData.MinPrice; } else return ""; }
            set { privateFindEbayItemData.MinPrice = value; OnPropertyChanged(); }
        }
        public string Condition
        {
            get { if (!string.IsNullOrWhiteSpace(privateFindEbayItemData.Condition)) { return privateFindEbayItemData.Condition; } else return ""; }
            set { privateFindEbayItemData.Condition = value; OnPropertyChanged(); }
        }
        public string OfferOnly
        {
            get { if (!string.IsNullOrWhiteSpace(privateFindEbayItemData.OfferOnly)) { return privateFindEbayItemData.OfferOnly; } else return ""; }
            set { privateFindEbayItemData.OfferOnly = value; OnPropertyChanged(); }
        }
        public string FeedbackMin
        {
            get { if (!string.IsNullOrWhiteSpace(privateFindEbayItemData.FeedbackMin)) { return privateFindEbayItemData.FeedbackMin; } else return ""; }
            set { privateFindEbayItemData.FeedbackMin = value; OnPropertyChanged(); }
        }
        public string FeedbackMax
        {
            get { if (!string.IsNullOrWhiteSpace(privateFindEbayItemData.FeedbackMax)) { return privateFindEbayItemData.FeedbackMax; } else return ""; }
            set { privateFindEbayItemData.FeedbackMax = value; OnPropertyChanged(); }
        }
        public string LotsOnly
        {
            get { if (!string.IsNullOrWhiteSpace(privateFindEbayItemData.LotsOnly)) { return privateFindEbayItemData.LotsOnly; } else return ""; }
            set { privateFindEbayItemData.LotsOnly = value; OnPropertyChanged(); }
        }
        public string BestOfferOnly
        {
            get { if (!string.IsNullOrWhiteSpace(privateFindEbayItemData.BestOfferOnly)) { return privateFindEbayItemData.BestOfferOnly; } else return ""; }
            set { privateFindEbayItemData.BestOfferOnly = value; OnPropertyChanged(); }
        }
        public string AuctionOnly
        {
            get { if (!string.IsNullOrWhiteSpace(privateFindEbayItemData.AuctionOnly)) { return privateFindEbayItemData.AuctionOnly; } else return ""; }
            set { privateFindEbayItemData.AuctionOnly = value; OnPropertyChanged(); }
        }
        public string BuyItNowOnly
        {
            get { if (!string.IsNullOrWhiteSpace(privateFindEbayItemData.BuyItNowOnly)) { return privateFindEbayItemData.BuyItNowOnly; } else return ""; }
            set { privateFindEbayItemData.BuyItNowOnly = value; OnPropertyChanged(); }
        }
        public string PaymentMethod
        {
            get { if (!string.IsNullOrWhiteSpace(privateFindEbayItemData.PaymentMethod)) { return privateFindEbayItemData.PaymentMethod; } else return ""; }
            set { privateFindEbayItemData.PaymentMethod = value; OnPropertyChanged(); }
        }
        public string MinQuantity
        {
            get { if (!string.IsNullOrWhiteSpace(privateFindEbayItemData.MinQuantity)) { return privateFindEbayItemData.MinQuantity; } else return ""; }
            set { privateFindEbayItemData.MinQuantity = value; OnPropertyChanged(); }
        }
        public string MaxQuantity
        {
            get { if (!string.IsNullOrWhiteSpace(privateFindEbayItemData.MaxQuantity)) { return privateFindEbayItemData.MaxQuantity; } else return ""; }
            set { privateFindEbayItemData.MaxQuantity = value; OnPropertyChanged(); }
        }
        public string ListingType
        {
            get { if (!string.IsNullOrWhiteSpace(privateFindEbayItemData.ListingType)) { return privateFindEbayItemData.ListingType; } else return ""; }
            set { privateFindEbayItemData.ListingType = value; OnPropertyChanged(); }
        }
        public string Currency
        {
            get { if (!string.IsNullOrWhiteSpace(privateFindEbayItemData.Currency)) { return privateFindEbayItemData.Currency; } else return ""; }
            set { privateFindEbayItemData.Currency = value; OnPropertyChanged(); }
        }
        public string ReturnsAcceptedOnly
        {
            get { if (!string.IsNullOrWhiteSpace(privateFindEbayItemData.ReturnsAcceptedOnly)) { return privateFindEbayItemData.ReturnsAcceptedOnly; } else return ""; }
            set { privateFindEbayItemData.ReturnsAcceptedOnly = value; OnPropertyChanged(); }
        }
        public string FreeShippingOnly
        {
            get { if (!string.IsNullOrWhiteSpace(privateFindEbayItemData.FreeShippingOnly)) { return privateFindEbayItemData.FreeShippingOnly; } else return ""; }
            set { privateFindEbayItemData.FreeShippingOnly = value; OnPropertyChanged(); }
        }
        public string ExpeditedShippingType
        {
            get { if (!string.IsNullOrWhiteSpace(privateFindEbayItemData.ExpeditedShippingType)) { return privateFindEbayItemData.ExpeditedShippingType; } else return ""; }
            set { privateFindEbayItemData.ExpeditedShippingType = value; OnPropertyChanged(); }
        }
        //
        public string EndTimeTo
        {
            get { if (!string.IsNullOrWhiteSpace(privateFindEbayItemData.EndTimeTo)) { return privateFindEbayItemData.EndTimeTo; } else return ""; }
            set { privateFindEbayItemData.EndTimeTo = value; OnPropertyChanged(); }
        }
        public string EndTimeFrom
        {
            get { if (!string.IsNullOrWhiteSpace(privateFindEbayItemData.EndTimeFrom)) { return privateFindEbayItemData.EndTimeFrom; } else return ""; }
            set { privateFindEbayItemData.EndTimeFrom = value; OnPropertyChanged(); }
        }
        public string TopRatedSellerOnly
        {
            get { if (!string.IsNullOrWhiteSpace(privateFindEbayItemData.TopRatedSellerOnly)) { return privateFindEbayItemData.TopRatedSellerOnly; } else return ""; }
            set { privateFindEbayItemData.TopRatedSellerOnly = value; OnPropertyChanged(); }
        }
        public string MaxHandlingTime
        {
            get { if (!string.IsNullOrWhiteSpace(privateFindEbayItemData.MaxHandlingTime)) { return privateFindEbayItemData.MaxHandlingTime; } else return ""; }
            set { privateFindEbayItemData.MaxHandlingTime = value; OnPropertyChanged(); }
        }
        public string AvailableTo
        {
            get { if (!string.IsNullOrWhiteSpace(privateFindEbayItemData.AvailableTo)) { return privateFindEbayItemData.AvailableTo; } else return ""; }
            set { privateFindEbayItemData.AvailableTo = value; OnPropertyChanged(); }
        }
        public string GetItFastOnly
        {
            get { if (!string.IsNullOrWhiteSpace(privateFindEbayItemData.GetItFastOnly)) { return privateFindEbayItemData.GetItFastOnly; } else return ""; }
            set { privateFindEbayItemData.GetItFastOnly = value; OnPropertyChanged(); }
        }
        public string SellerName
        {
            get { if (!string.IsNullOrWhiteSpace(privateFindEbayItemData.SellerName)) { return privateFindEbayItemData.SellerName; } else return ""; }
            set { privateFindEbayItemData.SellerName = value; OnPropertyChanged(); }
        }
        public string ModTimeFrom
        {
            get { if (!string.IsNullOrWhiteSpace(privateFindEbayItemData.ModTimeFrom)) { return privateFindEbayItemData.ModTimeFrom; } else return ""; }
            set { privateFindEbayItemData.ModTimeFrom = value; OnPropertyChanged(); }
        }
        public string LocatedIn
        {
            get { if (!string.IsNullOrWhiteSpace(privateFindEbayItemData.LocatedIn)) { return privateFindEbayItemData.LocatedIn; } else return ""; }
            set { privateFindEbayItemData.LocatedIn = value; OnPropertyChanged(); }
        }
        public string ListedIn
        {
            get { if (!string.IsNullOrWhiteSpace(privateFindEbayItemData.ListedIn)) { return privateFindEbayItemData.ListedIn; } else return ""; }
            set { privateFindEbayItemData.ListedIn = value; OnPropertyChanged(); }
        }
        public string MaxDistance
        {
            get { if (!string.IsNullOrWhiteSpace(privateFindEbayItemData.MaxDistance)) { return privateFindEbayItemData.MaxDistance; } else return ""; }
            set { privateFindEbayItemData.MaxDistance = value; OnPropertyChanged(); }
        }
        public string LocalPickupOnly
        {
            get { if (!string.IsNullOrWhiteSpace(privateFindEbayItemData.LocalPickupOnly)) { return privateFindEbayItemData.LocalPickupOnly; } else return ""; }
            set { privateFindEbayItemData.LocalPickupOnly = value; OnPropertyChanged(); }
        }
        public string LocalSearchOnly
        {
            get { if (!string.IsNullOrWhiteSpace(privateFindEbayItemData.LocalSearchOnly)) { return privateFindEbayItemData.LocalSearchOnly; } else return ""; }
            set { privateFindEbayItemData.LocalSearchOnly = value; OnPropertyChanged(); }
        }
        public string SellerBusinessType
        {
            get { if (!string.IsNullOrWhiteSpace(privateFindEbayItemData.SellerBusinessType)) { return privateFindEbayItemData.SellerBusinessType; } else return ""; }
            set { privateFindEbayItemData.SellerBusinessType = value; OnPropertyChanged(); }
        }
        public string HideDuplicateItems
        {
            get { if (!string.IsNullOrWhiteSpace(privateFindEbayItemData.HideDuplicateItems)) { return privateFindEbayItemData.HideDuplicateItems; } else return ""; }
            set { privateFindEbayItemData.HideDuplicateItems = value; OnPropertyChanged(); }
        }
        public string ValueBoxInventory
        {
            get { if (!string.IsNullOrWhiteSpace(privateFindEbayItemData.ValueBoxInventory)) { return privateFindEbayItemData.ValueBoxInventory; } else return ""; }
            set { privateFindEbayItemData.ValueBoxInventory = value; OnPropertyChanged(); }
        }
        public string ExcludeAutoPay
        {
            get { if (!string.IsNullOrWhiteSpace(privateFindEbayItemData.ExcludeAutoPay)) { return privateFindEbayItemData.ExcludeAutoPay; } else return ""; }
            set { privateFindEbayItemData.ExcludeAutoPay = value; OnPropertyChanged(); }
        }
        public string ExcludeCategory
        {
            get { if (!string.IsNullOrWhiteSpace(privateFindEbayItemData.ExcludeCategory)) { return privateFindEbayItemData.ExcludeCategory; } else return ""; }
            set { privateFindEbayItemData.ExcludeCategory = value; OnPropertyChanged(); }
        }
        public string ExcludeSeller
        {
            get { if (!string.IsNullOrWhiteSpace(privateFindEbayItemData.ExcludeSeller)) { return privateFindEbayItemData.ExcludeSeller; } else return ""; }
            set { privateFindEbayItemData.ExcludeSeller = value; OnPropertyChanged(); }
        }
        public string CharityOnly
        {
            get { if (!string.IsNullOrWhiteSpace(privateFindEbayItemData.CharityOnly)) { return privateFindEbayItemData.CharityOnly; } else return ""; }
            set { privateFindEbayItemData.CharityOnly = value; OnPropertyChanged(); }
        }
    }
}
