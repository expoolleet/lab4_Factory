using System;
using System.Collections.Generic;
using System.Text;
using lab4_Factory.PizzaFactory;

namespace lab4_Factory.Pizzas
{
    class TiraspolCheesePizza : Pizza
    {
        TisarspolPizzaIngredientFactory ingredientFactory = new TisarspolPizzaIngredientFactory();

        public override void Prepare()
        {
            ingredientFactory.CreateDough();
        }

        public override void Eat() => Console.WriteLine("Пицца «4 Сыра» съедена");

        public override void Info()
        {
            Console.WriteLine($"{ingredientFactory.Pizza}");
        }
    }
}
