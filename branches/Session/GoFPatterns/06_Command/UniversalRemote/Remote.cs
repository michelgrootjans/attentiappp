using System;
using UniversalRemote.Appliances;

namespace UniversalRemote
{
    internal class Remote
    {
        private OutdoorLight outdoorLight;
        private CeilingLight ceilingLight;
        private Television tv;
        private Stereo stereo;

        public Remote()
        {
            outdoorLight = new OutdoorLight();
            ceilingLight = new CeilingLight();
            tv = new Television();
            stereo = new Stereo();
        }

        public void PushOnButton(int buttonNumber)
        {
            switch (buttonNumber)
            {
                case 0:
                    outdoorLight.On();
                    break;
                case 1:
                    ceilingLight.SwitchOn();
                    break;
                case 2:
                    tv.On();
                    tv.SetChannel(1);
                    break;
                case 3:
                    stereo.SwitchOn();
                    stereo.SetVolume(5);
                    stereo.PlayCd();
                    break;
                default:
                    Console.WriteLine("Red light... (unknown command)");
                    break;
            }
        }

        public void PushOffButton(int buttonNumber)
        {
            switch (buttonNumber)
            {
                case 0:
                    outdoorLight.Off();
                    break;
                case 1:
                    ceilingLight.SwitchOff();
                    break;
                case 2:
                    tv.Off();
                    break;
                case 3:
                    stereo.SwitchOff();
                    break;
                default:
                    Console.WriteLine("Red light... (unknown command)");
                    break;
            }
        }
    }
}