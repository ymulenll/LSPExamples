using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class ShippingStrategy
    {
        protected decimal flatRate;

        public ShippingStrategy(decimal flatRate)
        {
            this.flatRate = flatRate;
        }

        public virtual decimal CalculateShippingCost(
            float packageWeightInKilograms, 
            Size<float> packageDimensionsInInches, 
            RegionInfo destination)
        {
            var shippingCost = decimal.One;

            return shippingCost;
        }
    }
}
