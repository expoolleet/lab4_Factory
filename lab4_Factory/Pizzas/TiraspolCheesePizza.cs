using System;
using lab4_Factory.PizzaFactory;

namespace lab4_Factory.Pizzas
{
    internal class TiraspolCheesePizza : Pizza
    {
        public TiraspolCheesePizza(PizzaIngredientFactory ingredientFactory) : base(ingredientFactory) { }

        public override void Prepare()
        {
            Info += IngredientFactory.CreateDough().Type;
            Info += IngredientFactory.CreateSause().Type;
            Info += IngredientFactory.CreateCheese().Type;
        }

        public override void Eat() => Console.WriteLine("Пицца «4 Сыра» съедена");
    }
}
