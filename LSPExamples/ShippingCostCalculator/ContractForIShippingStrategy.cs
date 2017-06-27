using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingCostCalculator
{
    [ContractClassFor(typeof(IShippingStrategy))]
    public abstract class ContractForIShippingStrategy : IShippingStrategy
    {
        public decimal FlatRate { get; private set; }

        public decimal CalculateShippingCost(
            float packageWeightInKilograms, 
            RegionInfo destination)
        {
            Contract.Requires<ArgumentOutOfRangeException>(packageWeightInKilograms > 0f, "Package weight must be positive and non-zero");
           
            Contract.Ensures(Contract.Result<decimal>() > decimal.Zero);

            return decimal.One;
        }

        [ContractInvariantMethod]
        private void ClassInvariant()
        {
            Contract.Invariant(this.FlatRate > decimal.Zero, "Flat rate must be positive and non-zero");
        }
    }
}
