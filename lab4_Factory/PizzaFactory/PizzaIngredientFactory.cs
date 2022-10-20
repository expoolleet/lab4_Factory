using lab4_Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab4_Factory.PizzaFactory
{
    abstract class PizzaIngredientFactory
    {
        abstract public void CreateDough();
        abstract public void CreateSause();
        abstract public void CreateCheese();
        abstract public void CreateVeggies();
        abstract public void CreatePepperoni();
        abstract public void CreateClam();

    }
}
