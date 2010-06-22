using System;
using Sim_U_Duck.Behaviors;

namespace Sim_U_Duck.Ducks
{
    public class DecoyDuck : Duck
    {
        public DecoyDuck(): base(new MutedQuack(), new FlyNoWay())
        {
        }

        public override void Display()
        {
            writer.Write("I'm a wooden decoy duck.");
        }
    }
}