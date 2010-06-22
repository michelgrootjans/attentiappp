using System;

namespace Sim_U_Duck.Behaviors
{
    public class FlyNoWay : IFlyBehavior
    {

        public void Fly()
        {

            Console.WriteLine("Oeps, I can't fly.");
        }

    }
}