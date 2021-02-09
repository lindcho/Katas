using NUnit.Framework;

namespace Disemvowel_Trolls
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void ShouldRemoveAllVowels()
        {
            Assert.AreEqual("Ths wbst s fr lsrs LL!", DisemVowelTrolls.Disemvowel("This website is for losers LOL!"));
        }
    }
}