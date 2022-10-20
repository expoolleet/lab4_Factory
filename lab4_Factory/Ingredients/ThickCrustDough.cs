using lab4_Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab4_Factory.Ingredients
{
    internal class ThickCrustDough : IDough
    {
        string type = "Тесто с толстой коркой\n";
        public string Type
        {
            get
            {
                return type;
            }      
        }
    }
}
