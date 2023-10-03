using Builder.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
{
    internal interface IGuitarBuilder
    {
        void SetType();
        
        void SetKeyboardMaterial();
        
        void SetBodyMaterial();

        void SetStringMaterial();

        Guitar GetGuitar();
    }
}
