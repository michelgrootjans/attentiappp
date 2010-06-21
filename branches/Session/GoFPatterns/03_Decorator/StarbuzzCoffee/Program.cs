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
            var order = new List<Beverage>
                             {
                                 new DarkRoastWithSteamedMilk(),
                                 new EspressoWithWhipAndMocha(),
                                 new HouseBlendWithSoy()
                             };

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
    }
}