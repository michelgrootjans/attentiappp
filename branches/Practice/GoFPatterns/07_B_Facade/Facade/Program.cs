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
        private static readonly HdDvdPlayer dvdPlayer = new HdDvdPlayer();

        static void Main()
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
            projector.SetInput(dvdPlayer);
            projector.SetWidescreenMode();

            //switch the amp on
            amplifier.On();
            amplifier.SetVideoSource(dvdPlayer);
            amplifier.SurroundSound = true;
            amplifier.Volume = 5;

            //play movie
            dvdPlayer.TurnOn();
            dvdPlayer.Play(movie);

            Console.ReadLine();
        }
    }
}
