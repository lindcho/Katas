using NUnit.Framework;

namespace _7kyu_AlternateCapitalization
{
    public class TextCapitiliserTests
    {
        [Test]
        public void MyTest()
        {
            Assert.AreEqual(new string[2] { "AbCdEf", "aBcDeF" }, TextCapitaliser.Capitalize("abcdef"));
            Assert.AreEqual(new string[2] { "CoDeWaRs", "cOdEwArS" }, TextCapitaliser.Capitalize("codewars"));
            Assert.AreEqual(new string[2] { "AbRaCaDaBrA", "aBrAcAdAbRa" }, TextCapitaliser.Capitalize("abracadabra"));
            Assert.AreEqual(new string[2] { "CoDeWaRrIoRs", "cOdEwArRiOrS" }, TextCapitaliser.Capitalize("codewarriors"));
        }
    }

}