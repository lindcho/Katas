using System;

namespace EvenOrOdd
{
    public class Converter
    {
        public string PrintOddOrEvenResult(int number)
        {
            if (number < 0)
            {
                throw new ArgumentNullException(nameof(number), "number cannot be negative");
            }
            if (number % 2 != 0)
            {
                return "Odd";
            }
            throw new NotImplementedException();
        }
    }
}
