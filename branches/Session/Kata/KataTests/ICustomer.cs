namespace KataTests
{
    public interface ICustomer
    {
        void AddVerlofDagen(int aantalVerlofdagen);
        int VerlofDagenBeschikbaar { get; }
    }
}