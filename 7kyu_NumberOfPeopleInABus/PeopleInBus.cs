using System.Collections.Generic;
using System.Linq;

namespace _7kyu_NumberOfPeopleInABus
{
    public class PeopleInBus
    {
        public static int Number(List<int[]> peopleListInOut)
        {
            return peopleListInOut.Sum(item => item[0] - item[1]);
        }
    }
}