using System;
using System.Collections.Generic;
using System.Text;

namespace lab4_Factory.Pizzas
{
    internal class BenderClamPizza : Pizza 
    {
        public override void Eat() => Console.WriteLine("Пицца «Креветка» съедена");
    }
}
