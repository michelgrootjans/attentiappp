using System;
using UniversalRemote.Appliances;

namespace UniversalRemote
{
    internal class OutdoorLightOffCommand : ICommand, IOffCommand
    {
        private readonly OutdoorLight outdoorLight;

        public OutdoorLightOffCommand(OutdoorLight outdoorLight)
        {
            this.outdoorLight = outdoorLight;
        }

        public void Execute()
        {
            outdoorLight.Off();
        }

        public void Undo()
        {
            outdoorLight.On();
        }
    }
}