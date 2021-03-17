using System.Collections.Generic;
using NUnit.Framework;

namespace _7kyu_NumberOfPeopleInABus
{
    [TestFixture]
    public class PeopleInBusTests
    {
        [Test]
        public void FirstTest()
        {
            var peopleList = new List<int[]> { new[] { 10, 0 }, new[] { 3, 5 }, new[] { 5, 8 } };
            Assert.AreEqual(5, PeopleInBus.Number(peopleList));
        }
        [Test]
        public void SecondTest()
        {
            var peopleList = new List<int[]> { new[] { 3, 0 }, new[] { 9, 1 }, new[] { 4, 10 }, new[] { 12, 2 }, new[] { 6, 1 }, new[] { 7, 10 } };
            Assert.AreEqual(17, PeopleInBus.Number(peopleList));
        }
        [Test]
        public void ThirdTest()
        {
            var peopleList = new List<int[]> { new[] { 3, 0 }, new[] { 9, 1 }, new[] { 4, 8 }, new[] { 12, 2 }, new[] { 6, 1 }, new[] { 7, 8 } };
            Assert.AreEqual(21, PeopleInBus.Number(peopleList));
        }
    }
}