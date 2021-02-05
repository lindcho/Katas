using System;

namespace _7kyu_Factorial
{
    public class Calculator
    {
        public static int Factorial(int n)
        {
            if (n < 0 || n > 12)
            {
                throw new ArgumentOutOfRangeException(nameof(n));
            }
            if (n == 0) return 1;
            return n * Factorial(n - 1);

        }
    }
}
