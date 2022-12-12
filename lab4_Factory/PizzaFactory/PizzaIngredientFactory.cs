using lab4_Factory.Interfaces;

namespace lab4_Factory.PizzaFactory
{
    abstract class PizzaIngredientFactory
    {
        abstract public IDough CreateDough();
        abstract public ISauce CreateSause();
        abstract public ICheese CreateCheese();
        abstract public IVeggie CreateVeggies();
        abstract public IPepperoni CreatePepperoni();
        abstract public IClams CreateClams();
    }
}
