using System;
using PizzaStore.Pizzas;

namespace PizzaStore
{
    internal class Pizzeria
    {
        public Pizza OrderPizza(string type)
        {
            Pizza pizza;
            if (type == "cheese")
            {
                pizza = new CheesePizza();
            }
            else if (type == "greek")
            {
                pizza = new GreekPizza();
            }
            else if (type == "pepperoni")
            {
                pizza = new PepperoniPizza();
            }
            else
            {
                throw new ArgumentException(string.Format("Unknown pizza type: {0}", type));
            }

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }
    }
}