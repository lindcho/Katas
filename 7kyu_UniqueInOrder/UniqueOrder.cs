using System.Collections.Generic;

namespace _7kyu_UniqueInOrder
{
    public class UniqueOrder
    {
        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
        {
            var newList = new List<T>();
            foreach (var item in iterable)
            {
                var newListCounter= newList.Count;
                if (newListCounter < 1 || !(item.Equals(newList[newListCounter - 1])))
                {
                    newList.Add(item);
                }
            }
            return newList;
        }
    }
}