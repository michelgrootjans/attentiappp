using System;

namespace PizzaStore
{
    internal abstract class Pizza
    {
        public abstract string Name { get; }

        public void Prepare()
        {
            Console.WriteLine("Preparing {0}", Name);
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding toppings...");
        }

        public void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 250°C");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public void Box()
        {
            Console.WriteLine("Place pissa in official PizzaStore box");
        }
    }
}