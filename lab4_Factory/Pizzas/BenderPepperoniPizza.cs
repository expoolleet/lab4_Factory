using lab4_Factory.PizzaFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab4_Factory.Pizzas
{
    internal class BenderPepperoniPizza : Pizza
    {
        public BenderPepperoniPizza(PizzaIngredientFactory ingredientFactory) : base(ingredientFactory) { }

        public override void Prepare()
        {
            IngredientFactory.CreateDough();
            IngredientFactory.CreateSause();
            IngredientFactory.CreatePepperoni();
        }
        public override void Eat() => Console.WriteLine("Пицца «Пепперони» съедена");
    }
}
