using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace LineNumberingKata
{
    [TestFixture]
    public class LineNumberingTest
    {
        [TestCase]
        public void basicTests()
        {
            Assert.AreEqual(new List<string>(), LineNumbering.Number(new List<string>()));
            Assert.AreEqual(new List<string> { "1: a", "2: b", "3: c" }, LineNumbering.Number(new List<string> { "a", "b", "c" }));
            Assert.AreEqual(new List<string> { "1: ", "2: ", "3: ", "4: ", "5: " }, LineNumbering.Number(new List<string> { "", "", "", "", "" }));
        }
    }

    public class LineNumbering
    {
        public static List<string> Number(List<string> lines)
        {
            var isEmpty = !lines.Any();
            return isEmpty ? lines : lines
                .Select((line, i) => (i + 1) + ": " + line)
                .ToList();
        }
    }
}