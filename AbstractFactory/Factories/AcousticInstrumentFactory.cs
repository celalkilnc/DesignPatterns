using AbstractFactory.ProduceInterfaces;
using AbstractFactory.Products.Acoustic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    public class AcousticInstrumentFactory : IInstrumentFactory
    {
        public IDrum ProduceDrum()
        {
            return new AcousticDrum();
        }

        public IGuitar ProduceGuitar()
        {
            return new AcousticGuitar();
        }
    }
}
