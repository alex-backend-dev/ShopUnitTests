using Core;
using NUnit.Framework;

namespace ShopModelUnitTests
{
    [TestFixture]
    public class ProductTests
    {

        [Test]
        [Description("Validate correct equality of the same objects")]
        public void Equals_CorrectEquals_ExpectedTrue()
        {
            Product _product1 = new Product() { Name = "Milk", Price = 100, ProductID = 2 };
            Product _product2 = new Product() { Name = "Milk", Price = 100, ProductID = 2 };

            Assert.IsTrue(_product1 == _product2);
        }

        [Test]
        [Description("Validate incorrect equality of different objects")]
        public void Equals_CorrectEquals_ExpectedFalse()
        {
            Product _product3 = new Product() { Name = "Milk", Price = 100, ProductID = 2 };
            Product _product4 = new Product() { Name = "Butter", Price = 50, ProductID = 3 };

            Assert.IsFalse(_product3 == _product4);
        }

        [Test]
        [Description("Validate correct inequality of different objects")]
        public void Inequality_CorrectInequality_ExpectedTrue()
        {
            Product _product5 = new Product() { Name = "Milk", Price = 100, ProductID = 2 };
            Product _product6 = new Product() { Name = "Butter", Price = 50, ProductID = 3 };

            Assert.IsTrue(_product5 != _product6);
        }

        [Test]
        [Description("Validate incorrect inequality of the same objects")]
        public void Inequality_CorrectInequality_ExpectedFalse()
        {
            Product _product7 = new Product() { Name = "Milk", Price = 100, ProductID = 2 };
            Product _product8 = new Product() { Name = "Milk", Price = 100, ProductID = 2 };

            Assert.IsFalse(_product7 != _product8);
        }
    }
}