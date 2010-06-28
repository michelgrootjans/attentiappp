using Interfaces;

namespace Kata
{
    public class CustomerDetailPresenter : ICustomerDetailPresenter
    {
        private readonly ICustomerDetailView view;

        public CustomerDetailPresenter(ICustomerDetailView view)
        {
            this.view = view;
        }

        public void Init()
        {
            //get data from service...
            var customerId = view.GetCustomerId();
            var customer = new Customer{Id = customerId, Name = "Attentia"};

            view.SetCustomer(customer);
            view.SetSaveButtonVisibility(customerId >= 10);
        }
    }

    public class Customer : ICustomer
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}