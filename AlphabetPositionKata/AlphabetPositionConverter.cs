using System;
using System.Collections.Generic;
using System.Linq;

namespace AlphabetPositionKata
{
    //https://www.codewars.com/kata/546f922b54af40e1e90001da/train/csharp
    public class AlphabetPositionConverter
    {

        private static char[] Alphabets = new[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        public static string AlphabetPosition(string text)
        {
            var textCharArray = text.ToArray();

            var sb = "";
            foreach (var c in textCharArray)
            {
                var index = Array.IndexOf(Alphabets, char.ToLowerInvariant(c));

                if (index == -1) continue;
                index++;
                sb += ($"{index} ");
            }

            var result = sb.ToString().TrimEnd();
            return result;
        }

        public static string AlphabetPositionWithDictionary(string text)
        {
            var letterPositions = LetterPositions();

            var convertedLetters = new List<int>();

            foreach (var c in text.ToLower())
            {
                if (letterPositions.ContainsKey(c))
                {
                    convertedLetters.Add(letterPositions[c]);
                }
            }

            return string.Join(" ", convertedLetters);
        }

        private static Dictionary<char, int> LetterPositions()
        {
            return new Dictionary<char, int>()
            {
                {'a', 1},
                {'b', 2},
                {'c', 3},
                {'d', 4},
                {'e', 5},
                {'f', 6},
                {'g', 7},
                {'h', 8},
                {'i', 9},
                {'j', 10},
                {'k', 11},
                {'l', 12},
                {'m', 13},
                {'n', 14},
                {'o', 15},
                {'p', 16},
                {'q', 17},
                {'r', 18},
                {'s', 19},
                {'t', 20},
                {'u', 21},
                {'v', 22},
                {'w', 23},
                {'x', 24},
                {'y', 25},
                {'z', 26}
            };
        }
    }
}