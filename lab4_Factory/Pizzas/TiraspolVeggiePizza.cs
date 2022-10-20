using System;
using System.Collections.Generic;
using System.Text;

namespace lab4_Factory.Pizzas
{
    internal class TiraspolVeggiePizza : Pizza
    {
        public override void Eat() => Console.WriteLine("Пицца «Вегетарианская» съедена");
    }
}
