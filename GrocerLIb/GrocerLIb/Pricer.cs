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
            if(itemPriceDictionary.ContainsKey(itemName))
            {
                return itemPriceDictionary[itemName];
            }
            return -1;
        }

        public bool SetNewItemPrice(string itemName, decimal price)
        {
            return false;
        }

        private Dictionary<string, decimal> itemPriceDictionary = new Dictionary<string, decimal>
        {
            {"", -1 },
            {"HotDog", 1.99M }
        };

        
    }
}
