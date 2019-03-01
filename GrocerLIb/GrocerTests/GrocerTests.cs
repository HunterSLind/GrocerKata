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
    }
}
