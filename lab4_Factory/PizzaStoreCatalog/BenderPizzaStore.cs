using System;
using lab4_Factory.PizzaFactory;
using lab4_Factory.Pizzas;

namespace lab4_Factory.PizzaStoreCatalog
{
    internal class BenderPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(PizzaEnumType pizzaType)
        {
            Pizza pizza;
            BenderPizzaIngredientFactory ingredientFactory = new BenderPizzaIngredientFactory();

            switch (pizzaType)
            {
                case PizzaEnumType.CheesePizza:
                    pizza = new BenderCheesePizza(ingredientFactory);
                    break;
                case PizzaEnumType.PepperoniPizza:
                    pizza = new BenderPepperoniPizza(ingredientFactory);
                    break;
                case PizzaEnumType.ClamPizza:
                    pizza = new BenderClamPizza(ingredientFactory);
                    break;
                case PizzaEnumType.VeggiePizza:
                    pizza = new BenderVeggiePizza(ingredientFactory);
                    break;
                default: throw new ArgumentOutOfRangeException(nameof(pizzaType), pizzaType, "Пиццы с таким номером нет");
            }
            return pizza;
        } 
    }
}
