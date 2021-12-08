using System.Collections.Generic;

namespace Strategy
{
    public class SortingContext
    {
        private IStrategy _sortingStrategy;

        public SortingContext()
        {
        }

        public SortingContext(IStrategy strategy)
        {
            _sortingStrategy = strategy;
        }

        public void SetStrategy(IStrategy strategy)
        {
            _sortingStrategy = strategy;
        }

        public List<T> Sort<T>(List<T> list)
        {
            return _sortingStrategy.Sort(list);
        }
    }
}
