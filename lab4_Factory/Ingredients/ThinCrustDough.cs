using lab4_Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab4_Factory.Ingredients
{
    internal class ThinCrustDough : IDough
    {
        string type = "Тесто с тонкой коркой\n";

        public string Type { get { return type; } }
    }
}
