using System;

namespace MightyGumball
{
    public class SoldOutState : AbstractState
    {
        public SoldOutState(IGumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public override void InsertQuarter()
        {
            Console.WriteLine("You can't insert a quarter, the machine is sold out");
        }

        public override void EjectQuarter()
        {
            Console.WriteLine("You can't eject, you haven't inserted a quarter yet");
        }

        public override void TurnCrank()
        {
            Console.WriteLine("You turned, but there are no gumballs");
        }

        public override void Dispense()
        {
            Console.WriteLine("Mag niet");
        }

        public override void Fill(int numberOfGumballs)
        {
            base.Fill(numberOfGumballs);
            gumballMachine.State = new NoQuarterState(gumballMachine);
        }
    }
}