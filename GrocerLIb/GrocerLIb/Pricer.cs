using System;
using System.Collections.Generic;

namespace GrocerLib
{
    public class Pricer
    {
        public static decimal CheckPrice()
        {
            return 1.99M;
        }

        public decimal CheckPrice(string itemName)
        {
            return itemPriceDictionary[itemName];
        }

        private Dictionary<string, decimal> itemPriceDictionary = new Dictionary<string, decimal>
        {
            {"HotDog", 1.99M }
        };
    }
}
