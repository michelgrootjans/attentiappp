using System;

namespace MightyGumball
{
    public class NoQuarterState : AbstractState
    {
        public NoQuarterState(IGumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public override void InsertQuarter()
        {
            gumballMachine.State = new HasQuarterState(gumballMachine);
        }

        public override void EjectQuarter()
        {
            Console.WriteLine("You can't eject if nothing has been inserted!");
        }

        public override void TurnCrank()
        {
            Console.WriteLine("You get no gumballs if nothing has been inserted!");
        }

        public override void Dispense()
        {
            Console.WriteLine("Mag niet");
        }
    }
}