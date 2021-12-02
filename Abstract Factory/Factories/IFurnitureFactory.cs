using Abstract_Factory.Products;

namespace Abstract_Factory.Factories
{
    interface IFurnitureFactory
    {
        Chair CreateChair();
        Sofa CreateSofa();
        Table CreateTable();
    }
}
