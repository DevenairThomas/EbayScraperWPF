using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbayScraperWPF
{
    public class Keywords
    {
        public void putKeyWords(List<string> KeywordsList, string allKeywords)
        {
            int len = allKeywords.Length;
            string key;
            int j = 0;
            for (int i = 0; i < len; i++)
            {
                if (allKeywords[i] == ',')
                {
                    key = allKeywords.Substring(j, i - 1);
                    KeywordsList.Add(key);
                    j = i;
                }
            }
        }
    }
    public interface IItem
    {
        string? Name { get; set; }
        public List<string> KeywordsList { get; set; }
        double MaxPrice { get; set; }
        double LowPrice { get; set; }
        bool Auction { get; set; }
        bool BuyNow { get; set; }
        bool Offer { get; set; }
    }
    public class EbayItem : IItem
    {
        public string? Name { get; set; }
        public List<string> KeywordsList { get; set; }
        public double MaxPrice { get; set; }
        public double LowPrice { get; set; }
        public bool Auction { get; set; }
        public bool BuyNow { get; set; }
        public bool Offer { get; set; }
    }
}
