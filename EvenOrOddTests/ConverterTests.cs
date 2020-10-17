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


        [Test]
        public void Given1OddNumber_ShouldPrintOddNumber()
        {
            var sut = new Converter();
            var result = sut.PrintOddOrEvenResult(1);
            Assert.That(result, Is.EqualTo("Odd"));
        }
    }
}