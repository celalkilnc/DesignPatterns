using Builder.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Directors
{
    internal class GuitarDirector
    {
        private IGuitarBuilder guitarBuilder;

        public GuitarDirector(IGuitarBuilder guitarBuilder)
        {
            this.guitarBuilder = guitarBuilder;
        }

        public void BuildGuitar()
        {
            guitarBuilder.SetStringMaterial();
            guitarBuilder.SetKeyboardMaterial();
            guitarBuilder.SetBodyMaterial();
            guitarBuilder.SetType();
        }
    }
}
