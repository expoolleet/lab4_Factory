using lab4_Factory.Pizzas;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab4_Factory.PizzaStoreCatalog
{
    internal class BenderPizzaStore : PizzaStore
    {


        protected override Pizza CreatePizza(int number)
        {
            Pizza pizza;

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
                default: throw new ArgumentOutOfRangeException(nameof(number), number, "Пиццы с таким номером нет");
            }

            return pizza;
        }
    }
}
