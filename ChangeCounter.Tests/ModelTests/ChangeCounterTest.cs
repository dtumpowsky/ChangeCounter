using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoinApp.Models;
using System.Collections.Generic;
using System;

namespace CoinApp.Tests
{
    [TestClass]
    public class ChangeTests
    {

        [TestMethod]
        public void CountChange_ReturnQuarterChange_Decimal()
        {
            Change testChangeCounter = new Change(0.95m);

            Assert.AreEqual(0.20m, testChangeCounter.ChangeAfterQuarters(0.95m));
        }

        [TestMethod]
        public void CountChange_ReturnDimeChange_Decimal()
        {
            Change testChangeCounter = new Change(0.0m, 0.15m);

            Assert.AreEqual(0.05m, testChangeCounter.ChangeAfterDimes(0.15m));
        }
    }
}
