using System.Collections.Generic;

namespace Strategy
{
    public class SortDescendingStrategy : IStrategy
    {
        public List<T> Sort<T>(List<T> list)
        {
            list.Sort();
            list.Reverse();
            return list;
        }
    }
}
