using System.Linq;

namespace _7kyu_AlternateCapitalization
{
    public class TextCapitaliser
    {
        public static string[] Capitalize(string s)
        {
            return new[]
            {
                string.Concat(s.Select((x, i) => i % 2 == 0 ? char.ToUpper(x) : x)),
                string.Concat(s.Select((x, i) => i % 2 == 1 ? char.ToUpper(x) : x))
            };
        }
    }



}