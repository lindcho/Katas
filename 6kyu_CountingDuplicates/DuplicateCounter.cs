using System.Linq;

namespace _6kyu_CountingDuplicates
{
    public class DuplicateCounter
    {
        public static int DuplicateCount(string str)
        {
            var result = str.ToLower().GroupBy(x => x).Select(y => y).Where(z => z.Count() > 1).Count();
            return result;
        }
    }
}