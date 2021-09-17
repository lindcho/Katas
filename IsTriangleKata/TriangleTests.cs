using NUnit.Framework;

namespace IsTriangleKata
{
    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void IsTriangle_ValidPositiveNumbers_ReturnsTrue()
        {
            Assert.IsTrue(Triangle.IsTriangle(5, 7, 10));
        }
    }
}