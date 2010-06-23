namespace MightyGumball
{
    public interface IState
    {
        void InsertQuarter();
        void EjectQuarter();
        void TurnCrank();
        void Dispense();
        void Fill(int numberOfGumballs);
    }
}