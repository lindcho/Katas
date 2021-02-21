using NUnit.Framework;

namespace MoneyKata
{
    public class MoneyTests
    {
        [TestCase]
        public void GetNumberOfYears0()
        {
            Assert.AreEqual(0, MoneyCalculator.CalculateYears(1000, 0.05, 0.18, 1000));
        }

        [TestCase]
        public void GetNumberOfYears1()
        {
            Assert.AreEqual(14, MoneyCalculator.CalculateYears(1000, 0.01625, 0.18, 1200));
        }
    }
}