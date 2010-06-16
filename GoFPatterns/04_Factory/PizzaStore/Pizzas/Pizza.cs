using System;
using System.Threading;

namespace PizzaStore.Pizzas
{
    internal abstract class Pizza
    {
        public abstract string Name { get; }

        public void Prepare()
        {
            Console.WriteLine("Preparing {0}", Name);
            Thread.Sleep(500);
            Console.WriteLine("Tossing dough...");
            Thread.Sleep(500);
            Console.WriteLine("Adding sauce...");
            Thread.Sleep(500);
            Console.WriteLine("Adding toppings...");
            Thread.Sleep(500);
        }

        public void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 250°C");
            Thread.Sleep(2000);
        }

        public void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
            Thread.Sleep(500);
        }

        public void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
            Thread.Sleep(500);
        }
    }
}