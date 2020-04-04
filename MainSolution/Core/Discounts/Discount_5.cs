using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Discounts
{
    public class Discount_5 : IPercentage
    {
        public decimal PercentageValue(decimal value) => value - (value * 5 / 100);
    }
}
