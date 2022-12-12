using lab4_Factory.Interfaces;

namespace lab4_Factory.Ingredients
{
    internal class FrozenClams : IClams
    {
        private string type = "Замороженные креветки\n";

        public string Type { get { return type; } }
    }
}
