using Abstract_Factory.Products;

namespace Abstract_Factory.Factories
{
    public class ModernFurnitureFactory : IFurnitureFactory
    {
        public Chair CreateChair()
        {
            return new ModernChair();
        }

        public Sofa CreateSofa()
        {
            return new ModernSofa();
        }

        public Table CreateTable()
        {
            return new ModernTable();
        }
    }
}
