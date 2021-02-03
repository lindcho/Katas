using AtmPinKata;
using NUnit.Framework;

namespace AtmPinKataTests
{
    public class Tests
    {
        [Test, Description("ValidatePin should return false for pins with length other than 4 or 6")]
        public void LengthTest()
        {
            Assert.AreEqual(false, Pin.ValidatePin("1"), "Wrong output for \"1\"");
            Assert.AreEqual(false, Pin.ValidatePin("12"), "Wrong output for \"12\"");
            Assert.AreEqual(false, Pin.ValidatePin("123"), "Wrong output for \"123\"");
            Assert.AreEqual(false, Pin.ValidatePin("12345"), "Wrong output for \"12345\"");
            Assert.AreEqual(false, Pin.ValidatePin("1234567"), "Wrong output for \"1234567\"");
            Assert.AreEqual(false, Pin.ValidatePin("-1234"), "Wrong output for \"-1234\"");
            Assert.AreEqual(false, Pin.ValidatePin("1.234"), "Wrong output for \"1.234\"");
            Assert.AreEqual(false, Pin.ValidatePin("-1.234"), "Wrong output for \"-1.234\"");
            Assert.AreEqual(false, Pin.ValidatePin("00000000"), "Wrong output for \"00000000\"");
        }

        [Test, Description("ValidatePin should return false for pins which contain characters other than digits")]
        public void NonDigitTest()
        {
            Assert.AreEqual(false, Pin.ValidatePin("a234"), "Wrong output for \"a234\"");
            Assert.AreEqual(false, Pin.ValidatePin(".234"), "Wrong output for \".234\"");
        }

        [Test, Description("ValidatePin should return true for valid pins")]
        public void ValidTest()
        {
            Assert.AreEqual(true, Pin.ValidatePin("1234"), "Wrong output for \"1234\"");
            Assert.AreEqual(true, Pin.ValidatePin("0000"), "Wrong output for \"0000\"");
            Assert.AreEqual(true, Pin.ValidatePin("1111"), "Wrong output for \"1111\"");
            Assert.AreEqual(true, Pin.ValidatePin("123456"), "Wrong output for \"123456\"");
            Assert.AreEqual(true, Pin.ValidatePin("098765"), "Wrong output for \"098765\"");
            Assert.AreEqual(true, Pin.ValidatePin("000000"), "Wrong output for \"000000\"");
            Assert.AreEqual(true, Pin.ValidatePin("090909"), "Wrong output for \"090909\"");
        }

        [Test, Description("ValidatePin should return False for invalid pins")]
        public void EdgeCase()
        {
            Assert.AreEqual(false, Pin.ValidatePin("123 "), "Wrong output for \"123 \"");
            Assert.AreEqual(false, Pin.ValidatePin("1234 "), "Wrong output for \"1234 \"");
        }
    }
}