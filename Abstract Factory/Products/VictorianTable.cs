namespace Abstract_Factory.Products
{
    public class VictorianTable : Table
    {
        public override void PrintInfo()
        {
            System.Console.WriteLine("This is a Victorian style table");
        }
    }
}
