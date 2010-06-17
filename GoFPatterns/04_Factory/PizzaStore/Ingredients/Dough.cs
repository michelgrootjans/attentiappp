using System;

namespace PizzaStore.Ingredients
{
    internal class Dough
    {
        public Dough()
        {
            Console.WriteLine("Tossing {0} ...", GetType().Name);
        }
    }

    internal class ThickCrustDough : Dough
    {
    }

    internal class ThinCrustDough : Dough
    {
    }
}