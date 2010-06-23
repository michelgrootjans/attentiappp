using System;
using UniversalRemote.Appliances;

namespace UniversalRemote.Commands
{
    internal class CeilingLightCommand : IOnCommand, IOffCommand
    {
        private readonly CeilingLight ceilingLight;
        private bool isOn;

        public CeilingLightCommand(CeilingLight ceilingLight)
        {
            this.ceilingLight = ceilingLight;
        }

        void IOnCommand.Execute()
        {
            if(isOn) return;

            ceilingLight.SwitchOn();
            isOn = true;
        }

        void IOffCommand.Execute()
        {
            if(!isOn) return;

            ceilingLight.SwitchOff();
            isOn = false;
        }

        public void Undo()
        {
            throw new NotImplementedException();
        }
    }
}