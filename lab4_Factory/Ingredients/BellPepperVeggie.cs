using lab4_Factory.Interfaces;

namespace lab4_Factory.Ingredients
{
    internal class BellPepperVeggie : IVeggie
    {
        private string type = "Сладкий перец";

        public string Type { get { return type; } }
    }
}
