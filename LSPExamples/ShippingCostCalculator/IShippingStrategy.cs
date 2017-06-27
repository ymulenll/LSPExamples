using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingCostCalculator
{
    [ContractClass(typeof(ContractForIShippingStrategy))]
    public interface IShippingStrategy
    {
        decimal FlatRate { get; }

        decimal CalculateShippingCost(
            float packageWeightInKilograms,
            RegionInfo destination);
    }
}
