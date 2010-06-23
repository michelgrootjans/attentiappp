using System;

namespace PizzaStore
{
    internal static class Program
    {
        private static void Main()
        {
            try
            {
                Pizzeria pizzeria = new NYStylePizzeria();
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