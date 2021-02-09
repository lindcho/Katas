using System.Collections.Generic;
using _7kyu_BreakCamelCase;
using NUnit.Framework;

namespace _7kyu_BreakCamelCaseTests
{
    public class CamelCaseSplitterTests
    {
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData("camelCasing").Returns("camel Casing");
                yield return new TestCaseData("camelCasingTest").Returns("camel Casing Test");
            }
        }

        [Test, TestCaseSource("testCases")]
        public string Test(string str) => CamelCaseSplitter.BreakCamelCase(str);
    }
}
