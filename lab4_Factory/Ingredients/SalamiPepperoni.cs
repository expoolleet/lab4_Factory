using lab4_Factory.Interfaces;

namespace lab4_Factory.Ingredients
{
    internal class SalamiPepperoni : IPepperoni
    {
        private string type = "Салями";

        public string Type { get { return type; } }
    }
}
