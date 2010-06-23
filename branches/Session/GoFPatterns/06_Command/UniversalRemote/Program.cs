using System;
using UniversalRemote.Appliances;
using UniversalRemote.Commands;

namespace UniversalRemote
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                var outdoorLight = new OutdoorLight();
                var ceilingLight = new CeilingLight();
                var ceilingLightCommand = new CeilingLightCommand(ceilingLight);
                var stereo = new Stereo();
                var tv = new Television();

                var remote = new Remote();

                remote.RegisterCommand(
                    new OutdoorLightOnCommand(outdoorLight), 
                    new OutdoorLightOffCommand(outdoorLight));

                remote.RegisterCommand(
                    ceilingLightCommand,
                    ceilingLightCommand);

                remote.RegisterCommand(
                    new PlayCDCommand(stereo, 6),
                    new StereoOffCommand(stereo));
                remote.RegisterCommand(
                    new PlayTvCommand(tv, 1),
                    new TvOffCommand(tv));

                //Console.Write("What button do you want to press:");
                
                remote.On(0);
                remote.On(2);
                remote.On(3);
                remote.Undo();
                remote.Undo();
                remote.Undo();
                remote.Undo();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}