using System;
using PizzaStore.Pizzas;

namespace PizzaStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza = null;
            try
            {
                Console.Write("What kind of pizza would you like: ");
                pizza = OrderPizza(Console.ReadLine());
                Console.WriteLine("Your {0} is ready.", pizza.Name);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();

        }

        private static Pizza OrderPizza(string type)
        {
            Pizza pizza = null;
            if (type == "cheese")
            {
                pizza = new CheesePizza();
            }
            else if(type == "greek")
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
