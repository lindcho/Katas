using System;

namespace _6kyu_SumOfDigits
{
    public class SumCalculator
    {
        public int DigitalRoot(long n)
        {
            if (n <= 9)
            {
                return Math.Abs((int)n);
            }
            long sum = 0;
            while (n != 0)
            {
                sum += Math.Abs(n % 10);
                n /= 10;
            }

            return DigitalRoot(sum);
        }
    }
}
