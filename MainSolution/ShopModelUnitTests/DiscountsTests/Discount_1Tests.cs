using Core.Discounts;
using NUnit.Framework;

namespace ShopModelUnitTests
{
    [TestFixture]
    public class Discount_1Tests
    {
        private Discount_1? _discount_1;

        [SetUp]
        [Description("Initializing object of Discount_1 class")]
        public void Setup()
        {
            _discount_1 = new Discount_1();
        }

        [Test]
        [Description("Validate correct value of PercentageValue method")]
        public void PercentageValue_CalculatePercent_ExpectedCorrectNumber()
        {
            decimal expectedResult = 98.01M;

            var actualResult = _discount_1?.PercentageValue(99M);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        [Description("Validate incorrect value of PercentageValue method")]
        public void PercentageValue_CalculatePercent_ExpectedInCorrectNumber()
        {
            decimal expectedResult = 99.8M;

            var actualResult = _discount_1?.PercentageValue(100M);

            Assert.AreNotEqual(expectedResult, actualResult);
        }
    }
}
