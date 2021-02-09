using System;
using System.Linq;

namespace Disemvowel_Trolls
{
    public class DisemVowelTrolls
    {
        public static string Disemvowel(string str)
        {
            return string.Concat(str.Where(ch => !"aeiouAEIOU".Contains(ch)));
        }
    }
}