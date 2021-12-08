using System.Collections.Generic;

namespace Strategy
{
    public interface IStrategy
    {
        List<T> Sort<T>(List<T> list);
    }
}
