using System.Linq;

namespace _8kyu_CountofpositivesSumOfNegatives
{
    public class CountAndSum
    {
        public static int[] CountPositivesSumNegatives(int[] input)
        {
            if (input == null || input.Length == 0) return new int[0];

            var countPositives = 0;
            var sumNegatives = 0;
            input.Select(n => n > 0 ? countPositives++ : sumNegatives += n).ToList();
            //int countPositives = input.Count(n => n > 0);
            //int sumNegatives = input.Where(n => n < 0).Sum();
            return new[] { countPositives, sumNegatives };
        }
    }
}