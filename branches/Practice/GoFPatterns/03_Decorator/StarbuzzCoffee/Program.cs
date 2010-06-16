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
            var orders = new List<Beverage>
                             {
                                 new DarkRoastWithSteamedMilk(),
                                 new EspressoWithWhipAndMocha(),
                                 new HouseBlendWithSoy()
                             };

            //Calculate price
            foreach (var beverage in orders)
            {
                Console.WriteLine("{0}\t{1}", beverage.Cost, beverage.Description);
            }
            Console.WriteLine("{0}\tTotal", orders.Sum(b => b.Cost));
            Console.ReadLine();
        }
    }
}