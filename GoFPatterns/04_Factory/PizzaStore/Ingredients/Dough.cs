using System;

namespace PizzaStore.Ingredients
{
    public class Dough
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