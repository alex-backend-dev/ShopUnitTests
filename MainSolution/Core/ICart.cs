using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public interface ICart
    {
        IEnumerable<Product> Products { get; set; }

        decimal CalculateTotal();
    }
}
