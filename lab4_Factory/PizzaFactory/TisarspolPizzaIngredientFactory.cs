using lab4_Factory.Ingredients;
using lab4_Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab4_Factory.PizzaFactory
{
    class TisarspolPizzaIngredientFactory : PizzaIngredientFactory
    {
        string pizza = "Пицца содержит в себе:\n";

        public string Pizza 
        { 
            get
            { 
                return pizza;
            } 
        } 

        public override void CreateDough() 
        {
             pizza  += new ThickCrustDough().Type;
        }
        public override void CreateSause() { }
        public override void CreateCheese() { }
        public override void CreateVeggies() { }
        public override void CreatePepperoni() { }
        public override void CreateClam() { }

    }
}
