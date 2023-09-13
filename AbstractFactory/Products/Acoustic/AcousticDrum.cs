using AbstractFactory.ProduceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Products.Acoustic
{
    public class AcousticDrum : IDrum
    {
        public void Produce()
        {
            Console.WriteLine("Acoustic Drum produced!");
        }
    }
}
