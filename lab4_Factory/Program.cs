using lab4_Factory.PizzaStoreCatalog;
using System;
using lab4_Factory.Pizzas;

namespace lab4_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore store = null;

            Console.WriteLine("В каком городе будете заказывать пиццу?\nТирасполь(1)\nБендеры(2)");

            int number = Convert.ToInt32(Console.ReadLine());

            switch (number)
            {
                case 1:
                    store = new TiraspolPizzaStore();
                    break;
                case 2:
                    store = new BenderPizzaStore();
                    break;
            }

            Pizza pizza = store.CreatePizza();

            pizza.Info();
            pizza.Eat();

            Console.ReadKey();
        }
    }
}
