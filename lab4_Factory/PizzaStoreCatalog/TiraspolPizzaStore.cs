using System;
using System.Collections.Generic;
using System.Text;
using lab4_Factory.Pizza;

namespace lab4_Factory.PizzaStoreCatalog
{
    class TiraspolPizzaStore : PizzaStore
    {
        public override void CreatePizza()
        {
            var pizza = new TiraspolCheesePizza();
        }
    }
}
