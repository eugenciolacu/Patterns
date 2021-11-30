using System;

namespace SimpleFactory
{
    public static class CarFactory
    {
        public static Car Create(CarType type)
        {
            switch(type)
            {
                case CarType.Sedan:
                    return new Sedan();
                case CarType.SUV:
                    return new Suv();
                case CarType.Universal:
                    return new Universal();
                default:
                    throw new Exception("Wrong car type");
            }
        }
    }
}
