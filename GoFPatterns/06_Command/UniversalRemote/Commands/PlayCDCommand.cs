using System;
using UniversalRemote.Appliances;

namespace UniversalRemote.Commands
{
    internal class PlayCDCommand : ICommand, IOnCommand
    {
        private readonly Stereo stereo;
        private readonly int volume;

        public PlayCDCommand(Stereo stereo, int volume)
        {
            this.stereo = stereo;
            this.volume = volume;
        }

        public void Execute()
        {
            stereo.SwitchOn();
            stereo.SetVolume(volume);
            stereo.PlayCd();
        }

        public void Undo()
        {
            stereo.SwitchOff();
        }
    }
}