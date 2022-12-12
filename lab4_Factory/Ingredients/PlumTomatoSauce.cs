﻿using lab4_Factory.Interfaces;

namespace lab4_Factory.Ingredients
{
    internal class PlumTomatoSauce : ISauce
    {
        private string type = "Cливово-томатный соус\n";

        public string Type { get { return type; } }
    }
}
