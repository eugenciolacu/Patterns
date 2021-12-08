using System.Collections.Generic;

namespace Strategy
{
    public class SortAscendingStrategy : IStrategy
    {
        public List<T> Sort<T>(List<T> list)
        {
            list.Sort();
            return list;
        }
    }
}
