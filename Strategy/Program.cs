using System;
using System.Collections.Generic;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Strategy is a behavioral design pattern that lets you define a family of algorithms, " +
                "put each of them into a separate class, and make their objects interchangeable.");
            Console.WriteLine();

            List<int> list = new List<int>() { 2, 3, 1 };

            var sortingContext = new SortingContext();
            sortingContext.SetStrategy(new SortAscendingStrategy());

            list = sortingContext.Sort(list);

            string str = string.Empty;
            foreach (var item in list)
            {
                str += item.ToString() + ", ";
            }

            Console.WriteLine(str);

            sortingContext.SetStrategy(new SortDescendingStrategy());

            list = sortingContext.Sort(list);

            str = string.Empty;
            foreach (var item in list)
            {
                str += item.ToString() + ", ";
            }

            Console.WriteLine(str);
            Console.WriteLine();
        }
    }
}
