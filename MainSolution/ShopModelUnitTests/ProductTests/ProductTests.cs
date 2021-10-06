using Core;
using NUnit.Framework;

namespace ShopModelUnitTests
{
    [TestFixture]
    public class ProductTests
    {
        private Product? _product1;
        private Product? _product2;

        [Test]
        [Description("Validate correct equality of the same objects")]
        public void Equals_CorrectEquals_ExpectedTrue()
        {
            _product1 = new Product() { Name = "Milk", Price = 100, ProductID = 2 };
            _product2 = new Product() { Name = "Milk", Price = 100, ProductID = 2 };

            Assert.IsTrue(_product1 == _product2);
        }

        [Test]
        [Description("Validate incorrect equality of different objects")]
        public void Equals_CorrectEquals_ExpectedFalse()
        {
            _product1  = new Product() { Name = "Milk", Price = 100, ProductID = 2 };
            _product2 = new Product() { Name = "Butter", Price = 50, ProductID = 3 };

            Assert.IsFalse(_product1 == _product2);
        }

        [Test]
        [Description("Validate correct inequality of different objects")]
        public void Inequality_CorrectInequality_ExpectedTrue()
        {
            _product1 = new Product() { Name = "Milk", Price = 100, ProductID = 2 };
            _product2 = new Product() { Name = "Butter", Price = 50, ProductID = 3 };

            Assert.IsTrue(_product1 != _product2);
        }

        [Test]
        [Description("Validate incorrect inequality of the same objects")]
        public void Inequality_CorrectInequality_ExpectedFalse()
        {
            _product1 = new Product() { Name = "Milk", Price = 100, ProductID = 2 };
            _product2 = new Product() { Name = "Milk", Price = 100, ProductID = 2 };

            Assert.IsFalse(_product1 != _product2);
        }
    }
}