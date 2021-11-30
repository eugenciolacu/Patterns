using System;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Factory pattern. Allows to create objects (of similar type) without the logic of their creation in the client.");

            Car car1 = CarFactory.Create(CarType.Sedan);
            Car car2 = CarFactory.Create(CarType.SUV);
            Car car3 = CarFactory.Create(CarType.Universal);
        }
    }
}
