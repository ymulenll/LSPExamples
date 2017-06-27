using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
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

        public override decimal CalculateShippingCost(float packageWeightInKilograms, Size<float> packageDimensionsInInches, RegionInfo destination)
        {
            var result = decimal.One;

            return result;
        }
    }
}
