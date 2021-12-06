namespace Facade
{
    public class Facade
    {
        private SubSystemOne _subSystemOne;
        private SubSystemTwo _subSystemTwo;
        private SubSystemThree _subSystemThree;
        public Facade(SubSystemOne subSystemOne, SubSystemTwo subSystemTwo, SubSystemThree subSystemThree)
        {
            _subSystemOne = subSystemOne;
            _subSystemTwo = subSystemTwo;
            _subSystemThree = subSystemThree;
        }

        public void FirstMethod()
        {
            _subSystemOne.FirstMethod();
            _subSystemTwo.FirstMethod();
            _subSystemThree.FirstMethod();
            System.Console.WriteLine();
        }

        public void SecondMethod()
        {
            _subSystemTwo.SecondMethod();
            _subSystemThree.SecondMethod();
            System.Console.WriteLine();
        }

        public void ThirdMethod()
        {
            _subSystemThree.ThirdMethod();
            System.Console.WriteLine();
        }
    }
}
