using FluentAssertions;
using NUnit.Framework;

namespace PasswordVerifierTests
{
    [TestFixture]
    public class TestPasswordVerifier
    {
        [Test]
        public void Verify_GivenPasswordIsLessThan8Characters_ShouldThrowException()
        {
            //arrange
            var sut = new PasswordVerifier();
            //act
            var exception = Assert.Throws<System.Exception>(() => sut.Verify("test"));
            //assert
            exception.Message.Should().Be("Length Rule Violation. Password should be of more than characters length.");
        }

        [Test]
        public void Verify_GivenPasswordNull_ShouldThrowException()
        {
            //arrange
            var sut = new PasswordVerifier();
            //act
            var exception = Assert.Throws<System.Exception>(() => sut.Verify(null));
            //assert
            exception.Message.Should().Be("Length Rule Violation. Password should not be null.");
        } 
        
        [Test]
        public void Verify_GivenPasswordDoesNotContainAtleast1UpperCase_ShouldThrowException()
        {
            //arrange
            var sut = new PasswordVerifier();
            //act
            var exception = Assert.Throws<System.Exception>(() => sut.Verify("abcde1234"));
            //assert
            exception.Message.Should().Be("Rule Violation. password should have one uppercase letter at least.");
        }

        [Test]
        public void Verify_GivenPasswordDoesNotContainAtleastUpperCase_ShouldThrowException()
        {
            //arrange
            var sut = new PasswordVerifier();
            //act
            var exception = Assert.Throws<System.Exception>(() => sut.Verify("Abcde1234"));
            //assert
            exception.Message.Should().Be("Rule Violation. password should have one uppercase letter at least.");
        }

    }
}