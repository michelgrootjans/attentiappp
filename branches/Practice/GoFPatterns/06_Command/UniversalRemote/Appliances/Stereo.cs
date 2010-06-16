using System;

namespace UniversalRemote.Appliances
{
    internal class Stereo
    {
        public void SwitchOn()
        {
            Console.WriteLine("Stereo switches on.");
        }

        public void SwitchOff()
        {
            Console.WriteLine("Stereo switches on.");
        }

        public void PlayCd()
        {
            Console.WriteLine("Stereo starts playing a CD.");
        }

        public void SetVolume(int level)
        {
            Console.WriteLine("Stereo sets volume to {0}/10.", level);
        }
    }
}