using lab4_Factory.Ingredients;
using lab4_Factory.Interfaces;

namespace lab4_Factory.PizzaFactory
{
    internal class TisarspolPizzaIngredientFactory : PizzaIngredientFactory
    {
        public override IDough CreateDough()
        {
            return new ThickCrustDough();
        }
        public override ISauce CreateSause()
        {
            return new PlumTomatoSauce();
        }
        public override ICheese CreateCheese()
        {
            return new MozzarellaCheese();
        }
        public override IVeggie CreateVeggies()
        {
            return new BellPepperVeggie();
        }
        public override IPepperoni CreatePepperoni()
        {
            return new SalamiPepperoni();
        }
        public override IClams CreateClams()
        {
            return new FrozenClams();
        }
    }
}
