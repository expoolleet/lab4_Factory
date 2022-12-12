using lab4_Factory.Interfaces;

namespace lab4_Factory.Ingredients
{
    internal class ReggianoCheese : ICheese
    {
        private string type = "Сыр реджано\n";

        public string Type { get { return type; } }
    }
}
