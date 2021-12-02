using Abstract_Factory.Factories;
using Abstract_Factory.Products;
using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abstract Factory is a creational design pattern that lets you produce families of related objects without specifying their concrete classes.");

            IFurnitureFactory furnitureFactory;

            furnitureFactory = new Random().Next(0, 3) switch
            {
                0 => new ArtDecoFurnitureFactory(),
                1 => new ModernFurnitureFactory(),
                2 => new VictorianFurnitureFactory(),
                _ => throw new Exception()
            };

            Chair chair = furnitureFactory.CreateChair();
            Sofa sofa = furnitureFactory.CreateSofa();
            Table table = furnitureFactory.CreateTable();

            chair.PrintInfo();
            sofa.PrintInfo();
            table.PrintInfo();
        }
    }
}
