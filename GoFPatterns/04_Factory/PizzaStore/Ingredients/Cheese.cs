using System;

namespace PizzaStore.Ingredients
{
    public abstract class Cheese
    {
        protected Cheese()
        {
            Console.WriteLine("Adding {0} ...", GetType().Name);
        }
    }

    internal class MozzarellaCheese : Cheese
    {
    }

    internal class ReggianoCheese : Cheese
    {
    }
}