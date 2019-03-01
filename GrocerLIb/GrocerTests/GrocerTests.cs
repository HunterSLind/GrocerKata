using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GrocerLib;

namespace GrocerTests
{
    [TestClass]
    public class GrocerTests
    {

        Pricer pricer = new Pricer();
        [TestMethod]
        public void TestPriceCheck()
        {
            Assert.AreEqual(1.99M, Pricer.CheckPrice());
        }

        [TestMethod]
        public void TestItemPriceByName()
        {
            Assert.AreEqual(1.99M, pricer.CheckPrice("HotDog"));
        }

        [TestMethod]
        public void TestItemPriceWithEmptyName()
        {
            Assert.AreEqual(-1, pricer.CheckPrice(""));
        }

        [TestMethod]
        public void TestItemPriceWithBadItemName()
        {
            Assert.AreEqual(-1, pricer.CheckPrice("I'm not an Item"));
        }

        [TestMethod]
        public void TestSetNewItemPrice()
        {
            Assert.AreEqual(true, pricer.SetNewItemPrice("Apple", 0.99M));
        }
    }
}
