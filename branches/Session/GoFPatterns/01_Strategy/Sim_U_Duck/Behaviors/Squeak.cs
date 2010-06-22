using System;
using Sim_U_Duck.Ducks;

namespace Sim_U_Duck.Behaviors
{
    public class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}