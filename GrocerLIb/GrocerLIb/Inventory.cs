using System;
using System.Collections.Generic;
using System.Text;

namespace GrocerLib
{
    public static class Inventory
    {
        public static Dictionary<string, decimal> ItemPriceDictionary = new Dictionary<string, decimal>
        {
            {"", -1 },
            {"HotDog", 1.99M }
        };
    }
}
