using Singleton._1st_version___not_thread_safe;
using Singleton._2nd_version___simple_thread_safety;
using Singleton._3rd_version___attempted_thread_safety_using_double_check_locking;
using Singleton._4th_version___not_quite_as_lazy__but_thread_safe_without_using_locks;
using Singleton._5th_version___fully_lazy_instantiation;
using Singleton._6th_version___using_.NET_4_s_Lazy_type;
using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Singleton is a creational design pattern that lets you ensure that a class has only one instance, while providing a global access point to this instance.");
            Console.WriteLine();

            Singleton_1 s1 = Singleton_1.Instance;
            Console.WriteLine(s1);

            Singleton_2 s2 = Singleton_2.Instance;
            Console.WriteLine(s2);

            Singleton_3 s3 = Singleton_3.Instance;
            Console.WriteLine(s3);

            Singleton_4 s4 = Singleton_4.Instance;
            Console.WriteLine(s4);

            Singleton_5 s5 = Singleton_5.Instance;
            Console.WriteLine(s5);

            Singleton_6 s6 = Singleton_6.Instance;
            Console.WriteLine(s6);
        }
    }
}
