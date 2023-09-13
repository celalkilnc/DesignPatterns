using FactoryMethod.Instruments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factories
{
    public class GuitarFactory : IInstrumentFactory
    {
        public IInstrument CreateInstrument()
        {
            return new Guitar();
        }
    }
}
