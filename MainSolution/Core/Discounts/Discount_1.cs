using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Discounts
{
    public class Discount_1 : IPercentage
    {
        public decimal PercentageValue(decimal value) => value - (value * 1 / 100);
    }
}
