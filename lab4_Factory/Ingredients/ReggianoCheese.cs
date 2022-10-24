using lab4_Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab4_Factory.Ingredients
{
    internal class ReggianoCheese : ICheese
    {
        string type = "Сыр реджано\n";
        public string Type { get { return type; } }
    }
}
