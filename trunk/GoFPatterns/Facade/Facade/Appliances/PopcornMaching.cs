using System;

namespace Facade.Appliances
{
    internal class PopcornMaching
    {
        public void SwitchOn()
        {
            Console.WriteLine("Popcorn machine switches on");
        }

        public void StartPopping()
        {
            Console.WriteLine("Popcorn machine starts popping popcorn");
        }
    }
}