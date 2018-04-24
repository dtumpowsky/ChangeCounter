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

            Assert.AreEqual(0.20m, testChangeCounter.CalculateChange(0.95m));
        }
    }
}
