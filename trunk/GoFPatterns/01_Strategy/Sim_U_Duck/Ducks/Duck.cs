using System;

namespace Sim_U_Duck.Ducks
{
    public abstract class Duck
    {
        public abstract void Display();

        public virtual void Quack()
        {
            Console.WriteLine("Quack!");
        }
    }

    public class MallardDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("I'm a Mallard duck!");
        }
    }

    public class RedHeadDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("Hi! I'm a Redhead duck.");
        }
    }
}