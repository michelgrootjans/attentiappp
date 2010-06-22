using System;
using System.Collections.Generic;
using Adapter.Animals;

namespace Adapter
{
    internal static class Program
    {
        private static void Main()
        {
            var ducks = new List<IDuck>
                            {
                                new MallardDuck(),
                                new RedheadDuck(),
                                new TurkeyAdapter(new WildTurkey())
                            };

            foreach (var duck in ducks)
            {
                duck.Fly();
                duck.Quack();
            }

            Console.ReadLine();
        }
    }
}