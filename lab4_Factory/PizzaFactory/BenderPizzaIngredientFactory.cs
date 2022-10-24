using lab4_Factory.Ingredients;
using lab4_Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab4_Factory.PizzaFactory
{
    internal class BenderPizzaIngredientFactory : PizzaIngredientFactory
    {
        public override IDough CreateDough()
        {
            return new ThinCrustDough();
        }
        public override ISauce CreateSause()
        {
            return new MarinaraSauce();
        }
        public override ICheese CreateCheese()
        {
            return new ReggianoCheese();
        }
        public override IVeggie CreateVeggies()
        {
            return new EggplantVeggie();
        }
        public override IPepperoni CreatePepperoni()
        {
            return new SalamiPepperoni();
        }
        public override IClams CreateClams()
        {
            return new FreshClams();
        }
    }
}
