using AbstractFactory.Factories;
using AbstractFactory.ProduceInterfaces;


//Electric Factory
IInstrumentFactory electricFactory = new ElectricInstrumentFactory();
IGuitar electricGuitar = electricFactory.ProduceGuitar();
IDrum electricDrum  = electricFactory.ProduceDrum();

Console.WriteLine("electric:");
electricGuitar.Produce();
electricDrum.Produce();


//Acoustic Factory
IInstrumentFactory acousticFactory = new AcousticInstrumentFactory();
IGuitar acousticGuitar = acousticFactory.ProduceGuitar();
IDrum acousticDrum = acousticFactory.ProduceDrum();

Console.WriteLine("acoustic:");
acousticGuitar.Produce();
acousticDrum.Produce();

Console.ReadKey();