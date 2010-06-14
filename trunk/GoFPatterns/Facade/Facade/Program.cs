using System;
using Facade.Appliances;

namespace Facade
{
    class Program
    {
        private static readonly PopcornMaching popcornMachine = new PopcornMaching();
        private static readonly Lights lights = new Lights();
        private static readonly ProjectorScreen screen = new ProjectorScreen();
        private static readonly LcdProjector projector = new LcdProjector();
        private static readonly Amplifier amplifier = new Amplifier();

        static void Main(string[] args)
        {
            var movie = new Dvd("Harry Potter 8");

            //start making popcorn
            popcornMachine.SwitchOn();
            popcornMachine.StartPopping();

            //dim the lights
            lights.Dim(10);

            //lower the screen
            screen.Down();

            //turn projector on
            projector.On();
            var dvd = new HdDvdPlayer();
            projector.SetInput(dvd);
            projector.SetWidescreenMode();

            //switch the amp on
            amplifier.On();
            amplifier.SetSource(dvd);
            amplifier.SurroundSound = true;
            amplifier.Volume = 5;

            //play movie
            dvd.TurnOn();
            dvd.Play(movie);

            Console.ReadLine();
        }
    }
}
