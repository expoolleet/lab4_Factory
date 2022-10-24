using System;
using System.Collections.Generic;
using System.Text;
using lab4_Factory.PizzaFactory;
using lab4_Factory.Pizzas;

namespace lab4_Factory.PizzaStoreCatalog
{
    class TiraspolPizzaStore : PizzaStore
    {


        protected override Pizza CreatePizza(int number)
        {
            Pizza pizza;
            TisarspolPizzaIngredientFactory ingredientFactory = new TisarspolPizzaIngredientFactory();
            switch (number)
            {
                case 1:
                    pizza = new TiraspolCheesePizza(ingredientFactory);
                    break;
                case 2:
                    pizza = new TiraspolPepperoniPizza(ingredientFactory);
                    break;
                case 3:
                    pizza = new TiraspolClamPizza(ingredientFactory);
                    break;
                case 4:
                    pizza = new TiraspolVeggiePizza(ingredientFactory);
                    break;
                default: throw new ArgumentOutOfRangeException(nameof(number), number, "Пиццы с таким номером нет");

            }
            return pizza;

        }
    }
}
