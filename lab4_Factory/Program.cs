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

            Console.WriteLine("Выберете пиццу на заказ:\nПицца «4 Сыра»(1)\nПицца «Пепперони»(2)\nПицца «Креветка»(3)\nПицца «Вегетарианская»(4)");
            number = Convert.ToInt32(Console.ReadLine());
            try
            {
                Pizza pizza = store.OrderPizza(number);
                pizza.Info();
                pizza.Eat();
            }
            catch(Exception ex) { Console.WriteLine(ex.Message); }
           

          

            Console.ReadKey();
        }
    }
}
