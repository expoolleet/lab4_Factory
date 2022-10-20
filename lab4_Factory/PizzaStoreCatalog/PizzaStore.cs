using System;
using System.Collections.Generic;
using System.Text;
using lab4_Factory.Pizzas;

namespace lab4_Factory
{
    abstract class PizzaStore
    {
        public abstract Pizza CreatePizza();
    }
}
