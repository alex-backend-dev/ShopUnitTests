using Core.Discounts;
using NUnit.Framework;

namespace ShopModelUnitTests
{
    [TestFixture]
    public class Discount_5Tests
    {
        private Discount_5? _discount_5;

        [SetUp]
        [Description("Initializing object of Discount_5 class")]
        public void Setup()
        {
            _discount_5 = new Discount_5();
        }

        [Test]
        [Description("Validate correct value of PercentageValue method")]
        public void PercentageValue_CalculatePercent_ExpectedCorrectNumber()
        {
            decimal expectedResult = 94.05M;

            var actualResult = _discount_5?.PercentageValue(99M);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        [Description("Validate incorrect value of PercentageValue method")]
        public void PercentageValue_CalculatePercent_ExpectedInCorrectNumber()
        {
            decimal expectedResult = 99.6M;

            var actualResult = _discount_5?.PercentageValue(100M);

            Assert.AreNotEqual(expectedResult, actualResult);
        }
    }
}
