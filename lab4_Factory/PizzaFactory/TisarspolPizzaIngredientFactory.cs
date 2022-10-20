using lab4_Factory.Ingredients;
using lab4_Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab4_Factory.PizzaFactory
{
    class TisarspolPizzaIngredientFactory : PizzaIngredientFactory
    {


        public override IDough CreateDough() 
        {
             return new ThickCrustDough();
        }
        public override void CreateSause() { }
        public override void CreateCheese() { }
        public override void CreateVeggies() { }
        public override void CreatePepperoni() { }
        public override void CreateClam() { }

    }
}
