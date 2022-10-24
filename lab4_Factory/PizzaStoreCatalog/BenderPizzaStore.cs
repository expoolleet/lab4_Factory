using lab4_Factory.PizzaFactory;
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
            BenderPizzaIngredientFactory ingredientFactory = new BenderPizzaIngredientFactory();

            switch (number)
            {
                case 1:
                    pizza = new BenderCheesePizza(ingredientFactory);
                    break;
                case 2:
                    pizza = new BenderPepperoniPizza(ingredientFactory);
                    break;
                case 3:
                    pizza = new BenderClamPizza(ingredientFactory);
                    break;
                case 4:
                    pizza = new BenderVeggiePizza(ingredientFactory);
                    break;
                default: throw new ArgumentOutOfRangeException(nameof(number), number, "Пиццы с таким номером нет");
            }
            return pizza;
        }
    }
}
