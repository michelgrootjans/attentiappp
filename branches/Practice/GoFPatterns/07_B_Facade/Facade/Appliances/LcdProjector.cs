using System;

namespace Facade.Appliances
{
    internal class LcdProjector
    {
        public void On()
        {
            Console.WriteLine("Switching LCD Projector on");
        }

        public void SetInput(IProjectorInput input)
        {
            Console.WriteLine("Setting the input of the LCD Projector to " + input.Name);
        }

        public void SetWidescreenMode()
        {
            Console.WriteLine("LCD projector is set to widescreen");
        }
    }
}