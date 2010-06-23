using System;

namespace MightyGumball
{
    public class SoldState : AbstractState
    {
        private readonly IGumballMachine gumballMachine;

        public SoldState(IGumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public override void InsertQuarter()
        {
            Console.WriteLine("Please wait, we're already giving you a gumball");
        }

        public override void EjectQuarter()
        {
            Console.WriteLine("Sorry, you already turned the crank");
        }

        public override void TurnCrank()
        {
            Console.WriteLine("Turning twice doesn't give you another gumball");
        }

        public override void Dispense()
        {
            Console.WriteLine("A gumball comes rolling out");

            gumballMachine.DispenseGumball();
            if (gumballMachine.HasGumballsLeft)
                gumballMachine.State = new NoQuarterState(gumballMachine);
            else
                gumballMachine.State = new SoldOutState(gumballMachine);
        }
    }
}