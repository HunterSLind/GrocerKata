using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GrocerLib;

namespace GrocerTests
{
    [TestClass]
    public class GrocerTests
    {
        [TestMethod]
        public void TestPriceCheck()
        {
            Assert.AreEqual(1.99, Pricer.CheckPrice());
        }
    }
}
