using System;

namespace MightyGumball
{
    public class GumballMachine
    {
        private int _count = 0;
        private State _state = State.SoldOut;

        public GumballMachine(int count)
        {
            _count = count;
            if (_count > 0)
                _state = State.NoQuarter;
        }

        public void InsertQuarter()
        {
            switch (_state)
            {
                case State.HasQuarter:
                    Console.WriteLine("You can't insert another quarter");
                    break;
                case State.NoQuarter:
                    _state = State.HasQuarter;
                    Console.WriteLine("You inserted a quarter");
                    break;
                case State.SoldOut:
                    Console.WriteLine("You can't insert a quarter, the machine is sold out");
                    break;
                case State.Sold:
                    Console.WriteLine("Please wait, we're already giving you a gumball");
                    break;
            }
        }

        public void EjectQuarter()
        {
            switch (_state)
            {
                case State.HasQuarter:
                    _state = State.NoQuarter;
                    Console.WriteLine("Quarter Returned");
                    break;
                case State.NoQuarter:
                    Console.WriteLine("You haven't inserted a quarter yet");
                    break;
                case State.Sold:
                    Console.WriteLine("Sorry, you already turned the crank");
                    break;
                case State.SoldOut:
                    Console.WriteLine("You can't eject, you haven't inserted a quarter yet");
                    break;
            }
        }

        public void TurnCrank()
        {
            switch (_state)
            {
                case State.Sold:
                    Console.WriteLine("Turning twice doesn't give you another gumball");
                    break;
                case State.NoQuarter:
                    Console.WriteLine("You turned, but there's no quarter");
                    break;
                case State.SoldOut:
                    Console.WriteLine("You turned, but there are no gumballs");
                    break;
                case State.HasQuarter:
                    Console.WriteLine("You turned ...");
                    _state = State.Sold;
                    Dispense();
                    break;
            }
        }

        private void Dispense()
        {
            switch (_state)
            {
                case State.Sold:
                    Console.WriteLine("A gumball comes rolling out of the slot");
                    _count--;
                    if (_count <= 0)
                    {
                        Console.WriteLine("Oops, out of gumballs");
                        _state = State.SoldOut;
                    }
                    else
                    {
                        _state = State.NoQuarter;
                    }
                    break;
                case State.NoQuarter:
                    Console.WriteLine("You need to pay first");
                    break;
                case State.SoldOut:
                    Console.WriteLine("No gumball dispensed");
                    break;
                case State.HasQuarter:
                    Console.WriteLine("No gumball dispensed");
                    break;
            }
        }

        public override string ToString()
        {
            string message = "\nMighty Gumball, Inc.\n";
            message += "Inventory: " + _count + " gumballs\n";
            switch (_state)
            {
                case State.HasQuarter:
                    message += "Has quarter";
                    break;
                case State.NoQuarter:
                    message += "Waiting for quarter";
                    break;
                case State.Sold:
                    message += "Sold";
                    break;
                case State.SoldOut:
                    message += "Sold out";
                    break;
            }
            return message + "\n";
        }

        #region Nested type: State

        private enum State
        {
            SoldOut,
            NoQuarter,
            HasQuarter,
            Sold
        }

        #endregion
    }
}