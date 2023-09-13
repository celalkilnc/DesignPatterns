using AbstractFactory.ProduceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Products.Electric
{
    public class ElectricGuitar : IGuitar
    {
        public void Produce()
        {
            Console.WriteLine("Electric Guitar produced!");
        }
    }
}
