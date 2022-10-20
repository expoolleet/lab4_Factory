using lab4_Factory.Pizzas;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab4_Factory.PizzaStoreCatalog
{
    internal class BenderPizzaStore : PizzaStore
    {
        Pizza pizza;

        public override Pizza CreatePizza()
        {
            Console.WriteLine("Выберете пиццу на заказ:\nПицца «4 Сыра»(1)\nПицца «Пепперони»(2)\nПицца «Креветка»(3)\nПицца «Вегетарианская»(4)");
            int number = Convert.ToInt32(Console.ReadLine());

            switch (number)
            {
                case 1:
                    pizza = new BenderCheesePizza();
                    break;
                case 2:
                    pizza = new BenderPepperoniPizza();
                    break;
                case 3:
                    pizza = new BenderClamPizza();
                    break;
                case 4:
                    pizza = new BenderVeggiePizza();
                    break;
            }

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            Console.WriteLine("...\nЗаказ готов");
            return pizza;

        }
    }
}
