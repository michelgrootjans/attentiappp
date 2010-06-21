using System;

namespace Sim_U_Duck.Ducks
{
    public class RubberDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("Hi there! I'm a rubber duck.");
        }

        public override void Quack( )
        {
            Console.WriteLine("Squeak");
        }
    }

    public class DecoyDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("I'm a wooden decoy duck.");
        }

        public override void Quack( )
        {
            Console.WriteLine("--- can't make a sound");
        }
    }
}