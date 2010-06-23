using System;

namespace MightyGumball
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var gumballMachine = new GumballMachine(1);
            Console.WriteLine(gumballMachine);

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            Console.WriteLine(gumballMachine);

            gumballMachine.Fill(10);
            Console.WriteLine(gumballMachine);

            gumballMachine.EjectQuarter();
            Console.ReadLine();
        }
    }
}