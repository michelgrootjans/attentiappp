using System;

namespace Adapter.Animals
{
    internal class RedheadDuck : IDuck
    {
        public void Fly()
        {
            Console.WriteLine("Redhead duck: I'm flying");
        }

        public void Quack()
        {
            Console.WriteLine("Redhead duck: Quack!");
        }
    }
}