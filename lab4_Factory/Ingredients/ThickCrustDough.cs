using lab4_Factory.Interfaces;

namespace lab4_Factory.Ingredients
{
    internal class ThickCrustDough : IDough
    {
        private string type = "Тесто с толстой коркой\n";

        public string Type { get { return type; } }
    }
}
