using NUnit.Framework;

namespace _6kyu_CountingDuplicates
{
    public class CountDuplicatesTests
    {
        [Test]
        public void KataTests()
        {
            Assert.AreEqual(0, DuplicateCounter.DuplicateCount(""));
            Assert.AreEqual(0, DuplicateCounter.DuplicateCount("abcde"));
            Assert.AreEqual(2, DuplicateCounter.DuplicateCount("aabbcde"));
            Assert.AreEqual(2, DuplicateCounter.DuplicateCount("aabBcde"), "should ignore case");
            Assert.AreEqual(1, DuplicateCounter.DuplicateCount("Indivisibility"));
            Assert.AreEqual(2, DuplicateCounter.DuplicateCount("Indivisibilities"), "characters may not be adjacent");
        }
    }
}