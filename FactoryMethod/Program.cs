using FactoryMethod.Factories;
using FactoryMethod.Instruments;

var guitarFac = new GuitarFactory();
IInstrument guitar = guitarFac.CreateInstrument();
guitar.Produce();

var drumFac = new DrumFactory();
IInstrument drum = drumFac.CreateInstrument();
drum.Produce();

Console.ReadKey();