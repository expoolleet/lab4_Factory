using System;
using System.Collections.Generic;
using System.Text;
using lab4_Factory.Interfaces;
using lab4_Factory.PizzaFactory;

namespace lab4_Factory.Pizzas
{
    class TiraspolCheesePizza : Pizza
    {
        public TiraspolCheesePizza(PizzaIngredientFactory ingredientFactory) : base(ingredientFactory) { }


        public override void Prepare()
        {
           about += IngredientFactory.CreateDough().Type;
           about += IngredientFactory.CreateSause().Type;
           about += IngredientFactory.CreateCheese().Type;
        }

        public override void Eat() => Console.WriteLine("Пицца «4 Сыра» съедена");

    }
}
