﻿using lab4_Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab4_Factory.Ingredients
{
    internal class FrozenClams : IClams
    {
        string type = "Замороженные креветки\n";
        public string Type { get { return type; } }
    }
}
