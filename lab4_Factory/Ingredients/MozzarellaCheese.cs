using lab4_Factory.Interfaces;

namespace lab4_Factory.Ingredients
{
    internal class MozzarellaCheese : ICheese
    {
        private string type = "Сыр моцарелла\n";

        public string Type { get { return type; } }
    }
}
