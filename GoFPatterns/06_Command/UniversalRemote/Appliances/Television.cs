using System;

namespace UniversalRemote.Appliances
{
    internal class Television
    {
        public void On()
        {
            Console.WriteLine("Television switches on.");
        }

        public void Off()
        {
            Console.WriteLine("Television switches off.");
        }

        public void SetChannel(int channelNumber)
        {
            Console.WriteLine("Television switches to channel {0}.", channelNumber);
        }
    }
}