using System;

namespace MightyGumball
{
    public class HasQuarterState : AbstractState
    {
        private readonly IGumballMachine gumballMachine;

        public HasQuarterState(IGumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public override void InsertQuarter()
        {
            Console.WriteLine("You can't insert another quarter");
        }

        public override void EjectQuarter()
        {
            Console.WriteLine("You get back your quarter");
            gumballMachine.State = new NoQuarterState(gumballMachine);
        }

        public override void TurnCrank()
        {
            Console.WriteLine("You turned ...");
            gumballMachine.State = new SoldState(gumballMachine);
        }

        public override void Dispense()
        {
            Console.WriteLine("Mag niet");
        }
    }
}