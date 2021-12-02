using Abstract_Factory.Products;

namespace Abstract_Factory.Factories
{
    public class VictorianFurnitureFactory : IFurnitureFactory
    {
        public Chair CreateChair()
        {
            return new VictorianChair();
        }

        public Sofa CreateSofa()
        {
            return new VictorianSofa();
        }

        public Table CreateTable()
        {
            return new VictorianTable();
        }
    }
}
