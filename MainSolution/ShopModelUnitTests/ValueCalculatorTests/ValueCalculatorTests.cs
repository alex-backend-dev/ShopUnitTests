using Core;
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;

namespace ShopModelUnitTests
{
    [TestFixture]
    public class ValueCalculatorTests
    {
        private ValueCalculator? _valueCalculator;
        private IEnumerable<Product>? _products;

        [SetUp]
        [Description("Initializing object of ValueCalculator class and initializing collection _products")]
        public void Setup()
        {
            _valueCalculator = new ValueCalculator();

            _products = new []
            {
                new Product {ProductID = 1, Name = "Lays", Price = 20},
                new Product { ProductID = 2, Name = "Pringles", Price = 40 },
            };
        }

        [Test]
        public void ValueCalc_Calculate_ExpectedCorrectNumber()
        {
            decimal actualResult = 60;
            var expectedResult = _valueCalculator?.ValueCalc(_products);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
