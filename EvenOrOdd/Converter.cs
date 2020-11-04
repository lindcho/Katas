using System;
using System.Collections.Generic;

namespace EvenOrOdd
{
    public class Converter
    {
        public string PrintOddOrEvenResult(int number)
        {
            var result = "";

            if (number < 0)
            {
                throw new ArgumentNullException(nameof(number), "number cannot be negative");
            }
            if (IsOddNumber(number))
            {
                result = "Odd";
            }

            if (IsEvenNumber(number))
            {
                result = "Even";
            }

            return result;
        }


        public string PrintOddEven(int startRange, int endRange)
        {
            var result = "";
            for (var number = startRange < 0 ? 1 : startRange; number <= endRange; number++)
            {
                if (number != endRange)
                {
                    result += number + ",";

                }
                else
                    result += number;
            }

            return result;
        }


        private static bool IsOddNumber(int number) => (number % 2 != 0);
        private static bool IsEvenNumber(int number) => number >= 2 && number % 2 == 0;
    }
}
