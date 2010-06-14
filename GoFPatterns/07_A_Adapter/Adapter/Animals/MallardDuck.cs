using System;

namespace Adapter.Animals
{
    internal class MallardDuck : IDuck
    {
        public void Fly()
        {
            Console.WriteLine("Mallard duck: I'm flying");
        }

        public void Quack()
        {
            Console.WriteLine("Mallard duck: Quack! (with a mallard accent)");
        }
    }
}