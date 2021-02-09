using System;
using System.Linq;

namespace Disemvowel_Trolls
{
    public class DisemVowelTrolls
    {
        public static string Disemvowel(string str)
        {
            return new string(str.Where(x => "aeiou".IndexOf(x.ToString(), StringComparison.InvariantCultureIgnoreCase) < 0).ToArray());
        }
    }
}