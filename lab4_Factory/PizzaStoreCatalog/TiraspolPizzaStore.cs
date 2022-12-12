using System;
using lab4_Factory.PizzaFactory;
using lab4_Factory.Pizzas;

namespace lab4_Factory.PizzaStoreCatalog
{
    class TiraspolPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(PizzaEnumType pizzaType)
        {
            Pizza pizza;
            TisarspolPizzaIngredientFactory ingredientFactory = new TisarspolPizzaIngredientFactory();

            switch (pizzaType)
            {
                case PizzaEnumType.CheesePizza:
                    pizza = new TiraspolCheesePizza(ingredientFactory);
                    break;
                case PizzaEnumType.PepperoniPizza:
                    pizza = new TiraspolPepperoniPizza(ingredientFactory);
                    break;
                case PizzaEnumType.ClamPizza:
                    pizza = new TiraspolClamPizza(ingredientFactory);
                    break;
                case PizzaEnumType.VeggiePizza:
                    pizza = new TiraspolVeggiePizza(ingredientFactory);
                    break;
                default: throw new ArgumentOutOfRangeException(nameof(pizzaType), pizzaType, "Пиццы с таким номером нет");
            }
            return pizza;
        }
    }
}
