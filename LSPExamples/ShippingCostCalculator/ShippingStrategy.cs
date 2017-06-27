#define CONTRACTS_FULL

using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingCostCalculator
{
    public class ShippingStrategy
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

        [ContractInvariantMethod]
        private void ClassInvariant()
        {
            Contract.Invariant(this.FlatRate > decimal.Zero, "Flat rate must be positive and non-zero");
        }

        public virtual decimal CalculateShippingCost(
            float packageWeightInKilograms, 
            RegionInfo destination)
        {
            // Preconditions and postconditions.
            Contract.Requires<ArgumentOutOfRangeException>(packageWeightInKilograms > 0, "Package weight must be positive and non-zero");
            Contract.Ensures(Contract.Result<decimal>() > decimal.Zero, "The return value is out of range");

            // implementation
            var shippingCost = decimal.One;
            
            return shippingCost;
        }
    }
}
