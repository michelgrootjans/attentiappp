using System;

namespace PizzaStore
{
    internal class Program
    {
        private static void Main()
        {
            try
            {
                Console.Write("What kind of pizza would you like: ");

                var pizzeria = new Pizzeria();
                var pizza = pizzeria.OrderPizza(Console.ReadLine());

                Console.WriteLine("Your {0} is ready.", pizza.Name);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}