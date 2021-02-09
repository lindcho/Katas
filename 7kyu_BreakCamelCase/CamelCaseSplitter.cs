using System.Linq;

namespace _7kyu_BreakCamelCase
{
    public class CamelCaseSplitter
    {
        public static string BreakCamelCase(string str)
        {
            if (string.IsNullOrEmpty(str))
                return str;

            return string.Concat(str
                .Select(c => char.IsUpper(c)
                    ? " " + c.ToString()
                    : c.ToString()));
        }
    }
}
