using System;

namespace SimpleFactory
{
    public class Universal : Car
    {
        public Universal() : base()
        {
            Console.WriteLine("Get an universal");
        }
    }
}
