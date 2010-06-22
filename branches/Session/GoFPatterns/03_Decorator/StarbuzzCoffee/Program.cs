using System;
using System.Collections.Generic;
using System.Linq;
using StarbuzzCoffee.Beverages;

namespace StarbuzzCoffee
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Create orders
            var order = CreateOrder();

            Console.WriteLine("Your order:");
            Console.WriteLine("---------------------------------------");
            //Calculate price
            foreach (var beverage in order)
            {
                Console.WriteLine("{0}\t{1}", beverage.Cost, beverage.Description);
            }
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("{0}\tTotal", order.Sum(b => b.Cost));
            Console.ReadLine();
        }

        private static List<Beverage> CreateOrder()
        {
            return new List<Beverage>
                       {
                           new BeverageLogger(new SteamedMilk(new DarkRoast())),
                           new Mocha(new Whip(new Espresso()))
                       };
        }
    }
}