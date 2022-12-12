using System;
using lab4_Factory.PizzaStoreCatalog;
using lab4_Factory.Pizzas;

namespace lab4_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore store = null;

            CityEnumType cityType = CityEnumType.Unknown;

            PizzaEnumType pizzaType = PizzaEnumType.Unknown;

            Console.WriteLine("В каком городе будете заказывать пиццу?\nТирасполь(1)\nБендеры(2)");

            int number = Convert.ToInt32(Console.ReadLine());

            switch (number)
            {
                case 1:
                    cityType = CityEnumType.Tiraspol;
                    break;
                case 2:
                    cityType = CityEnumType.Bender;
                    break;
            }

            switch (cityType)
            {
                case CityEnumType.Tiraspol:
                    store = new TiraspolPizzaStore();
                    break;
                case CityEnumType.Bender:
                    store = new BenderPizzaStore();
                    break;
            }

            Console.WriteLine("Выберете пиццу на заказ:\nПицца «4 Сыра»(1)\nПицца «Пепперони»(2)\nПицца «Креветка»(3)\nПицца «Вегетарианская»(4)");

            number = Convert.ToInt32(Console.ReadLine());

            switch (number)
            {
                case 1:
                    pizzaType = PizzaEnumType.CheesePizza;
                    break;
                case 2:
                    pizzaType = PizzaEnumType.PepperoniPizza;
                    break;
                case 3:
                    pizzaType = PizzaEnumType.ClamPizza;
                    break;
                case 4:
                    pizzaType = PizzaEnumType.VeggiePizza;
                    break;
            }

            try
            {
                Pizza pizza = store.OrderPizza(pizzaType);
                pizza.About();
                pizza.Eat();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }

    enum CityEnumType
    {
        Unknown,
        Tiraspol,
        Bender
    }
}
