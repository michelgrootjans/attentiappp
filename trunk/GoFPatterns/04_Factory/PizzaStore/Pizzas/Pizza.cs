using System;
using System.Collections.Generic;
using System.Threading;

namespace PizzaStore.Pizzas
{
    public abstract class Pizza
    {
        public string Name { get; protected set; }
        protected string dough;
        protected string sauce;
        protected readonly ICollection<string> toppings = new List<string>();

        public void Prepare()
        {
            Console.WriteLine("Preparing {0}", Name);
            Thread.Sleep(500);
            Console.WriteLine("Tossing {0}...", dough);
            Thread.Sleep(500);
            Console.WriteLine("Adding {0}...", sauce);
            Thread.Sleep(500);
            Console.WriteLine("Adding toppings...");
            foreach (var topping in toppings)
            {
                Console.WriteLine("- " + topping);
            }
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