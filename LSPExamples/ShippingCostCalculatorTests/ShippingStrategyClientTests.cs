using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShippingCostCalculator;

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
                new WorldWideShippingStrategy(1m)
            };
        }

        private ShippingStrategy GetShippigStrategy(decimal flatRate)
        {
            //return new ShippingStrategy(1m);
            return new WorldWideShippingStrategy(1m);
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

            var shippigCost = strategy.CalculateShippingCost(1, null);

            Assert.IsTrue(shippigCost > 0);
        }

        [TestMethod]
        public void TestPostconditionsUsingForeach_PositiveNonZeroOutput()
        {
            var strategies = GetAllShippigStrategies();

            foreach (var strategy in strategies)
            {
                var shippigCost = strategy.CalculateShippingCost(1, null);

                Assert.IsTrue(shippigCost > 0);
            }
        }

        [TestMethod]
        public void TestInvariants_FlatRateSetToZeroShouldThrowException()
        {
            WorldWideShippingStrategy strategy = new WorldWideShippingStrategy(1m);

            strategy.FlatRate = 0;

            Assert.IsTrue(strategy.FlatRate > 0);
        }
    }
}
