namespace MightyGumball
{
    public class GumballMachine : IGumballMachine
    {
        private int count;
        private IState state;

        public GumballMachine(int count)
        {
            this.count = count;
            if (this.count > 0)
                state = new NoQuarterState(this);
            else
            {
                state = new SoldOutState(this);
            }
        }

        public void InsertQuarter()
        {
            state.InsertQuarter();
        }

        public void EjectQuarter()
        {
            state.EjectQuarter();
        }

        public void TurnCrank()
        {
            state.TurnCrank();
            Dispense();
        }

        private void Dispense()
        {
            state.Dispense();
        }

        public override string ToString()
        {
            var message = "\nMighty Gumball, Inc.\n";
            message += "Inventory: " + count + " gumballs\n";
            message += state;
            return message + "\n";
        }

        public void DispenseGumball()
        {
            count--;
        }

        public bool HasGumballsLeft
        {
            get { return count > 0;}
        }

        public IState State
        {
            set { state = value; }
        }

        public void AddGumballs(int numberOfGumballs)
        {
            count += numberOfGumballs;
        }

        public void Fill(int numberOfGumballs)
        {
            state.Fill(numberOfGumballs);
        }
    }
}