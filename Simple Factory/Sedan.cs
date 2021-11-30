using System;

namespace SimpleFactory
{
    public class Sedan : Car
    {
        public Sedan() : base()
        {
            Console.WriteLine("Get a sedan");
        }
    }
}
