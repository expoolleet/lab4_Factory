using System;
using System.Collections.Generic;
using System.Text;

namespace lab4_Factory.Pizzas
{
    class Pizza
    {
        public virtual void Prepare() => Console.WriteLine("Пицца приготовлена");

        public void Bake() => Console.WriteLine("Пицца запечена");

        public void Cut() => Console.WriteLine("Пицца разрезана");

        public void Box() => Console.WriteLine("Пицца упакована");

        public virtual void Eat() => Console.WriteLine("Пицца съедена");

        public virtual void Info() { }

    }
}
