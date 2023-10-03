using Builder.Builder;
using Builder.Directors;
using Builder.Product;

IGuitarBuilder guitarBuilder = new ClassicGuitarBuilder();

var guitarDirector = new GuitarDirector(guitarBuilder);

guitarDirector.BuildGuitar();

Guitar guitar = guitarBuilder.GetGuitar();

guitar.DisplayInfo();

Console.ReadKey();