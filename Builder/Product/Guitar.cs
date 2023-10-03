using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Product
{
    internal class Guitar
    {
        public string StringMaterial { get; set; }

        public string Type { get; set; }

        public string BodyMaterial { get; set; }

        public string KeyboardMaterial { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Type:{Type}");
            Console.WriteLine($"StringMaterial:{StringMaterial}");
            Console.WriteLine($"BodyMaterial:{BodyMaterial}");
            Console.WriteLine($"KeyboardMaterial:{KeyboardMaterial}");
        }

    }
}
