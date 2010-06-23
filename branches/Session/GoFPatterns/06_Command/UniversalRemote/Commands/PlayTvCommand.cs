using UniversalRemote.Appliances;

namespace UniversalRemote.Commands
{
    internal class PlayTvCommand : IOnCommand
    {
        private readonly Television tv;
        private readonly int channelNr;

        public PlayTvCommand(Television tv, int channelNr)
        {
            this.tv = tv;
            this.channelNr = channelNr;
        }

        public void Execute()
        {
            tv.On();
            tv.SetChannel(channelNr);
        }

        public void Undo()
        {
            tv.Off();
        }
    }
}