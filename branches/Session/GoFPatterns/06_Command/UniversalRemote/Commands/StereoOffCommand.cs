using UniversalRemote.Appliances;

namespace UniversalRemote.Commands
{
    internal class StereoOffCommand : IOffCommand
    {
        private readonly Stereo stereo;

        public StereoOffCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }


        public void Execute()
        {
            stereo.SwitchOff();
        }

        public void Undo()
        {
            stereo.SwitchOn();
        }
    }
}