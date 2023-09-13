using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Instruments
{
    public class Drum : IInstrument
    {
        public void Produce()
        {
            Console.WriteLine("Drum produced.");
        }
    }
}
