using System;
using Sim_U_Duck.Behaviors;

namespace Sim_U_Duck.Ducks
{
    public class MallardDuck : Duck
    {
        public MallardDuck() : base(new NormalQuack(), new FlyWithWings())
        {
        }

        public override void Display()
        {
            writer.Write("I'm a Mallard duck!");
        }
    }
}