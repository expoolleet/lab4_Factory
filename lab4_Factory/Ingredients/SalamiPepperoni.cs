using lab4_Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab4_Factory.Ingredients
{
    internal class SalamiPepperoni : IPepperoni
    {
        string type = "Салями";
        public string Type { get { return type; } }
    }
}
