using System;
using _7kyu_Factorial;
using NUnit.Framework;

namespace _7kyu_FactorialTests
{
    public class CalculatorTests
    {
        [Test]
        public void FactorialOfNegativeShouldThrow()
        {
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => Calculator.Factorial(-1));

            Assert.AreEqual(ex.Message, "Specified argument was out of the range of valid values. (Parameter 'n')");
        }

        [Test]
        public void FactorialOfGreaterThan12ShouldThrow()
        {
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => Calculator.Factorial(13));

            Assert.AreEqual(ex.Message, "Specified argument was out of the range of valid values. (Parameter 'n')");
        }
        [Test]
        public void FactorialOf12ShouldBe()
        {
            Assert.AreEqual(479001600, Calculator.Factorial(12));
        }

        [Test]
        public void FactorialOf0ShouldBe1()
        {
            Assert.AreEqual(1, Calculator.Factorial(0));
        }

        [Test]
        public void FactorialOf1ShouldBe1()
        {
            Assert.AreEqual(1, Calculator.Factorial(1));
        }

        [Test]
        public void FactorialOf2ShouldBe2()
        {
            Assert.AreEqual(2, Calculator.Factorial(2));
        }

        [Test]
        public void FactorialOf3ShouldBe6()
        {
            Assert.AreEqual(6, Calculator.Factorial(3));
        }
    }
}