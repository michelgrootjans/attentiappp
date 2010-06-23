namespace MightyGumball
{
    public abstract class AbstractState : IState
    {
        protected IGumballMachine gumballMachine;

        public abstract void InsertQuarter();
        public abstract void EjectQuarter();
        public abstract void TurnCrank();
        public abstract void Dispense();

        public virtual void Fill(int numberOfGumballs)
        {
            gumballMachine.AddGumballs(numberOfGumballs);
        }
    }
}