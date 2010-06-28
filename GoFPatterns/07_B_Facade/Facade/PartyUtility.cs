using System;
using Facade.Appliances;

namespace Facade
{
    internal class PartyUtility
    {
        private readonly PopcornMaching popcornMachine;
        private readonly Lights lights;
        private readonly ProjectorScreen screen;
        private readonly LcdProjector projector;
        private readonly Amplifier amplifier;
        private readonly HdDvdPlayer dvdPlayer;
        private readonly Dvd movie;

        public PartyUtility(PopcornMaching popcornMachine, Lights lights, ProjectorScreen screen, LcdProjector projector, Amplifier amplifier, HdDvdPlayer dvdPlayer, Dvd movie)
        {
            this.popcornMachine = popcornMachine;
            this.lights = lights;
            this.screen = screen;
            this.projector = projector;
            this.amplifier = amplifier;
            this.dvdPlayer = dvdPlayer;
            this.movie = movie;
        }

        public PartyUtility(Dvd movie)
        {
            this.movie = movie;
            popcornMachine = new PopcornMaching();
            lights = new Lights();
            screen = new ProjectorScreen();
            projector = new LcdProjector();
            amplifier = new Amplifier();
            dvdPlayer = new HdDvdPlayer();
        }

        public void SwitchOn()
        {

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

        }

        public void SwitchOff()
        {
            
        }
    }
}