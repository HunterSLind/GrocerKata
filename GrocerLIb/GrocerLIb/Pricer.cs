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
            switch(itemName)
            {
                default:
                    return 0.00M;
            }
        }
    }
}
