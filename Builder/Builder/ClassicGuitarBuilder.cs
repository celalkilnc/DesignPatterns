using Builder.Product;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
{
    internal class ClassicGuitarBuilder : IGuitarBuilder
    {
        private Guitar guitar = new Guitar();

        public void SetBodyMaterial()
        {
            guitar.BodyMaterial = "Ebony";
        }

        public void SetKeyboardMaterial()
        {
            guitar.KeyboardMaterial = "Rosewood";
        }

        public void SetStringMaterial()
        {
            guitar.StringMaterial = "Plastic";
        }

        public void SetType()
        {
            guitar.Type = "Classic";
        }

        public Guitar GetGuitar()
        {
            return guitar;
        }
    }
}
