using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public interface ICalculate
    {
        decimal ValueCalc(IEnumerable<Product> products);
    }
}
