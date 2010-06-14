using System;

namespace Facade.Appliances
{
    internal class Amplifier
    {
        public void On()
        {
            Console.WriteLine("Amplifier turns on");
        }

        public void SetSource(IVideoSource source)
        {
            Console.WriteLine("Amplifier source set to " + source.Name);
        }

        public bool SurroundSound { get; set; }

        public int Volume { get; set; }
    }
}