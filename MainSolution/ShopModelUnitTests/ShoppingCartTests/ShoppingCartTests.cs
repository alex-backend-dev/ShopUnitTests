using Core;
using Core.Discounts;
using NUnit.Framework;
using System.Collections.Generic;

namespace ShopModelUnitTests
{
    [TestFixture]
    public class ShoppingCartTests
    {
        private IEnumerable<Product>? _products;
        private Discount_1? _discount1;
        private Discount_5? _discount5;
        private ValueCalculator? _calculator;
        private ShoppingCart? _cart1;
        private ShoppingCart? _cart2;

        [SetUp]
        [Description("Initializing required data")]
        public void Setup()
        {
            _products = new []
            {
                new Product {ProductID = 1, Name = "Lays", Price = 20},
                new Product {ProductID = 2, Name = "Pringles", Price = 40}
            };

            _discount1 = new Discount_1();
            _discount5 = new Discount_5();

            _calculator = new ValueCalculator();

            _cart1 = new ShoppingCart(_discount1, _calculator) { Products = _products };
            _cart2 = new ShoppingCart(_discount5, _calculator) { Products = _products };
        }

        [Test]
        [Description("Valid correct behauviour of CalculateTotal method")]
        public void CalculateTotal_InsertingRequiredDataIntoMethod_ExpectedCorrectNumber()
        {
            var expectedResultDiscount1 = 59.4M;
            var anotherExpectedResultDiscount5 = 57M;

            var actualResult = _cart1?.CalculateTotal();
            var anotherActualResult = _cart2?.CalculateTotal();

            Assert.AreEqual(expectedResultDiscount1, actualResult);
            Assert.AreEqual(anotherExpectedResultDiscount5, anotherActualResult);
        }

        [Test]
        [Description("Valid incorrect behauviour of CalculateTotal method")]
        public void CalculateTotal_InsertingRequiredDataIntoMethod_ExpectedInCorrectNumber()
        {
            var expectedResultDiscount1 = 59.3M;
            var anotherExpectedResultDiscount5 = 56.9M;

            var actualResult = _cart1?.CalculateTotal();
            var anotherActualResult = _cart2?.CalculateTotal();

            Assert.AreNotEqual(expectedResultDiscount1, actualResult);
            Assert.AreNotEqual(anotherExpectedResultDiscount5, anotherActualResult);
        }
    }
}
