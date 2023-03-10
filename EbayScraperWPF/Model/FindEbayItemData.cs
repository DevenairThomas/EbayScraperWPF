using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbayScraperWPF
{
    internal class FindEbayItemData
    {
        private string itemName;
        private string itemKeywords;

        private string maxBids;
        private string minBids;
        private string maxPrice;
        private string minPrice;
        private string condition;
        private string offerOnly;
        
        private string feedbackMin;
        private string feedbackMax;
        private string lotsOnly;
        private string bestOfferOnly;
        private string auctionOnly;
        private string buyItNowOnly;
        private string paymentMethod;
        private string minQuantity;
        private string maxQuantity;
        private string listingType;
        private string currency;
        private string returnsAcceptedOnly;
        private string freeShippingOnly;
        private string expeditedShippingType;
        private string endTimeTo;
        private string endTimeFrom;
        private string topRatedSellerOnly;
        private string maxHandlingTime;
        private string availableTo;
        private string getItFastOnly;

        private string seller;
        private string modTimeFrom;
        private string locatedIn;
        private string listedIn;
        private string maxDistance;
        private string localPickupOnly;
        private string localSearchOnly;
        private string sellerBusinessType;
        private string hideDuplicateItems;
        private string valueBoxInventory;
        private string excludeAutoPay;
        private string excludeCategory;
        private string excludeSeller;
        private string charityOnly;

        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; }
        }
        public string ItemKeywords
        {
            get { return itemKeywords; }
            set { itemKeywords = value; }
        }
        public string MaxBids
        {
            get { return maxBids; }
            set { maxBids = value; }
        }
        public string MinBids
        {
            get { return minBids; }
            set { minBids = value; }
        }
        public string MaxPrice
        {
            get { return maxPrice; }
            set { maxPrice = value; }
        }
        public string MinPrice
        {
            get { return minPrice; }
            set { minPrice = value; }
        }
        public string Condition
        {
            get { return condition; }
            set { condition = value; }
        }
        public string OfferOnly
        {
            get { return offerOnly; }
            set { offerOnly = value; }
        }
        public string FeedbackMin
        {
            get { return feedbackMin; }
            set { feedbackMin = value; }
        }
        public string FeedbackMax
        {
            get { return feedbackMax; }
            set { feedbackMax = value; }
        }
        public string LotsOnly
        {
            get { return lotsOnly; }
            set { lotsOnly = value; }
        }
        public string BestOfferOnly
        {
            get { return bestOfferOnly; }
            set { bestOfferOnly = value; }
        }
        public string AuctionOnly
        {
            get { return auctionOnly; }
            set { auctionOnly = value; }
        }
        public string BuyItNowOnly
        {
            get { return buyItNowOnly; }
            set { buyItNowOnly = value; }
        }
        public string PaymentMethod
        {
            get { return paymentMethod; }
            set { paymentMethod = value; }
        }
        public string MinQuantity
        {
            get { return minQuantity; }
            set { minQuantity = value; }
        }
        public string MaxQuantity
        {
            get { return maxQuantity; }
            set { maxQuantity = value; }
        }
        public string ListingType
        {
            get { return listingType; }
            set { listingType = value; }
        }
        public string Currency
        {
            get { return currency; }
            set { currency = value; }
        }
        public string ReturnsAcceptedOnly
        {
            get { return returnsAcceptedOnly; }
            set { returnsAcceptedOnly = value; }
        }
        public string FreeShippingOnly
        {
            get { return freeShippingOnly; }
            set { freeShippingOnly = value; }
        }
        public string ExpeditedShippingType
        {
            get { return expeditedShippingType; }
            set { expeditedShippingType = value; }
        }
        public string EndTimeTo
        {
            get { return endTimeTo; }
            set { endTimeTo = value; }
        }
        public string EndTimeFrom
        {
            get { return endTimeFrom; }
            set { endTimeFrom = value; }
        }
        public string TopRatedSellerOnly
        {
            get { return topRatedSellerOnly; }
            set { topRatedSellerOnly = value; }
        }
        public string MaxHandlingTime
        {
            get { return maxHandlingTime; }
            set { maxHandlingTime = value; }
        }
        public string AvailableTo
        {
            get { return availableTo; }
            set { availableTo = value; }
        }
        public string GetItFastOnly
        {
            get { return getItFastOnly; }
            set { getItFastOnly = value; }
        }
        public string Seller
        {
            get { return seller; }
            set { seller = value; }
        }
        public string ModTimeFrom
        {
            get { return modTimeFrom; }
            set { modTimeFrom = value; }
        }
        public string LocatedIn
        {
            get { return locatedIn; }
            set { locatedIn = value; }
        }
        public string ListedIn
        {
            get { return listedIn; }
            set { listedIn = value; }
        }
        public string MaxDistance
        {
            get { return maxDistance; }
            set { maxDistance = value; }
        }
        public string LocalPickupOnly
        {
            get { return localPickupOnly; }
            set { localPickupOnly = value; }
        }
        public string LocalSearchOnly
        {
            get { return localSearchOnly; }
            set { localSearchOnly = value; }
        }
        public string SellerBusinessType
        {
            get { return sellerBusinessType; }
            set { sellerBusinessType = value; }
        }
        public string HideDuplicateItems
        {
            get { return hideDuplicateItems; }
            set { hideDuplicateItems = value; }
        }
        public string ValueBoxInventory
        {
            get { return valueBoxInventory; }
            set { valueBoxInventory = value; }
        }
        public string ExcludeAutoPay
        {
            get { return excludeAutoPay; }
            set { excludeAutoPay = value; }
        }
        public string ExcludeCategory
        {
            get { return excludeCategory; }
            set { excludeCategory = value; }
        }
        public string ExcludeSeller
        {
            get { return excludeSeller; }
            set { excludeSeller = value; }
        }
        public string CharityOnly
        {
            get { return charityOnly; }
            set { charityOnly = value; }
        }
    }
}
