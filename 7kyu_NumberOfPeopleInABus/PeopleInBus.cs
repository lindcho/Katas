using System;
using System.Collections.Generic;

namespace _7kyu_NumberOfPeopleInABus
{
    public class PeopleInBus
    {
        public static int Number(List<int[]> peopleListInOut)
        {
            var totalIn = 0;
            var totalOut = 0;
            foreach (var people in peopleListInOut)
            {
                totalIn += people[0];
                totalOut += people[1];
            }

            return Math.Abs(totalIn - totalOut);
        }
    }
}