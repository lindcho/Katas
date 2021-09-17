using System;
using EvenOrOdd;
using NUnit.Framework;

namespace EvenOrOddTests
{
    [TestFixture]
    public class ConverterTests
    {
        [Test]
        public void GivenNegativeNumber_ShouldThrow()
        {
            // Arrange
            var sut = CreateSut();
            // Act
            var exception = Assert.Throws<ArgumentNullException>(() => sut.PrintOddOrEvenResult(-1));
            // Assert
            Assert.That(exception.Message, Is.EqualTo("number cannot be negative (Parameter 'number')"));
        }

        [TestCase(1, "Odd")]
        [TestCase(3, "Odd")]
        [TestCase(5, "Odd")]
        public void GivenOddNumber_ShouldPrintOdd(int number, string expected)
        {
            // Arrange
            var sut = CreateSut();
            // Act
            var result = sut.PrintOddOrEvenResult(number);
            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(1, "Odd")]
        [TestCase(13, "Odd")]
        [TestCase(23, "Odd")]
        public void GivenTwoDigitOddNumber_ShouldPrintOdd(int number, string expected)
        {
            // Arrange
            var sut = CreateSut();
            // Act
            var result = sut.PrintOddOrEvenResult(number);
            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(2, "Even")]
        [TestCase(4, "Even")]
        [TestCase(6, "Even")]
        public void GivenEvenNumber_ShouldPrintEven(int number, string expected)
        {
            // Arrange
            var sut = CreateSut();
            // Act
            var result = sut.PrintOddOrEvenResult(number);
            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(22, "Even")]
        [TestCase(44, "Even")]
        [TestCase(86, "Even")]
        public void GivenTwoDigitEvenNumber_ShouldPrintEven(int number, string expected)
        {
            // Arrange
            var sut = CreateSut();
            // Act
            var result = sut.PrintOddOrEvenResult(number);
            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestFixture]
        public class StartAndEndRange
        {

            [TestCase(1, 10)]
            public void ShouldPrintNumbersWithinRange(int startRange, int endRange)
            {
                // Arrange
                var sut = CreateSut();
                const string expectedResult = "1,2,3,4,5,6,7,8,9,10";
                // Act
                var result = sut.PrintOddEven(startRange, endRange);
                // Assert
                Assert.That(result, Is.EqualTo(expectedResult));
            }

            [TestCase(-1, 10)]
            [TestCase(-5, 10)]
            [TestCase(-10, 10)]
            public void GivenNegativeStartRange_ShouldSetStartRangeTo1AndPrintNumbers(int startRange, int endRange)
            {
                // Arrange
                var sut = CreateSut();
                const string expectedResult = "1,2,3,4,5,6,7,8,9,10";
                // Act
                var result = sut.PrintOddEven(startRange, endRange);
                // Assert
                Assert.That(result, Is.EqualTo(expectedResult));
            }
        }

        private static Converter CreateSut()
        {
            return new Converter();
        }
    }
}