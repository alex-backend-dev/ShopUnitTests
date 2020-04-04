using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class ShoppingCart : ICart
    {
        private ICalculate valueCalculate;
        private IPercentage valuePercentage;

        public IEnumerable<Product> Products { get; set; }

        public ShoppingCart(IPercentage valuePercentage, ICalculate valueCalculate)
        {
            this.valuePercentage = valuePercentage;
            this.valueCalculate = valueCalculate;
        }

        public decimal CalculateTotal() => valuePercentage.PercentageValue(valueCalculate.ValueCalc(Products));
    }
}
