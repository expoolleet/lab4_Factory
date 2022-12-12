using System;
using lab4_Factory.Pizzas;
using lab4_Factory.PizzaStoreCatalog;

namespace lab4_Factory
{
    abstract class PizzaStore
    {
        protected abstract Pizza CreatePizza(PizzaEnumType pizzaType);
        public Pizza OrderPizza(PizzaEnumType pizzaType)
        {
            var pizza = CreatePizza(pizzaType);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            Console.WriteLine("...\nЗаказ готов");

            return pizza;
        }
    }
}
