using System;
using System.Collections.Generic;
using System.Threading;
using PizzaStore.Ingredients;

namespace PizzaStore.Pizzas
{
    public abstract class Pizza
    {
        public string Name { get; protected set; }
        protected Dough dough;
        protected Sauce sauce;
        private readonly IList<Veggie> veggies = new List<Veggie>();
        protected Cheese cheese;

        public void Prepare()
        {
            Console.WriteLine("Preparing {0}", Name);
            Thread.Sleep(500);
            Console.WriteLine("Tossing {0}...", dough);
            Thread.Sleep(500);
            Console.WriteLine("Adding {0}...", sauce);
            Thread.Sleep(500);
            Console.WriteLine("Adding vegetables...");
            Thread.Sleep(500);
            Console.WriteLine("Adding {0}...", cheese);
            Thread.Sleep(500);
            foreach (var veggie in veggies)
            {
                Console.WriteLine("- " + veggie);
                Thread.Sleep(500);
            }
        }

        public void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 250°C");
            Thread.Sleep(2000);
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
            Thread.Sleep(500);
        }

        public void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
            Thread.Sleep(500);
        }

        protected void Add(Veggie veggie)
        {
            veggies.Add(veggie);
        }
    }
}