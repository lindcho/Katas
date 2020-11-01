using System;
using EvenOrOdd;
using NUnit.Framework;

namespace EvenOrOddTests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void GivenNegativeNumber_ShouldThrow()
        {
            var sut = new Converter();
            var exception = Assert.Throws<ArgumentNullException>(() => sut.PrintOddOrEvenResult(-1));

            Assert.That(exception.Message, Is.EqualTo("number cannot be negative (Parameter 'number')"));
        }


        [TestCase(1, "Odd")]
        [TestCase(3, "Odd")]
        [TestCase(5, "Odd")]
        public void Given1OddNumber_ShouldPrintOddNumber(int number, string expected)
        {
            var sut = new Converter();
            var result = sut.PrintOddOrEvenResult(number);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}