using lab4_Factory.Interfaces;

namespace lab4_Factory.Ingredients
{
    internal class EggplantVeggie : IVeggie
    {
        private string type = "Баклажан\n";

        public string Type { get { return type; } }
    }
}
