using NUnit.Framework;

namespace HighestAndLowestKata
{
    public class HighLowTests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual("42 -9", HighLow.HighAndLow("8 3 -5 42 -1 0 0 -9 4 7 4 -4"));
        }
    }
}