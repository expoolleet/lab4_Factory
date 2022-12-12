using lab4_Factory.Interfaces;

namespace lab4_Factory.Ingredients
{
    internal class ThinCrustDough : IDough
    {
        private string type = "Тесто с тонкой коркой\n";

        public string Type { get { return type; } }
    }
}
