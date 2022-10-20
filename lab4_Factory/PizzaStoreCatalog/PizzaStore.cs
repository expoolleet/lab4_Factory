using System;
using System.Collections.Generic;
using System.Text;
using lab4_Factory.Pizzas;

namespace lab4_Factory
{
    abstract class PizzaStore
    {

        protected abstract Pizza CreatePizza(int number);
        public Pizza OrderPizza(int number)
        {
            var pizza = CreatePizza(number);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            Console.WriteLine("...\nЗаказ готов");

            return pizza;
        }
    }
}
