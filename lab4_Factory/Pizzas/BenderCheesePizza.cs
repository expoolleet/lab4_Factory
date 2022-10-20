using System;
using System.Collections.Generic;
using System.Text;

namespace lab4_Factory.Pizzas
{
    internal class BenderCheesePizza : Pizza
    {
        public override void Eat() => Console.WriteLine("Пицца «4 Сыра» съедена");
    }
}
