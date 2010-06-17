using System;

namespace PizzaStore.Ingredients
{
    internal abstract class Cheese
    {
        protected Cheese()
        {
            Console.WriteLine("Adding {0} ...", GetType().Name);
        }
    }

    internal class MozarellaCheese : Cheese
    {
    }

    internal class ReggianoCheese : Cheese
    {
    }
}