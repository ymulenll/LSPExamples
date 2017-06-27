using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingCostCalculator
{
    public class WorldWideShippingStrategy : ShippingStrategy
    {
        public WorldWideShippingStrategy(decimal flatRate)
            : base(flatRate)
        {
        }

        public decimal FlatRate
        {
            get
            {
                return base.flatRate;
            }
            set
            {
                base.flatRate = value;
            }
        }

        public override decimal CalculateShippingCost(
            float packageWeightInKilograms, 
            RegionInfo destination)
        {
            // Preconditions.
            if (packageWeightInKilograms <= 0)
                throw new ArgumentOutOfRangeException(nameof(packageWeightInKilograms), "Package weight must be positive and non-zero");

            if (destination == null)
                throw new ArgumentNullException("destination", "Destination must be provided");
    
            // implementation
            var shippingCost = decimal.Zero;
            
            return shippingCost;
        }
    }
}
