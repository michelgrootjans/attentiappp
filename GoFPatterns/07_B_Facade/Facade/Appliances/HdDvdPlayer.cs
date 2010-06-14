using System;

namespace Facade.Appliances
{
    internal class HdDvdPlayer : IVideoSource, IProjectorInput
    {
        public void TurnOn()
        {
            Console.WriteLine(Name + " is switched on");
        }

        public void Play(IMovie movie)
        {
            Console.WriteLine(Name + " is playing " + movie.Name);
        }

        public string Name
        {
            get { return "HD Dvd Player"; }
        }
    }
}