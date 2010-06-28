using System;

namespace KataTests
{
    public class CustomerLogic
    {
        private readonly ICustomerDao customerDao;

        public CustomerLogic()
        {
            this.customerDao = new CustomerDao();
        }

        public CustomerLogic(ICustomerDao customerDao)
        {
            this.customerDao = customerDao;
        }

        public int BoekVerlof(int customerId, DateTime vanaf, DateTime totEnMet)
        {
            var customer = customerDao.GetById(customerId);
            var beschikbareVerlofdagen = customerDao.GetBeschikbareVerlofdagen(customerId);
            customer.AddVerlofDagen(3);
            customerDao.Save(customer);
            return customer.VerlofDagenBeschikbaar;
        }


    }

    public class CustomerDao : ICustomerDao
    {
        public ICustomer GetById(int customerId)
        {
            throw new NotImplementedException();
        }

        public int GetBeschikbareVerlofdagen(int customerId)
        {
            throw new NotImplementedException();
        }

        public void Save(ICustomer customer)
        {
            throw new NotImplementedException();
        }
    }
}