using System.Collections.Generic;
using NUnit.Framework;

namespace LineNumberingKata
{
    [TestFixture]
    public class LineNumberingTest
    {
        [TestCase]
        public void BasicTests()
        {
            Assert.AreEqual(new List<string>(), LineNumbering.Number(new List<string>()));
            Assert.AreEqual(new List<string> { "1: a", "2: b", "3: c" }, LineNumbering.Number(new List<string> { "a", "b", "c" }));
            Assert.AreEqual(new List<string> { "1: ", "2: ", "3: ", "4: ", "5: " }, LineNumbering.Number(new List<string> { "", "", "", "", "" }));
        }
    }
}