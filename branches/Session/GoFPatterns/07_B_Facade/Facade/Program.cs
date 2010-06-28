using System;
using System.Threading;
using Facade.Appliances;

namespace Facade
{
    class Program
    {
        static void Main()
        {
            var movie = new Dvd("Harry Potter 8");
            var party = new PartyUtility(movie);
            party.SwitchOn();

            Thread.Sleep(5000);
            party.SwitchOff();

            Console.ReadLine();
        }
    }
}
