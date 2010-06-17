using System;

namespace PizzaStore
{
    internal class Program
    {
        private static void Main()
        {
            try
            {
                var pizzeria = new DependentPizzeria();
                var pizza = pizzeria.OrderPizza("NY", "cheese");

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