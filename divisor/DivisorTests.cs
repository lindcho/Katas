using NUnit.Framework;

namespace divisor
{
    [TestFixture]
    public class DivisorTests
    {
        [Test]
        public void ShouldGetDivisorsFor_15()
        {
            Assert.AreEqual(new int[] { 3, 5 }, DivisorKata.Divisors(15));
        }

        [Test]
        public void ShouldGetDivisorsFor_16()
        {
            Assert.AreEqual(new int[] { 2, 4, 8 }, DivisorKata.Divisors(16));
        }

        [Test]
        public void ShouldGetDivisorsFor_253()
        {
            Assert.AreEqual(new int[] { 11, 23 }, DivisorKata.Divisors(253));
        }

        [Test]
        public void ShouldGetDivisorsFor_24()
        {
            Assert.AreEqual(new int[] { 2, 3, 4, 6, 8, 12 }, DivisorKata.Divisors(24));
        }

        [Test]
        public void RandomSampleTest()
        {
            Assert.AreEqual(new int[] { 3, 5 }, DivisorKata.Divisors(15));
            Assert.AreEqual(new int[] { 2, 4, 8 }, DivisorKata.Divisors(16));
            Assert.AreEqual(new int[] { 11, 23 }, DivisorKata.Divisors(253));
            Assert.AreEqual(new int[] { 2, 3, 4, 6, 8, 12 }, DivisorKata.Divisors(24));
        }
    }
}