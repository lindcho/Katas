using FluentAssertions;
using NUnit.Framework;

namespace PasswordVerifierTests
{
    [TestFixture]
    public class TestPasswordVerifier
    {
        [Test]
        public void Verify_Given4LetterPassword_ShouldThrowException()
        {
            //arrange
            var sut = new PasswordVerifier();
            //act
            var exception = Assert.Throws<System.Exception>(() => sut.Verify("test"));
            //assert
            exception.Message.Should().Be("Length Rule Violation. Password should be of more than characters length.");
        }
    }
}