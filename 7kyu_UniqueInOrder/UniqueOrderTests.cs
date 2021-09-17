using NUnit.Framework;

namespace _7kyu_UniqueInOrder
{
    [TestFixture]
    public class UniqueOrderTests
    {
        [Test]
        public void EmptyTest()
        {
            Assert.AreEqual("", UniqueOrder.UniqueInOrder(""));
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual("ABCDAB", UniqueOrder.UniqueInOrder("AAAABBBCCDAABBB"));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual("ABCcAD", UniqueOrder.UniqueInOrder("ABBCcAD"));
        }

    }
}