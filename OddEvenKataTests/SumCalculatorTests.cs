using NUnit.Framework;
using SumKata;

namespace SumKataTests
{
    [TestFixture]
    [Category("SumCalculator")]
    public class SumCalculatorTests
    {
        [Test]
        public void AddReturnSum()
        {
            var sut = new SumCalculator();
            const string num1 = "";
            string num2 = null;
            const string expectedResult = "0";

            var result = sut.Sum(num1, num2);

            Assert.That(expectedResult, Is.EqualTo(result));
        }

        [Test]
        public void Add_GivenSetOfZeros_ShouldReturnsSum()
        {
            var sut = new SumCalculator();
            const string num1 = "0";
            const string num2 = "0";
            const string expectedResult = "0";
            var result = sut.Sum(num1, num2);

            Assert.That(expectedResult, Is.EqualTo(result));
        }

        [Test]
        public void Add_GivenNulls_ShouldSetNumberAsZeroAndReturnsSum()
        {
            var sut = new SumCalculator();
            const string num1 = null;
            const string num2 = null;
            const string expectedResult = "0";
            var result = sut.Sum(num1, num2);

            Assert.That(expectedResult, Is.EqualTo(result));
        }

        [TestCase("-1", null, "-1")]
        [TestCase("-9", null, "-9")]
        [TestCase("-5", null, "-5")]
        [TestCase("-11", null, "-11")]
        public void Add_GivenNegativeNumberAndANull_ShouldSetNullNumberAsZero_ReturnsNegativeSum(string num1, string num2, string expectedResult)
        {
            var sut = new SumCalculator();
            var result = sut.Sum(num1, num2);

            Assert.That(expectedResult, Is.EqualTo(result));
        }

        [TestCase("2", "2", "4")]
        [TestCase("3", "7", "10")]
        [TestCase("6", "20", "26")]
        public void Add_GivenSetOfPositiveNumbers_ShouldReturnSum(string num1, string num2, string expectedResult)
        {
            var sut = new SumCalculator();
            var result = sut.Sum(num1, num2);

            Assert.That(expectedResult, Is.EqualTo(result));
        }

        [TestCase("5", "-3", "2")]
        [TestCase("1", "-1", "0")]
        [TestCase("8", "-19", "-11")]
        public void Add_GivenPositiveAndNegativeNumbers_ShouldReturnSum(string num1, string num2, string expectedResult)
        {
            var sut = new SumCalculator();
            var result = sut.Sum(num1, num2);

            Assert.That(expectedResult, Is.EqualTo(result));
        }

        [TestCase("-4", "1", "-3")]
        [TestCase("-9", "15", "6")]
        [TestCase("-7", "8", "1")]
        public void Add_GivenNegativeAndPositiveNumbers_ShouldReturnSum(string num1, string num2, string expectedResult)
        {
            var sut = new SumCalculator();
            var result = sut.Sum(num1, num2);

            Assert.That(expectedResult, Is.EqualTo(result));
        }
    }
}