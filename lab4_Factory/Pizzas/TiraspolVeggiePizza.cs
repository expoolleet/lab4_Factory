using System;
using lab4_Factory.PizzaFactory;

namespace lab4_Factory.Pizzas
{
    internal class TiraspolVeggiePizza : Pizza
    {
        public TiraspolVeggiePizza(PizzaIngredientFactory ingredientFactory) : base(ingredientFactory) { }

        public override void Prepare()
        {
            Info += IngredientFactory.CreateDough().Type;
            Info += IngredientFactory.CreateSause().Type;
            Info += IngredientFactory.CreateVeggies().Type;
        }

        public override void Eat() => Console.WriteLine("Пицца «Вегетарианская» съедена");
    }
}

