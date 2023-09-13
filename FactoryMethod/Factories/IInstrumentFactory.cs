using FactoryMethod.Instruments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factories
{
    public interface IInstrumentFactory
    {
        public IInstrument CreateInstrument();
    }
}
