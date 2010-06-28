namespace Interfaces
{
    public interface ICustomerDetailView
    {
        int GetCustomerId();

        void SetCustomer(ICustomer customer);
        void SetSaveButtonVisibility(bool isVisible);
    }
}