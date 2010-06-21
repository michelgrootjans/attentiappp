using System;

namespace PizzaStore.Ingredients
{
    internal class Sauce
    {
        public Sauce()
        {
            Console.WriteLine("Adding {0} ...", GetType().Name);
        }
    }

    internal class MarinaraSauce : Sauce
    {
    }

    internal class PlumTomateSauce : Sauce
    {
    }
}