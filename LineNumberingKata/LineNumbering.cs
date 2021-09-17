using System.Collections.Generic;
using System.Linq;

namespace LineNumberingKata
{
    public class LineNumbering
    {
        public static List<string> Number(List<string> lines)
        {
            var isEmpty = !lines.Any();
            return isEmpty ? lines : lines
                .Select((line, i) => (i + 1) + ": " + line)
                .ToList();
        }
    }
}