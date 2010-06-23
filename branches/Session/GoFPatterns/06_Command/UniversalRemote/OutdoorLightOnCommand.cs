using UniversalRemote.Appliances;

namespace UniversalRemote
{
    internal class OutdoorLightOnCommand : ICommand, IOnCommand
    {
        private readonly OutdoorLight outdoorLight;

        public OutdoorLightOnCommand(OutdoorLight outdoorLight)
        {
            this.outdoorLight = outdoorLight;
        }

        public void Execute()
        {
            outdoorLight.On();
        }

        public void Undo()
        {
            outdoorLight.Off();
        }
    }
}