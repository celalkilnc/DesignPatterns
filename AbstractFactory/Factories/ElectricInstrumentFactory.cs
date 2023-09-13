using AbstractFactory.ProduceInterfaces;
using AbstractFactory.Products.Electric;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    public class ElectricInstrumentFactory : IInstrumentFactory
    {
        public IDrum ProduceDrum()
        {
            return new ElectricDrum();
        }

        public IGuitar ProduceGuitar()
        {
            return new ElectricGuitar();
        }
    }
}
