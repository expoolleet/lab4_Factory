using System;
using lab4_Factory.PizzaFactory;

namespace lab4_Factory.Pizzas
{
    abstract class Pizza
    {
        public string Info { get; protected set; } = "\nВ пицце содержится:\n";

        protected PizzaIngredientFactory IngredientFactory { get; }

        public Pizza(PizzaIngredientFactory ingredientFactory)
        {
            IngredientFactory = ingredientFactory;
        }

        abstract public void Prepare();

        public void Bake() => Console.WriteLine("Пицца запечена");

        public void Cut() => Console.WriteLine("Пицца разрезана");

        public void Box() => Console.WriteLine("Пицца упакована");

        abstract public void Eat();

        public void About()
        {
            Console.WriteLine(Info);
        }
    }

    public enum PizzaEnumType
    {
        Unknown,
        CheesePizza,
        PepperoniPizza,
        ClamPizza,
        VeggiePizza
    }
}
