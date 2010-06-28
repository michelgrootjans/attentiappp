namespace KataTests
{
    public interface ICustomerDao
    {
        ICustomer GetById(int customerId);
        int GetBeschikbareVerlofdagen(int customerId);
        void Save(ICustomer customer);
    }
}