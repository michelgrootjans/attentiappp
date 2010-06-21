using System;
using Sim_U_Duck.Ducks;

namespace Sim_U_Duck
{
    public class DuckTest
    {
        public static void Main()
        {
            TestDuck(new MallardDuck());
            TestDuck(new RedHeadDuck());

            Console.ReadLine();
        }

        private static void TestDuck(Duck duck)
        {
            Console.WriteLine("*** {0} ***", duck.GetType().Name);
            duck.Display();
            duck.Quack();
            Console.WriteLine();
        }
    }
}