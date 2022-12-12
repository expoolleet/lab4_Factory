using lab4_Factory.Interfaces;

namespace lab4_Factory.Ingredients
{
    internal class FreshClams : IClams
    {
        private string type = "Свежие креветки\n";

        public string Type { get { return type; } }
    }
}
