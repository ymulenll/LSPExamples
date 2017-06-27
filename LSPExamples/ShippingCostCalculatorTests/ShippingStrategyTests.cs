using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShippingCostCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingCostCalculatorTests
{
    [TestClass]
    public class ShippingStrategyTests
    {
        private ShippingStrategy strategy;

        [TestInitialize]
        public void SetUp()
        {
            this.strategy = new ShippingStrategy(1m);
        }

        [TestMethod]
        public void ShippingWeightMustBePositive()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => strategy.CalculateShippingCost(-1, null));
        }

        [TestMethod]
        public void ShippingWeightMustBeNonZero()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => strategy.CalculateShippingCost(0, null));
        }

        [TestMethod]
        public void ShippingCostMustBePositiveAndNonZero()
        {
            var shippingCost = strategy.CalculateShippingCost(1f, null);
            Assert.IsTrue(shippingCost > 0);
        }

        [TestMethod]
        public void ShippingFlatRateMustBePositive()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => new ShippingStrategy(decimal.MinusOne));
        }

        [TestMethod]
        public void ShippingFlatRateMustBeNonZero()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(
               () => new ShippingStrategy(decimal.Zero));
        }


    }
}