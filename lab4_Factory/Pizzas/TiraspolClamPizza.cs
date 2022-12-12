using System;
using lab4_Factory.PizzaFactory;

namespace lab4_Factory.Pizzas
{
    internal class TiraspolClamPizza : Pizza
    {
        public TiraspolClamPizza(PizzaIngredientFactory ingredientFactory) : base(ingredientFactory) { }

        public override void Prepare()
        {
            Info += IngredientFactory.CreateDough().Type;
            Info += IngredientFactory.CreateSause().Type;
            Info += IngredientFactory.CreateClams().Type;
        }

        public override void Eat() => Console.WriteLine("Пицца «Креветка» съедена");
    }
}
