using NUnit.Framework;

namespace _7kyu_DivisorKata
{
    [TestFixture]
    public class DevisorTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(new int[] { 3, 5 }, Devisor.Divisors(15));
            Assert.AreEqual(new int[] { 2, 4, 8 }, Devisor.Divisors(16));
            Assert.AreEqual(new int[] { 11, 23 }, Devisor.Divisors(253));
            Assert.AreEqual(new int[] { 2, 3, 4, 6, 8, 12 }, Devisor.Divisors(24));
        }

        [Test]
        public void ShouldGetDivisorsFor_15()
        {
            Assert.AreEqual(new int[] { 3, 5 }, Devisor.Divisors(15));
        }

        [Test]
        public void ShouldGetDivisorsFor_16()
        {
            Assert.AreEqual(new int[] { 2, 4, 8 }, Devisor.Divisors(16));
        }

        [Test]
        public void ShouldGetDivisorsFor_253()
        {
            Assert.AreEqual(new int[] { 11, 23 }, Devisor.Divisors(253));
        }

        [Test]
        public void ShouldGetDivisorsFor_24()
        {
            Assert.AreEqual(new int[] { 2, 3, 4, 6, 8, 12 }, Devisor.Divisors(24));
        }
    }
}