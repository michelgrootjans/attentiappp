namespace MightyGumball
{
    public interface IGumballMachine
    {
        void DispenseGumball();
        bool HasGumballsLeft { get;}
        IState State { set; }
        void AddGumballs(int numberOfGumballs);
    }
}