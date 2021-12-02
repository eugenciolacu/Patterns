using Abstract_Factory.Products;

namespace Abstract_Factory.Factories
{
    public class ArtDecoFurnitureFactory : IFurnitureFactory
    {
        public Chair CreateChair()
        {
            return new ArtDecoChair();
        }

        public Sofa CreateSofa()
        {
            return new ArtDecoSofa();
        }

        public Table CreateTable()
        {
            return new ArtDecoTable();
        }
    }
}
