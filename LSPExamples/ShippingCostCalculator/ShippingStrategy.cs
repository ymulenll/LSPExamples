using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingCostCalculator
{
    public class ShippingStrategy
    {
        protected decimal flatRate;

        public ShippingStrategy(decimal flatRate)
        {
            // Invariants.
            if (flatRate <= decimal.Zero)
                throw new ArgumentOutOfRangeException("flatRate", "Flat rate must be positive and non-zero");

            this.flatRate = flatRate;
        }

        public virtual decimal CalculateShippingCost(
            float packageWeightInKilograms, 
            RegionInfo destination)
        {
            // Preconditions.
            if (packageWeightInKilograms <= 0)
                throw new ArgumentOutOfRangeException(nameof(packageWeightInKilograms), "Package weight must be positive and non-zero");

            // implementation
            var shippingCost = decimal.One;

            // Postconditions.
            if (shippingCost <= decimal.Zero)
                throw new ArgumentOutOfRangeException("return", "The return value is out of range");

            return shippingCost;
        }
    }
}
