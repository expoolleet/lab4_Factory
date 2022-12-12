using lab4_Factory.Interfaces;

namespace lab4_Factory.Ingredients
{
    internal class MarinaraSauce : ISauce
    {
        private string type = "Соус маринара\n";

        public string Type { get { return type; } }
    }
}
