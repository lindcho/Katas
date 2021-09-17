using NUnit.Framework;

namespace _6kyu_SumOfDigits
{
    [TestFixture]
    public class SumCalculatorTests
    {

        [TestCase(1, 1)]
        [TestCase(5, 5)]
        [TestCase(9, 9)]
        public void Given1DigitNumber_ShouldReturnNumber(long number, int expected)
        {
            //arrange
            var sut = CreateSut();
            //act
            var result = sut.DigitalRoot(number);
            //assert
            Assert.AreEqual(result, expected);
        }

        [Test]
        public void RandomTests()
        {
            var sut = CreateSut();
            Assert.AreEqual(7, sut.DigitalRoot(16));
            Assert.AreEqual(6, sut.DigitalRoot(456));
        }

        private static SumCalculator CreateSut()
        {
            return new SumCalculator();
        }
    }

}