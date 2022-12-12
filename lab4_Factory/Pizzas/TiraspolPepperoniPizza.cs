using System;
using lab4_Factory.PizzaFactory;

namespace lab4_Factory.Pizzas
{
    internal class TiraspolPepperoniPizza : Pizza
    {    
        public TiraspolPepperoniPizza(PizzaIngredientFactory ingredientFactory) : base(ingredientFactory) { }

        public override void Prepare()
        {
            Info += IngredientFactory.CreateDough().Type;
            Info += IngredientFactory.CreateSause().Type;
            Info += IngredientFactory.CreatePepperoni().Type;
        }

        public override void Eat() => Console.WriteLine("Пицца «Пепперони» съедена");
    }
}
