using System;
using System.Linq;

namespace HighestAndLowestKata
{
    public class HighLow
    {
        public static string HighAndLow(string numbers)
        {
            // Code here or
            var splitNumbers = numbers.Split(" ").Select(int.Parse).ToList();
            var max = splitNumbers.Max();
            var min = splitNumbers.Min();
            var maxAndMin = $"{max} {min}";
            return maxAndMin;
        }
    }
}