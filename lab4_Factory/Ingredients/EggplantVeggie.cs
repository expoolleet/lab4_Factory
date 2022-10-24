using lab4_Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab4_Factory.Ingredients
{
    internal class EggplantVeggie : IVeggie
    {
        string type = "Баклажан\n";
        public string Type { get { return type; } }
    }
}
