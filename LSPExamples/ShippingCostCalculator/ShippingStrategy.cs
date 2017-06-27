using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingCostCalculator
{
    public class ShippingStrategy : IShippingStrategy
    {   
        public ShippingStrategy(decimal flatRate)
        {   
            this.FlatRate = flatRate;
        }

        private decimal flatRate;
        public decimal FlatRate
        {
            get
            {
                return this.flatRate;
            }
            set
            {
                this.flatRate = value;
            }
        }

        public decimal CalculateShippingCost(
            float packageWeightInKilograms, 
            RegionInfo destination)
        {
            // implementation
            var shippingCost = decimal.One;

            return shippingCost;
        }
    }
}
