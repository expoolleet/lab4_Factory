using lab4_Factory.PizzaFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab4_Factory.Pizzas
{
    internal class BenderCheesePizza : Pizza
    {
        public BenderCheesePizza(PizzaIngredientFactory ingredientFactory) : base(ingredientFactory) { }

        public override void Prepare()
        {
            about += IngredientFactory.CreateDough().Type;
            about += IngredientFactory.CreateSause().Type;
            about += IngredientFactory.CreateCheese().Type;
        }

        public override void Eat() => Console.WriteLine("Пицца «4 Сыра» съедена");
    }
}
