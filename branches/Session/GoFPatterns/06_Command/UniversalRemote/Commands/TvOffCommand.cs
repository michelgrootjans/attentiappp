using UniversalRemote.Appliances;

namespace UniversalRemote.Commands
{
    internal class TvOffCommand : IOffCommand
    {
        private readonly Television tv;

        public TvOffCommand(Television tv)
        {
            this.tv = tv;
        }

        public void Execute()
        {
            tv.Off();
        }

        public void Undo()
        {
            tv.On();
        }
    }
}