using System;

namespace PasswordVerifierTests
{
    public class PasswordVerifier
    {
        public bool Verify(string password) => IsPasswordPassedLengthRule(password, 8);

        private bool IsPasswordPassedLengthRule(string password, int length)
        {
            if(password.Length <= length)
                throw new Exception("Length Rule Violation. Password should be of more than characters length.");
            return true;
        }
    }
}