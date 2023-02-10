using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbayScraperWPF
{
    public interface IItem
    {
        string? Name { get; set; }
        string? Keywords { get; set; }
        double MaxPrice { get; set; }
        double LowPrice { get; set; }
        bool Auction { get; set; }
        bool BuyNow { get; set; }
        bool Offer { get; set; }
    }
    public class EbayItem : IItem
    {
        public string? Name { get; set; }
        public string? Keywords { get; set; }
        public double MaxPrice { get; set; }
        public double LowPrice { get; set; }
        public bool Auction { get; set; }
        public bool BuyNow { get; set; }
        public bool Offer { get; set; }
    }
}
