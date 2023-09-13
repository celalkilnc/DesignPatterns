using AbstractFactory.ProduceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Products.Acoustic
{
    public class AcousticGuitar : IGuitar
    {
        public void Produce()
        {
            Console.WriteLine("Acoustic Guitar produced!");
        }
    }
}
