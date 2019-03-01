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
            if(Inventory.ItemPriceDictionary.ContainsKey(itemName))
            {
                return Inventory.ItemPriceDictionary[itemName];
            }
            return -1;
        }

        public bool SetNewItemPrice(string itemName, decimal price)
        {
            return true;
        }



        
    }
}
