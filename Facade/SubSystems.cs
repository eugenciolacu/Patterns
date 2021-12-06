using System;

namespace Facade
{
    public class SubSystemOne
    {
        public void FirstMethod()
        {
            Console.WriteLine("SubsystemOneFirstMethod");
        }
    }


    public class SubSystemTwo
    {
        public void FirstMethod()
        {
            Console.WriteLine("SubsystemTwoFirstMethod");
        }

        public void SecondMethod()
        {
            Console.WriteLine("SubsystemTwoSecondMethod");
        }
    }


    public class SubSystemThree
    {
        public void FirstMethod()
        {
            Console.WriteLine("SubsystemThreeFirstMethod");
        }

        public void SecondMethod()
        {
            Console.WriteLine("SubSystemThreeSecondMethod");
        }

        public void ThirdMethod()
        {
            Console.WriteLine("SubSystemThreeThirdMethod");
        }
    }
}
