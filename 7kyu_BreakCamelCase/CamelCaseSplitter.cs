using System.Linq;
using System.Text.RegularExpressions;

namespace _7kyu_BreakCamelCase
{
    public class CamelCaseSplitter
    {
        public static string BreakCamelCase(string str)
        {
            return string.IsNullOrEmpty(str) ? str : Regex.Replace(str, @"(\p{Lu})", " $1");
        }
    }
}
