using System;
using Sim_U_Duck.Behaviors;

namespace Sim_U_Duck.Ducks
{
    public class RubberDuck : Duck
    {
        public RubberDuck() : base(new Squeak(), new FlyNoWay())
        {
        }

        public override void Display()
        {
            writer.Write("Hi there! I'm a rubber duck.");
        }
    }
}