using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShippingCostCalculator;
using System.Globalization;

namespace ShippingCostCalculatorTests
{
    [TestClass]
    public class ShippingStrategyClientTests
    {
        private IEnumerable<ShippingStrategy> GetAllShippigStrategies()
        {
            return new[]
            {
                new ShippingStrategy(1m),
                // new WorldWideShippingStrategy(1m)
            };
        }

        private ShippingStrategy GetShippigStrategy(decimal flatRate)
        {
            return new ShippingStrategy(1m);
            //return new WorldWideShippingStrategy(1m);
        }        

        [TestMethod]
        public void TestPreconditions_PositiveNonZeroWeightNoExceptions()
        {
            ShippingStrategy strategy = GetShippigStrategy(1);

            var shippigCost = strategy.CalculateShippingCost(1, null);

            // use shippig cost
        }

        [TestMethod]
        public void TestPreconditionsAllStrategies_PositiveNonZeroWeightNoExceptions()
        {
            var strategies = GetAllShippigStrategies();

            foreach (var strategy in strategies)
            {
                var shippigCost = strategy.CalculateShippingCost(1, null);                
            }
        }

        [TestMethod]
        public void TestPostconditions_PositiveNonZeroOutput()
        {
            ShippingStrategy strategy = GetShippigStrategy(1);

            var shippigCost = strategy.CalculateShippingCost(1, RegionInfo.CurrentRegion);

            Assert.IsTrue(shippigCost > 0);
        }

        [TestMethod]
        public void TestPostconditionsAllStrategies_PositiveNonZeroOutput()
        {
            var strategies = GetAllShippigStrategies();

            foreach (var strategy in strategies)
            {
                var shippigCost = strategy.CalculateShippingCost(1, RegionInfo.CurrentRegion);

                Assert.IsTrue(shippigCost > 0);
            }
        }

        [TestMethod]
        public void TestInvariants_FlatRateSetToZeroShouldThrowException()
        {
            ShippingStrategy strategy = GetShippigStrategy(1);

            Action changeFlatRate = () => strategy.FlatRate = 0;

            Assert.ThrowsException<ArgumentOutOfRangeException>(changeFlatRate);
        }
    }
}
