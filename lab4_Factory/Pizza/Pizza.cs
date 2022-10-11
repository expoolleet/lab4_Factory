using System;
using System.Collections.Generic;
using System.Text;

namespace lab4_Factory.Pizza
{
    abstract class Pizza
    {
        public abstract void Prepare();

        public abstract void Bake();

        public abstract void Cut();

        public abstract void Box();

    }
}
