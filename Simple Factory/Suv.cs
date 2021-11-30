using System;

namespace SimpleFactory
{
    public class Suv : Car
    {
        public Suv() : base()
        {
            Console.WriteLine("Get a SUV");
        }
    }
}
