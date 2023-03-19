using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbayScraperWPF
{
    public class FindEbayItemData
    {
        private string? itemName;
        private string? itemKeywords;

        private string? maxBids;
        private string? minBids;
        private string? maxPrice;
        private string? minPrice;
        private string? condition;
        private string? offerOnly;
        
        private string? feedbackMin;
        private string? feedbackMax;
        private string? lotsOnly;
        private string? bestOfferOnly;
        private string? auctionOnly;
        private string? buyItNowOnly;
        private string? paymentMethod;
        private string? minQuantity;
        private string? maxQuantity;
        private string? listingType;
        private string? currency;
        private string? returnsAcceptedOnly;
        private string? freeShippingOnly;
        private string? expeditedShippingType;
        private string? endTimeTo;
        private string? endTimeFrom;
        private string? topRatedSellerOnly;
        private string? maxHandlingTime;
        private string? availableTo;
        private string? getItFastOnly;

        private string? seller;
        private string? modTimeFrom;
        private string? locatedIn;
        private string? listedIn;
        private string? maxDistance;
        private string? localPickupOnly;
        private string? localSearchOnly;
        private string? sellerBusinessType;
        private string? hideDuplicateItems;
        private string? valueBoxInventory;
        private string? excludeAutoPay;
        private string? excludeCategory;
        private string? excludeSeller;
        private string? charityOnly;

        public string ItemName
        {
            get { if (!string.IsNullOrWhiteSpace(itemName)) { return itemName; } else return ""; }
            set { itemName = value; }
        }
        public string ItemKeywords
        {
            get { if (!string.IsNullOrWhiteSpace(itemKeywords)) { return itemKeywords; } else return ""; }
            set { itemKeywords = value; }
        }

        public string MaxBids
        {
            get { if (!string.IsNullOrWhiteSpace(maxBids)) { return maxBids; } else return ""; }
            set { maxBids = value; }
        }
        public string MinBids
        {
            get { if (!string.IsNullOrWhiteSpace(minBids)) { return minBids; } else return ""; }
            set { minBids = value; }
        }
        public string MaxPrice
        {
            get { if (!string.IsNullOrWhiteSpace(maxPrice)) { return maxPrice; } else return ""; }
            set { maxPrice = value; }
        }
        public string MinPrice
        {
            get { if (!string.IsNullOrWhiteSpace(minPrice)) { return minPrice; } else return ""; }
            set { minPrice = value; }
        }
        public string Condition
        {
            get { if (!string.IsNullOrWhiteSpace(condition)) { return condition; } else return ""; }
            set { condition = value; }
        }
        public string OfferOnly
        {
            get { if (!string.IsNullOrWhiteSpace(offerOnly)) { return offerOnly; } else return ""; }
            set { offerOnly = value; }
        }
        public string FeedbackMin
        {
            get { if (!string.IsNullOrWhiteSpace(feedbackMin)) { return feedbackMin; } else return ""; }
            set { feedbackMin = value; }
        }
        public string FeedbackMax
        {
            get { if (!string.IsNullOrWhiteSpace(feedbackMax)) { return feedbackMax; } else return ""; }
            set { feedbackMax = value; }
        }
        public string LotsOnly
        {
            get { if (!string.IsNullOrWhiteSpace(lotsOnly)) { return lotsOnly; } else return ""; }
            set { lotsOnly = value; }
        }
        public string BestOfferOnly
        {
            get { if (!string.IsNullOrWhiteSpace(bestOfferOnly)) { return bestOfferOnly; } else return ""; }
            set { bestOfferOnly = value; }
        }
        public string AuctionOnly
        {
            get { if (!string.IsNullOrWhiteSpace(auctionOnly)) { return auctionOnly; } else return ""; }
            set { auctionOnly = value; }
        }
        public string BuyItNowOnly
        {
            get { if (!string.IsNullOrWhiteSpace(buyItNowOnly)) { return buyItNowOnly; } else return ""; }
            set { buyItNowOnly = value; }
        }
        public string PaymentMethod
        {
            get { if (!string.IsNullOrWhiteSpace(paymentMethod)) { return paymentMethod; } else return ""; }
            set { paymentMethod = value; }
        }
        public string MinQuantity
        {
            get { if (!string.IsNullOrWhiteSpace(minQuantity)) { return minQuantity; } else return ""; }
            set { minQuantity = value; }
        }
        public string MaxQuantity
        {
            get { if (!string.IsNullOrWhiteSpace(maxQuantity)) { return maxQuantity; } else return ""; }
            set { maxQuantity = value; }
        }
        public string ListingType
        {
            get { if (!string.IsNullOrWhiteSpace(listingType)) { return listingType; } else return ""; }
            set { listingType = value; }
        }
        public string Currency
        {
            get { if (!string.IsNullOrWhiteSpace(currency)) { return currency; } else return ""; }
            set { currency = value; }
        }
        public string ReturnsAcceptedOnly
        {
            get { if (!string.IsNullOrWhiteSpace(returnsAcceptedOnly)) { return returnsAcceptedOnly; } else return ""; }
            set { returnsAcceptedOnly = value; }
        }
        public string FreeShippingOnly
        {
            get { if (!string.IsNullOrWhiteSpace(freeShippingOnly)) { return freeShippingOnly; } else return ""; }
            set { freeShippingOnly = value; }
        }
        public string ExpeditedShippingType
        {
            get { if (!string.IsNullOrWhiteSpace(expeditedShippingType)) { return expeditedShippingType; } else return ""; }
            set { expeditedShippingType = value; }
        }
        public string EndTimeTo
        {
            get { if (!string.IsNullOrWhiteSpace(endTimeTo)) { return endTimeTo; } else return ""; }
            set { endTimeTo = value; }
        }
        public string EndTimeFrom
        {
            get { if (!string.IsNullOrWhiteSpace(endTimeFrom)) { return endTimeFrom; } else return ""; }
            set { endTimeFrom = value; }
        }
        public string TopRatedSellerOnly
        {
            get { if (!string.IsNullOrWhiteSpace(topRatedSellerOnly)) { return topRatedSellerOnly; } else return ""; }
            set { topRatedSellerOnly = value; }
        }
        public string MaxHandlingTime
        {
            get { if (!string.IsNullOrWhiteSpace(maxHandlingTime)) { return maxHandlingTime; } else return ""; }
            set { maxHandlingTime = value; }
        }
        public string AvailableTo
        {
            get { if (!string.IsNullOrWhiteSpace(availableTo)) { return availableTo; } else return ""; }
            set { availableTo = value; }
        }
        public string GetItFastOnly
        {
            get { if (!string.IsNullOrWhiteSpace(getItFastOnly)) { return getItFastOnly; } else return ""; }
            set { getItFastOnly = value; }
        }
        public string Seller
        {
            get { if (!string.IsNullOrWhiteSpace(seller)) { return seller; } else return ""; }
            set { seller = value; }
        }
        public string ModTimeFrom
        {
            get { if (!string.IsNullOrWhiteSpace(modTimeFrom)) { return modTimeFrom; } else return ""; }
            set { modTimeFrom = value; }
        }
        public string LocatedIn
        {
            get { if (!string.IsNullOrWhiteSpace(locatedIn)) { return locatedIn; } else return ""; }
            set { locatedIn = value; }
        }
        public string ListedIn
        {
            get { if (!string.IsNullOrWhiteSpace(listedIn)) { return listedIn; } else return ""; }
            set { listedIn = value; }
        }
        public string MaxDistance
        {
            get { if (!string.IsNullOrWhiteSpace(maxDistance)) { return maxDistance; } else return ""; }
            set { maxDistance = value; }
        }
        public string LocalPickupOnly
        {
            get { if (!string.IsNullOrWhiteSpace(localPickupOnly)) { return localPickupOnly; } else return ""; }
            set { localPickupOnly = value; }
        }
        public string LocalSearchOnly
        {
            get { if (!string.IsNullOrWhiteSpace(localSearchOnly)) { return localSearchOnly; } else return ""; }
            set { localSearchOnly = value; }
        }
        public string SellerBusinessType
        {
            get { if (!string.IsNullOrWhiteSpace(sellerBusinessType)) { return sellerBusinessType; } else return ""; }
            set { sellerBusinessType = value; }
        }
        public string HideDuplicateItems
        {
            get { if (!string.IsNullOrWhiteSpace(hideDuplicateItems)) { return hideDuplicateItems; } else return ""; }
            set { hideDuplicateItems = value; }
        }
        public string ValueBoxInventory
        {
            get { if (!string.IsNullOrWhiteSpace(valueBoxInventory)) { return valueBoxInventory; } else return ""; }
            set { valueBoxInventory = value; }
        }
        public string ExcludeAutoPay
        {
            get { if (!string.IsNullOrWhiteSpace(excludeAutoPay)) { return excludeAutoPay; } else return ""; }
            set { excludeAutoPay = value; }
        }
        public string ExcludeCategory
        {
            get { if (!string.IsNullOrWhiteSpace(excludeCategory)) { return excludeCategory; } else return ""; }
            set { excludeCategory = value; }
        }
        public string ExcludeSeller
        {
            get { if (!string.IsNullOrWhiteSpace(excludeSeller)) { return excludeSeller; } else return ""; }
            set { excludeSeller = value; }
        }
        public string CharityOnly
        {
            get { if (!string.IsNullOrWhiteSpace(charityOnly)) { return charityOnly; } else return ""; }
            set { charityOnly = value; }
        }
    }
}
