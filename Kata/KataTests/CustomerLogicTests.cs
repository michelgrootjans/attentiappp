using System;
using NUnit.Framework;
using Rhino.Mocks;

namespace KataTests
{
    [TestFixture]
    public class CustomerLogic_BoekVerlof_MetGenoegVerlof
    {
        private ICustomerDao customerDao;
        private ICustomer customer;
        private CustomerLogic customerLogic;
        private int aantalDagenOver;

        [SetUp]
        public void SetUp()
        {
            customerDao = MockRepository.GenerateMock<ICustomerDao>();
            customer = MockRepository.GenerateMock<ICustomer>();

            customerDao.Stub(d => d.GetById(25)).Return(customer);
            customer.Stub(c => c.VerlofDagenBeschikbaar).Return(7);

            customerLogic = new CustomerLogic(customerDao);
            aantalDagenOver = customerLogic.BoekVerlof(25, new DateTime(2010, 6, 10), new DateTime(2010, 6, 22));
        }

        [Test]
        public void should_get_the_customer()
        {
            customerDao.AssertWasCalled(d => d.GetById(25));
        }

        [Test]
        public void should_get_beschikbare_verlofdagen()
        {
            customerDao.AssertWasCalled(d => d.GetBeschikbareVerlofdagen(25));
        }

        [Test]
        public void should_assign_extra_verlofdagen()
        {
            customer.AssertWasCalled(c => c.AddVerlofDagen(3));
        }

        [Test]
        public void should_save_the_customer()
        {
            customerDao.AssertWasCalled(c=> c.Save(customer));
        }

        [Test]
        public void should_return_aantaldagen_over()
        {
            Assert.AreEqual(7, aantalDagenOver);
        }
    }

    [TestFixture]
    internal class BoekVerlof_met_te_weinig_verlofdagen_faalt
    {
        
    }
}