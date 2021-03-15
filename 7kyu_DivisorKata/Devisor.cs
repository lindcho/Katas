using System;
using System.Collections.Generic;

namespace _7kyu_DivisorKata
{
    public class Devisor
    {
        public static int[] Divisors(int n)
        {
            if (n < 2 || IsPrime(n))
            {
                return null;
            }

            var divisors = new List<int>();
            for (var index = 2; index < n; index++)
                if (n % index == 0)
                    divisors.Add(index);

            return divisors.ToArray();
        }

        public static bool IsPrime(int number)
        {
            if (number == 2) { return true; }
            if ((number < 2) || (number % 2 == 0)) { return false; }
            for (var i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0) { return false; }
            }

            return true;
        }
    }
}