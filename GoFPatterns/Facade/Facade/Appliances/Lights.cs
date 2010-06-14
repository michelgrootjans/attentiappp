using System;

namespace Facade.Appliances
{
    internal class Lights
    {
        public void Dim(int level)
        {
            Console.WriteLine("Dimming lights to {0}%", level);
        }
    }
}