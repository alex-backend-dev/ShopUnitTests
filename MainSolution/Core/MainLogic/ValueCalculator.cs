using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class ValueCalculator : ICalculate
    {
        public decimal ValueCalc(IEnumerable<Product> products)
        {
            decimal sumofProduct = 0;
            foreach (var product in products)
            {
                sumofProduct += product.Price;
            }
            return sumofProduct;
        }
    }
}
