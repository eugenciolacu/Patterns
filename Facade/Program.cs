using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Facade is a structural design pattern that provides a simplified interface to a library, a framework, or any other complex set of classes.");
            Console.WriteLine();

            Facade facade = new Facade(new SubSystemOne(), new SubSystemTwo(), new SubSystemThree());
            facade.FirstMethod();
            facade.SecondMethod();
            facade.ThirdMethod();
        }
    }
}
