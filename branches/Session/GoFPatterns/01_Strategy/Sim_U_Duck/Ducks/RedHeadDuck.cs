using System;
using Sim_U_Duck.Behaviors;

namespace Sim_U_Duck.Ducks
{
    public class RedHeadDuck : Duck
    {
        public RedHeadDuck() : base(new NormalQuack(), new FlyWithWings())
        {
        }

        public RedHeadDuck(IWriter writer) : base(writer, new NormalQuack(writer), new FlyWithWings())
        {
        }

        public override void Display()
        {
            writer.Write("Hi! I'm a Redhead duck.");
        }
    }
}