using System;
using System.Linq;

namespace PasswordVerifierTests
{
    public class PasswordVerifier
    {
        public bool Verify(string password) => IsPasswordPassedLengthRule(password, 8);

        private bool IsPasswordPassedLengthRule(string password, int length)
        {
            if (password == null)
                throw new Exception("Length Rule Violation. Password should not be null.");
            if (password.Length <= length)
                throw new Exception("Length Rule Violation. Password should be of more than characters length.");

            var hasUpperCase = password.Select(char.IsUpper);
            if (hasUpperCase.All(x => x != true))
            {
                throw new Exception("Rule Violation. password should have one uppercase letter at least.");
            }

            return true;
        }
    }
}