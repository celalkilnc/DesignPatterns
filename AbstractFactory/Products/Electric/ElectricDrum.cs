using AbstractFactory.ProduceInterfaces;

namespace AbstractFactory.Products.Electric
{
    internal class ElectricDrum : IDrum
    {
        public void Produce()
        {
            Console.WriteLine("Electric Drum produced!");
        }
    }
}
