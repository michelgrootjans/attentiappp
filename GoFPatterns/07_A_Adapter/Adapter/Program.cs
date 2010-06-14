using System;
using System.Collections.Generic;
using Adapter.Animals;

namespace Adapter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var ducks = new List<IDuck>
                            {
                                new MallardDuck(),
                                new RedheadDuck()
                            };

            var turkey = new WildTurkey();

            foreach (var duck in ducks)
            {
                duck.Fly();
                duck.Quack();
            }

            turkey.Fly();
            turkey.Gobble();

            Console.ReadLine();
        }
    }
}