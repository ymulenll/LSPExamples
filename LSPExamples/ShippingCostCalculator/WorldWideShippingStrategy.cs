using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingCostCalculator
{
    public class WorldWideShippingStrategy : IShippingStrategy
    {
        public WorldWideShippingStrategy(decimal flatRate)
        {
            this.FlatRate = flatRate;
        }

        public decimal FlatRate { get; set; }

        public decimal CalculateShippingCost(
            float packageWeightInKilograms, 
            RegionInfo destination)
        {
            if (destination == null)
                throw new ArgumentNullException("destination", "Destination must be provided");
    
            // implementation
            var shippingCost = decimal.One;
                        
            return shippingCost;
        }
    }
}
